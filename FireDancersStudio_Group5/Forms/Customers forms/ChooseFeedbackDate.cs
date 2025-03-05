using FireDancersStudio_Group5.Classes;
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
    public partial class ChooseFeedbackDate : Form
    {
        private string instructor_id;
        private string room_id;

        public ChooseFeedbackDate()
        {
            this.instructor_id = "";
            this.room_id = "";
            InitializeComponent();
            fill_combo_box();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string userID = Login.getCustomerID_Login();
            DateTime startTime = DateTime.Parse(lessons_list_combobox.Text);

            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.GetClassInfo @userID, @startTime";
            c.Parameters.AddWithValue("@userID", userID);
            c.Parameters.AddWithValue("@startTime", startTime);

            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            while (rdr.Read())
            {
                Instructor_Name_Fill.Text = rdr.GetValue(1).ToString() + " " + rdr.GetValue(2).ToString();
                this.instructor_id = rdr.GetValue(3).ToString();
                this.room_id = rdr.GetValue(4).ToString();
            }
        }

        //Fill the combo box with the lessons that the customer took
        private void fill_combo_box()
        {
            List<string> records = new List<string>();
            string userID = Login.getCustomerID_Login();

            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.GetCustomerClasses @userID";
            c.Parameters.AddWithValue("@userID", userID);

            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            while (rdr.Read())
            {
                records.Add(rdr.GetValue(0).ToString());
            }

            lessons_list_combobox.DataSource = records;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChooseFeedbackDate_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (lessons_list_combobox.Text.Equals(""))
            {
                MessageBox.Show("לא נכחת באף שיעור. אי אפשר למלא משוב", "המשך", MessageBoxButtons.OK);
            }
            else
            {
                this.Hide();
                Feedback_Screen feedbackScreen = new Feedback_Screen(this.instructor_id, this.room_id, DateTime.Parse(lessons_list_combobox.Text));
                feedbackScreen.Show();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage_Customer homepage_customer = new HomePage_Customer();
            homepage_customer.Show();
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

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}
