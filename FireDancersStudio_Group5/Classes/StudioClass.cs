using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireDancersStudio_Group5.Classes;

namespace FireDancersStudio_Group5
{
    public class StudioClass
    {
        private DateTime startTime;
        private int capacity;
        private string details;
        private DifficultyEnum difficulty;
        private Room room;
        private Worker worker;
        private List<Customer> customer;
        private List<Feedback> feedbacks;
        private List<DanceStyle> danceStyles;
        private List<Attendance> attendances;


        //Constructor
        public StudioClass(DateTime startTime, int capacity, string details, DifficultyEnum difficulty, Room room, Worker worker, List<Customer> customer,
            List<Feedback> feedbacks, List<DanceStyle> danceStyles, List<Attendance> attendances)
        {
            this.startTime = startTime;
            this.capacity = capacity;
            this.details = details;
            this.difficulty = difficulty;
            this.room = room;
            this.worker = worker;
            this.customer = customer;
            this.feedbacks = feedbacks;
            this.danceStyles = danceStyles;
            this.attendances = attendances;
        }

        public StudioClass(DateTime startTime)
        {
            this.startTime = startTime;
            this.capacity = 0;
            this.details = "";
            this.difficulty = (DifficultyEnum)Enum.Parse(typeof(DifficultyEnum), "Beginners");
            this.room = null;
            this.worker = null;
            this.customer = null;
            this.feedbacks = null;
            this.danceStyles = null;
            this.attendances = null;
        }

        //Return studio class start time
        public DateTime getDateTime()
        {
            return startTime;
        }

        //Return studio class capacity
        public int getCapacity()
        {
            return capacity;
        }

        //Return studio class details
        public string getDetails()
        {
            return details;
        }

        //Return studio class difficulty
        public DifficultyEnum getDifficulty()
        {
            return difficulty;
        }

        public Room GetRoom()
        {
            return room;
        }

        public Worker GetWorker()
        {
            return worker;
        }

        //Set studio class start time
        public void setDateTime(DateTime startTime)
        {
            this.startTime = startTime;
        }

        //set studio class capacity
        public void setCapacity(int capacity)
        {
            this.capacity = capacity;
        }

        //set studio class details
        public void setDetails(string details)
        {
            this.details = details;
        }

        //set studio class difficulty
        public void setDifficulty(DifficultyEnum difficulty)
        {
            this.difficulty = difficulty;
        }

        public void setAttendancelist(List<Attendance> attendanceList)
        {
            this.attendances = attendanceList;
        }

        public void InsertNewAttendance(Attendance attendance)
        {
            this.attendances.Add(attendance);
        }

        //public void ShowStudioClass()
        //{
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.CommandText = "EXECUTE dbo.GetStudioClassDetails";
        //    cmd.Parameters.AddWithValue("@startDate", this.startTime);
    
        //    SQL_CON SC = new SQL_CON();
        //    SC.execute_non_query(cmd);
        //}

        //public void UpdateStidioClassAttendance(List<Attendance> attendance)
        //{
        //    List<Attendance> temp_attendance = new List<Attendance>();
        //    foreach (Attendance att in attendance)
        //    {
        //        if (att.GetStudioClass() == this)
        //            temp_attendance.Add(att);
        //    }
        //    this.setAttendancelist(temp_attendance);
        //}

        public SqlCommand GetStudioClassInfoByDate()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_GetStudioClassDetails @startTime";
            c.Parameters.AddWithValue("@startTime", this.startTime);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);

            return c;
        }
    }
}

    
