using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using FireDancersStudio_Group5.Classes;

namespace FireDancersStudio_Group5
{
    public class Worker
        {
        private string workerID;
        private string firstName;
        private string lastName;
        private GenderEnum gender;
        private DateTime birthDate;
        private string address;
        private string phoneNumber;
        private string email;
        private WorkerRoleEnum role;
        private string password;
        private List<StudioClass> studioClasses;
        private Contract contract;
        private List<Event> events;
        private List<Message> sent_messages;
        private List<Message> received_messages;
        private List<Feedback> feedbacks;
        private List<Attendance> attendances;

        public Worker(string workerID, string firstName, string lastName, GenderEnum gender,
                          DateTime birthDate, string address, string phoneNumber, string email, WorkerRoleEnum role, string password, Boolean is_new)
            {
                this.workerID = workerID;
                this.firstName = firstName;
                this.lastName = lastName;
                this.gender = gender;
                this.birthDate = birthDate;
                this.address = address;
                this.phoneNumber = phoneNumber;
                this.email = email;
                this.role = role;
                this.password = password;
                this.studioClasses = new List<StudioClass>();
                this.contract = null;
                this.events = new List<Event>();
                this.sent_messages = new List<Message>();
                this.received_messages = new List<Message>();
                this.feedbacks = new List<Feedback>();
                this.attendances = new List<Attendance>();

                if (is_new)
                {
                    this.CreateWorker();
                    Program.Workers.Add(this);
                }
        }

        //Return the worker's ID
        public string getID()
        {
            return this.workerID;
        }

        //Return worker's first name
        public string getFirstName()
        {
            return this.firstName;
        }

        //Return worker's first name
        public string getLastName()
        {
            return this.lastName;
        }

        //Return worker's phone number
        public string getPhone()
        {
            return this.phoneNumber;
        }

        //Return worker's Email
        public string getEmail()
        {
            return this.email;
        }

        //Return worker's role
        public string getRole()
        {
            return this.role.ToString();
        }

        //Return the password
        public string getPassword()
        {
            return this.password;
        }

        //Set worker's first name
        public void set_firstName(string name)
        {
            this.firstName = name;
        }

        //Set worker's last name
        public void set_lastName(string name)
        {
            this.lastName = name;
        }

        //Set worker's phone
        public void set_phone(string phone)
        {
            this.phoneNumber = phone;
        }

        //Set worker's email
        public void set_email(string email)
        {
            this.email = email;
        }

        //Set the password
        public void setPassword(string password)
        {
            this.password = password;
        }

        public void setAttendanceList(List<Attendance> attendanceList)
        {
            this.attendances = attendanceList;
        }

        //Create a new worker in the database
        public void CreateWorker()
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "EXECUTE dbo.SP_Add_Worker @workerID, @firstName, @lastName, @gender, @birthDate, @address, @phoneNumber, @email, @role, @password";
                
                cmd.Parameters.AddWithValue("@workerID", this.workerID);
                cmd.Parameters.AddWithValue("@firstName", this.firstName);
                cmd.Parameters.AddWithValue("@lastName", this.lastName);
                cmd.Parameters.AddWithValue("@gender", this.gender.ToString());
                cmd.Parameters.AddWithValue("@birthDate", this.birthDate);
                cmd.Parameters.AddWithValue("@address", this.address);
                cmd.Parameters.AddWithValue("@phoneNumber", this.phoneNumber);
                cmd.Parameters.AddWithValue("@email", this.email);
                cmd.Parameters.AddWithValue("@role", this.role.ToString());
                cmd.Parameters.AddWithValue("@password", this.role.ToString());

                SQL_CON SC = new SQL_CON();
                SC.execute_non_query(cmd);
            }

        //Update worker in the database
        public void UpdateWorker()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "EXECUTE dbo.SP_Update_Worker @id, @firstName, @lastName, @gender, @birthDate, @address, @phoneNumber, @email, @role";

            cmd.Parameters.AddWithValue("@id", this.workerID);
            cmd.Parameters.AddWithValue("@firstName", this.firstName);
            cmd.Parameters.AddWithValue("@lastName", this.lastName);
            cmd.Parameters.AddWithValue("@gender", this.gender.ToString());
            cmd.Parameters.AddWithValue("@birthDate", this.birthDate);
            cmd.Parameters.AddWithValue("@address", this.address);
            cmd.Parameters.AddWithValue("@phoneNumber", this.phoneNumber);
            cmd.Parameters.AddWithValue("@email", this.email);
            cmd.Parameters.AddWithValue("@role", this.role.ToString());

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(cmd);
        }

        //Delete worker in the database
        public void DeleteWorker()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "EXECUTE dbo.SP_Delete_Worker @workerID";
            cmd.Parameters.AddWithValue("@workerID", this.workerID);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(cmd);
        }

        public void UpdateWorkerAttendance(List<Attendance> attendance)
        {
            List<Attendance> temp_attendance = new List<Attendance>();
            foreach (Attendance att in attendance)
            {
                if (att.GetWorker().getID() == this.getID())
                    temp_attendance.Add(att);
            }
            setAttendanceList(temp_attendance);
        }
    }
}
