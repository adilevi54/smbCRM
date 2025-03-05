using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireDancersStudio_Group5.Classes;

namespace FireDancersStudio_Group5
{
    public class Customer
    {
        public string ID;
        public GenderEnum gender;
        public string firstName;
        public string lastName;
        public DateTime birthDate;
        public BranchEnum branch;
        public string source;
        public CustomerEnum customerType;
        public string email;
        public string phoneNumber;
        public List<Attendance> attendances;
        public List<MembershipOrder> membershipOrders;
        public List<Feedback> feedbacks;
        public List<Message> messages;
        public List<Event> events;

        public Customer(string id, GenderEnum gender, string firstName, string lastName, DateTime birthDate,
                        BranchEnum branch, string source, CustomerEnum customerType, string email, string phoneNumber, List<Attendance> attendances,
                        List<MembershipOrder> membershipOrders, bool isNew)
        {
            this.ID = id;
            this.gender = gender;
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
            this.branch = branch;
            this.source = source;
            this.customerType = customerType;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.attendances = attendances;
            this.membershipOrders = membershipOrders;
            this.feedbacks = new List<Feedback>();
            this.messages = new List<Message>();
            this.events = new List<Event>();

            if (isNew)
            {
                this.CreateCustomer();
            }
        }

        public string GetID()
        {
            return this.ID;
        }

        public string GetFirstName()
        {
            return this.firstName;
        }

        public string GetLastName()
        {
            return this.lastName;
        }

        public List<Attendance> GetAttendanceList()
        {
            return this.attendances;
        }

        public void SetAttendanceList(List<Attendance> attendanceList)
        {
            this.attendances = attendanceList;
        }

        public void SetCustomerList(List<MembershipOrder> membershipOrders)
        {
            this.membershipOrders = membershipOrders;
        }

        public void InsertMembershipOrder(MembershipOrder membershipOrder)
        {
            this.membershipOrders.Add(membershipOrder);
        }

        public void InsertNewAttendance(Attendance attendance)
        {
            this.attendances.Add(attendance);
        }

        public void CreateCustomer()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "EXECUTE SP_add_customer @id, @gender, @firstName, @lastName, @birthDate, @branch, @source, @customerType, @email, @phoneNumber";

            cmd.Parameters.AddWithValue("@id", this.ID);
            cmd.Parameters.AddWithValue("@gender", this.gender);
            cmd.Parameters.AddWithValue("@firstName", this.firstName);
            cmd.Parameters.AddWithValue("@lastName", this.lastName);
            cmd.Parameters.AddWithValue("@birthDate", this.birthDate);
            cmd.Parameters.AddWithValue("@branch", this.branch);
            cmd.Parameters.AddWithValue("@source", this.source);
            cmd.Parameters.AddWithValue("@customerType", this.customerType);
            cmd.Parameters.AddWithValue("@email", this.email);
            cmd.Parameters.AddWithValue("@phoneNumber", this.phoneNumber);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(cmd);
        }

        public void UpdateCustomer()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_customer @id, @gender, @firstName, @lastName, @birthDate, @branch, @source, @customerType, @email, @phoneNumber";
            c.Parameters.AddWithValue("@id", this.ID);
            c.Parameters.AddWithValue("@gender", this.gender.ToString());
            c.Parameters.AddWithValue("@firstName", this.firstName);
            c.Parameters.AddWithValue("@lastName", this.lastName);
            c.Parameters.AddWithValue("@birthDate", this.birthDate);
            c.Parameters.AddWithValue("@branch", this.branch.ToString());
            c.Parameters.AddWithValue("@source", this.source);
            c.Parameters.AddWithValue("@customerType", this.customerType.ToString());
            c.Parameters.AddWithValue("@email", this.email);
            c.Parameters.AddWithValue("@phoneNumber", this.phoneNumber);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void DeleteCustomer()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_delete_customer @id";
            c.Parameters.AddWithValue("@id", this.ID);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }


        public void UpdateCustomerAttendance(List<Attendance> attendance)
        {
            List<Attendance> temp_attendance = new List<Attendance>();
            foreach (Attendance att in attendance)
            {
                if(att.GetCustomer().GetID() == this.GetID())
                    temp_attendance.Add(att);
            }
            SetAttendanceList(temp_attendance);
        }

        public void UpdateCustomerMembershipOrder()
        {
            List<MembershipOrder> temp_membershipOrder = new List<MembershipOrder>();
            foreach (MembershipOrder mo in Program.MembershipOrders)
            {
                if (mo.GetCustomer().GetID() == this.GetID())
                    temp_membershipOrder.Add(mo);
            }
            SetCustomerList(temp_membershipOrder);
        }
    }
}