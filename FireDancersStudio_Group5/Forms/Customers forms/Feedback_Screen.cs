using FireDancersStudio_Group5.Forms.Finish_Screens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireDancersStudio_Group5.Forms
{
    public partial class Feedback_Screen : Form
    {
        private string instructor_id;
        private string room_id;
        private DateTime startTime;

        public Feedback_Screen(string instructor_id, string room_id, DateTime startTime)
        {
            this.instructor_id = instructor_id;
            InitializeComponent();
            this.room_id = room_id;
            this.startTime = startTime;
        }

        private void Logout_TextChanged(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage_Customer homepage_customer = new HomePage_Customer();
            homepage_customer.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string customerID = Login.getCustomerID_Login();

            int rating1 = (int)numericUpDown1.Value;
            int rating2 = (int)numericUpDown1.Value;
            int rating3 = (int)numericUpDown1.Value;

            string datails1 = Details_textBox5.Text;
            string datails2 = Details_textBox6.Text;
            string datails3 = Details_textBox7.Text;

            Feedback feedback = new Feedback(rating1, rating2, rating3, datails1, datails2, datails3);

            feedback.AddNewFeedback(this.startTime, this.room_id, customerID, this.instructor_id);

            this.Hide();
            SuccessFeedback successFeedback = new SuccessFeedback();
            successFeedback.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage_Customer homePage_Customer = new HomePage_Customer();
            homePage_Customer.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterToClass registerToClass = new RegisterToClass();
            registerToClass.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
