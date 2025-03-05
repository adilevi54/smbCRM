using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireDancersStudio_Group5.Forms.Finish_Screens;

namespace FireDancersStudio_Group5
{
    public class Feedback
    {
        private int experienceRating;
        private int instructorRating;
        private int difficultyRating;
        private string experienceText;
        private string instructorText;
        private string difficultyText;
        private Worker worker;
        private Customer customer;
        private StudioClass studioClass;

        //Constructor
        public Feedback(int experienceRating, int instructorRating, int difficultyRating,
        string experienceText, string instructorText, string difficultyText)
        {
            this.experienceRating = experienceRating;
            this.instructorRating = instructorRating;
            this.difficultyRating = difficultyRating;
            this.experienceText = experienceText;
            this.instructorText = instructorText;
            this.difficultyText = difficultyText;
            this.worker = null;
            this.customer = null;
            this.studioClass = null;
        }

        public int GetExperienceRating()
        {
            return experienceRating;
        }

        public int GetInstructorRating()
        {
            return instructorRating;
        }

        public int GetDifficultyRating()
        {
            return difficultyRating;
        }

        public string GetExperienceText()
        {
            return experienceText;
        }

        public string GetInstructorText()
        {
            return instructorText;
        }

        public string GetDifficultyText()
        {
            return difficultyText;
        }

        public void AddNewFeedback(DateTime start_time, string room_ID, string customer_ID, string instructor_ID)
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.InsertFeedback @startTime, @roomID, @customerID, @workerID, @experienceRating, @instructorRating, @difficultyRating, @experienceText, @instructorText, @difficultyText";

            c.Parameters.AddWithValue("@startTime", start_time);
            c.Parameters.AddWithValue("@roomID", room_ID);
            c.Parameters.AddWithValue("@customerID", customer_ID);
            c.Parameters.AddWithValue("@workerID", instructor_ID);

            c.Parameters.AddWithValue("@experienceRating", this.experienceRating);
            c.Parameters.AddWithValue("@instructorRating", this.instructorRating);
            c.Parameters.AddWithValue("@difficultyRating", this.difficultyRating);
            c.Parameters.AddWithValue("@experienceText", this.experienceText);
            c.Parameters.AddWithValue("@instructorText", this.instructorText);
            c.Parameters.AddWithValue("@difficultyText", this.difficultyText);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);

            Program.Feedbacks.Add(this);
        }
    }
}
