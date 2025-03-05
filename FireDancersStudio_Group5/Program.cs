using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using FireDancersStudio_Group5.Forms;
using FireDancersStudio_Group5.Classes;


namespace FireDancersStudio_Group5
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        //רשימות
        public static System.Collections.Generic.List<Worker> Workers = new List<Worker>();
        public static System.Collections.Generic.List<Customer> Customers = new List<Customer>();
        public static System.Collections.Generic.List<StudioClass> StudioClasses = new List<StudioClass>();
        public static System.Collections.Generic.List<Room> Rooms = new List<Room>();
        public static System.Collections.Generic.List<Attendance> Attendances = new List<Attendance>();
        public static System.Collections.Generic.List<Scheduled> Scheduled = new List<Scheduled>();
        public static System.Collections.Generic.List<MembershipOrder> MembershipOrders = new List<MembershipOrder>();
        public static System.Collections.Generic.List<MembershipPackage> MembershipPackages = new List<MembershipPackage>();

        public static System.Collections.Generic.List<Feedback> Feedbacks = new List<Feedback>();
        public static System.Collections.Generic.List<Message> Messages = new List<Message>();


        [STAThread]

        //שיטה שמחפשת עובד ברשימה לפי תעודת זהות
        public static Worker seekWorker(string id)
        {
            foreach (Worker w in Workers)
            {
                if (w.getID() == id)
                    return w;
            }
            return null;
        }


        public static Customer seekCustomer(string id)
        {
            foreach (Customer c in Customers)
            {
                if (c.GetID() == id)
                    return c;
            }
            return null;
        }


        public static StudioClass seekStudioClasses(DateTime datetime ,string roomID)
        {
            foreach (StudioClass s in StudioClasses)
            {
                if (s.GetRoom().GetRoomID() == roomID && s.getDateTime() == datetime)
                    return s;
            }
            return null;
        }


        public static Room seekRoom(string roomID)
        {
            foreach (Room r in Rooms)
            {
                if (r.GetRoomID() == roomID)
                    return r;
            }
            return null;
        }

        public static Scheduled seekScheduled(DateTime start_time, string roomID)
        {
            foreach (Scheduled s in Scheduled)
            {
                if (s.GetStartTime().Equals(start_time) && s.GetRoomID().Equals(roomID))
                    return s;
            }
            return null;
        }

        public static Attendance seekAttendance(Customer customer, DateTime startTime, string roomID)
        {
            foreach (Attendance a in Attendances)
            {
                if (a.GetCustomer().Equals(customer) &&
                    a.GetStudioClass().getDateTime().Equals(startTime) &&
                    a.GetStudioClass().GetRoom().GetRoomID() == roomID)
                    return a;
            }
            return null;
        }


        public static MembershipPackage seekMembershipPackage(string packageName)
        {
            foreach (MembershipPackage m in MembershipPackages)
            {
                if (m.GetPackageName() == packageName)
                    return m;
            }
            return null;
        }

        public static void initLists()//מילוי הרשימות מתוך בסיס הנתונים
        {
            init_workers();
            init_customers();
            init_room();
            init_scheduled();
            init_studioClass();
            init_attendance();
            init_MembershipPackage();
            init_MembershipOrder();
                        
        }

         

        public static void init_workers()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Workers";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Workers = new List<Worker>();

            while (rdr.Read())
            {
                WorkerRoleEnum role = (WorkerRoleEnum)Enum.Parse(typeof(WorkerRoleEnum), rdr.GetValue(8).ToString());
                GenderEnum gender = (GenderEnum)Enum.Parse(typeof(GenderEnum), rdr.GetValue(3).ToString());

                Worker w = new Worker(
                    workerID: rdr.GetValue(0).ToString(),
                    firstName: rdr.GetValue(1).ToString(),
                    lastName: rdr.GetValue(2).ToString(),
                    gender: gender,
                    birthDate: DateTime.Parse(rdr.GetValue(4).ToString()),
                    address: rdr.GetValue(5).ToString(),
                    phoneNumber: rdr.GetValue(6).ToString(),
                    email: rdr.GetValue(7).ToString(),
                    role: role,
                    password: rdr.GetValue(8).ToString(),
                    is_new: false

                );
                Workers.Add(w);
            }
        }

        public static void init_customers()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand sq = new SqlCommand();
            sq.CommandText = "EXECUTE dbo.Get_all_Customers";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(sq);
            Customers = new List<Customer>();
            while (rdr.Read())
            {
                GenderEnum gender = (GenderEnum)Enum.Parse(typeof(GenderEnum), rdr.GetValue(8).ToString());
                BranchEnum branch = (BranchEnum)Enum.Parse(typeof(BranchEnum), rdr.GetValue(4).ToString());
                CustomerEnum customerType = (CustomerEnum)Enum.Parse(typeof(CustomerEnum), rdr.GetValue(7).ToString());

                Customer c = new Customer(
                    id: rdr.GetValue(0).ToString(),
                    gender: gender,
                    firstName: rdr.GetValue(1).ToString(),
                    lastName: rdr.GetValue(2).ToString(),
                    birthDate: DateTime.Parse(rdr.GetValue(3).ToString()),
                    branch: branch,
                    source: rdr.GetValue(5).ToString(),
                    customerType: customerType,
                    email: rdr.GetValue(6).ToString(),
                    phoneNumber: rdr.GetValue(7).ToString(),
                    isNew: false,
                    attendances: new List<Attendance>(),
                    membershipOrders: null
                );
                Customers.Add(c);
            }
        }

        

        public static void init_room()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand sq = new SqlCommand();
            sq.CommandText = "EXECUTE dbo.SP_Get_All_Rooms";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(sq);
            //Rooms = new List<Room>();
            while (rdr.Read())
            {
                BranchEnum branch = (BranchEnum)Enum.Parse(typeof(BranchEnum), rdr.GetValue(1).ToString());

                Room r = new Room(
                    roomID: rdr.GetValue(0).ToString(),
                    branch: branch,
                    capacity: int.Parse(rdr.GetValue(2).ToString()));

                Rooms.Add(r);
            }
        }


        public static void init_attendance()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand sq = new SqlCommand();
            sq.CommandText = "EXECUTE dbo.SP_Get_All_Attendance";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(sq);
            Attendances = new List<Attendance>();
            while (rdr.Read())
            {
                Attendance a = new Attendance(
                    customer: seekCustomer(rdr.GetValue(0).ToString()),
                    studioClass: seekStudioClasses(DateTime.Parse(rdr.GetValue(1).ToString()), rdr.GetValue(2).ToString()),
                    worker: seekWorker(rdr.GetValue(3).ToString()),
                    status: bool.Parse(rdr.GetValue(4).ToString()));

                Attendances.Add(a);
            }

            //Update customers attendance
            foreach(Customer customer in Customers)
            {
                customer.UpdateCustomerAttendance(Attendances);
            }

            //Update worker attendance
            foreach(Worker w in Workers)
            {
                w.UpdateWorkerAttendance(Attendances);
            }
        }


        public static void init_scheduled()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand sq = new SqlCommand();
            sq.CommandText = "EXECUTE dbo.SP_GetAllScheduled";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(sq);
            StudioClasses = new List<StudioClass>();
            while (rdr.Read())
            {
                Scheduled s = new Scheduled(
                    workerID: rdr.GetValue(0).ToString(),
                    start_time: DateTime.Parse(rdr.GetValue(1).ToString()),
                    roomID: rdr.GetValue(2).ToString());

                Scheduled.Add(s);
            }
        }


        public static void init_studioClass()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand sq = new SqlCommand();
            sq.CommandText = "EXECUTE dbo.SP_GetAllStudioClasses";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(sq);
            StudioClasses = new List<StudioClass>();
            while (rdr.Read())
            {
                DifficultyEnum difficulty = (DifficultyEnum)Enum.Parse(typeof(DifficultyEnum), rdr.GetValue(2).ToString());
                List<Customer> customerList = new List<Customer>();
                List<Attendance> attendanceList = new List<Attendance>();
                foreach (Attendance attendance in Attendances)
                {
                    if (rdr.GetValue(0).ToString().Equals(attendance.GetStudioClass().getDateTime()) &&
                        rdr.GetValue(1).ToString().Equals(attendance.GetStudioClass().GetRoom()))
                    {
                        customerList.Add(seekCustomer(attendance.GetCustomer().GetID()));
                        attendanceList.Add(attendance);
                    }
                }

                StudioClass s = new StudioClass(
                    startTime: DateTime.Parse(rdr.GetValue(0).ToString()),
                    capacity: seekRoom(rdr.GetValue(1).ToString()).GetCapacity(),
                    details: rdr.GetValue(3).ToString(),
                    difficulty: difficulty,
                    room: seekRoom(rdr.GetValue(1).ToString()),
                    worker: seekWorker(seekScheduled(DateTime.Parse(rdr.GetValue(0).ToString()), seekRoom(rdr.GetValue(1).ToString()).GetRoomID()).GetWorkerID()),
                    customer: customerList,
                    feedbacks: new List<Feedback>(),
                    danceStyles: new List<DanceStyle>(),
                    attendances: attendanceList);

                StudioClasses.Add(s);
                customerList = new List<Customer>();
                attendanceList = new List<Attendance>();
            }
        }


        public static void init_MembershipPackage()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand sq = new SqlCommand();
            sq.CommandText = "EXECUTE dbo.SP_GetAllMembershipPackage";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(sq);
            MembershipPackages = new List<MembershipPackage>();

            while (rdr.Read())
            {
                ClassesLimitEnum classesLimitPerWeek = (ClassesLimitEnum)Enum.Parse(typeof(ClassesLimitEnum), rdr.GetValue(1).ToString());
                CycleEnum paymentCycle = (CycleEnum)Enum.Parse(typeof(CycleEnum), rdr.GetValue(2).ToString());

                MembershipPackage m = new MembershipPackage(
                    packageName: rdr.GetValue(0).ToString(),
                    classesLimitPerWeek: classesLimitPerWeek,
                    paymentCycle: paymentCycle,
                    price: rdr.GetValue(3).ToString(),
                    orders: null);

                MembershipPackages.Add(m);
            }
        }


        public static void init_MembershipOrder()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand sq = new SqlCommand();
            sq.CommandText = "EXECUTE dbo.SP_GetAllMembershipOrder";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(sq);
            MembershipOrders = new List<MembershipOrder>();

            while (rdr.Read())
            {
                MembershipOrder m = new MembershipOrder(
                    orderID: rdr.GetValue(0).ToString(),
                    priceForCustomer: rdr.GetValue(1).ToString(),
                    paymentConfirmation: rdr.GetValue(2).ToString(),
                    package: seekMembershipPackage(rdr.GetValue(3).ToString()),
                    customer: seekCustomer(rdr.GetValue(4).ToString()));


                MembershipOrders.Add(m);
            }

            foreach (MembershipPackage mp in MembershipPackages)
            {
                mp.UpdateOrders();
            }

            foreach(Customer customer in Customers)
            {
                customer.UpdateCustomerMembershipOrder();
            }
        }



        static void OnApplicationExit(object sender, EventArgs e)
        {
            //Stop running when openning the file
            Application.Exit(); 
        }


        static void Main()
        {
            Application.ApplicationExit += new EventHandler(OnApplicationExit);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            initLists();//Init all lists
            Application.Run(new First_Screen());
        }
    }
}
