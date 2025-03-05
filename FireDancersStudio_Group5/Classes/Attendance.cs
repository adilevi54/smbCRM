using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireDancersStudio_Group5
{
    public class Attendance
    {
        private Customer customer;
        private StudioClass studioClass;
        private Worker Worker;
        private bool status;


        public Attendance(Customer customer, StudioClass studioClass, Worker worker, bool status)
        {
            this.customer = customer;
            this.studioClass = studioClass;
            this.Worker = worker;
            this.status = status;
        }

        public Customer GetCustomer()
        {
            return customer;
        }

        public StudioClass GetStudioClass()
        {
            return studioClass;
        }

        public Worker GetWorker()
        {
            return Worker;
        }

        public bool GetStatus()
        {
            return status;
        }

        public void SetStatus(bool status)
        {
            this.status = status;
        }


        public static List<Attendance> showRegisteredCustomers(DateTime start_time, string roomID)
        {
            List<Attendance> attendances = new List<Attendance>();

            foreach (Attendance attendance in Program.Attendances)
            {
                if(attendance.GetStudioClass().getDateTime().Equals(start_time) && attendance.GetStudioClass().GetRoom().GetRoomID().Equals(roomID))
                {
                    attendances.Add(attendance);
                }
            }
            return attendances;
        }

        public static List<StudioClass> showInstructorLessons(string workerID)
        {
            List<StudioClass> studioClasses = new List<StudioClass>();

            foreach (StudioClass studioClass in Program.StudioClasses)
            {
                //Check if the customer registerd to this class
                if (!studioClass.GetWorker().getID().Equals(workerID))
                    continue;
                else
                    studioClasses.Add(studioClass);
            }

            return studioClasses;            
        }

        public void UpdateAttendanceStatus(DateTime start_time, string roomID, bool status)
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_UpdateAttendanceStatus @customerID, @startTime, @roomID, @status";
            c.Parameters.AddWithValue("@customerID", this.customer.GetID());
            c.Parameters.AddWithValue("@startTime", start_time);
            c.Parameters.AddWithValue("@roomID", roomID);
            c.Parameters.AddWithValue("@status", status);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);

            this.SetStatus(status);
        }
    }
}
