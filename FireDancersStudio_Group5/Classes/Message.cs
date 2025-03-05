using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireDancersStudio_Group5
{
    public class Message
    {
        private DateTime sendTime;
        private string subject;
        private string content;
        private Worker sender;
        private bool readingStatus;
        private List<Worker> workers;
        private List<Customer> customers;

        public Message(DateTime sendTime, string subject, string content, Worker sender, bool readingStatus)
        {
            this.sendTime = sendTime;
            this.subject = subject;
            this.content = content;
            this.sender = sender;
            this.readingStatus = readingStatus;
            this.workers = new List<Worker>();
            this.customers = new List<Customer>();
        }

        //Insert new message to the main Messages list
        public void InsertNewMessage(string targetAudience)
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_InsertMessage @subject, @content, @sender, @recipientType";

            c.Parameters.AddWithValue("@subject", this.subject);
            c.Parameters.AddWithValue("@content", this.content);
            c.Parameters.AddWithValue("@sender", this.sender.getID());
            c.Parameters.AddWithValue("@recipientType", targetAudience);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);

            Program.Messages.Add(this);
        }
    }
}
