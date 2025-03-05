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
    public partial class ReadMessages : Form
    {
        public ReadMessages()
        {
            InitializeComponent();
            loadMessagesdataGridViewWithData();
        }

        private void loadMessagesdataGridViewWithData()
        {
            string userID = Login.getCustomerID_Login();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "EXECUTE dbo.SP_GetEntityRole @ID";
            cmd.Parameters.AddWithValue("@ID", userID);
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(cmd);

            string role = "";
            while (rdr.Read())
            {
                role = rdr.GetValue(1).ToString();
            }

            cmd = new SqlCommand();
            cmd.CommandText = "EXECUTE dbo.SP_ShowMessagesByRecipientType @recipientType";
            cmd.Parameters.AddWithValue("@recipientType", role);
            SC = new SQL_CON();
            SC.execute_non_query(cmd);

            try
            {
                // ביצוע השאילתה והחזרת תוצאה ב-DataTable
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // הצגת הנתונים ב-DataGridView
                Messages_dataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
     
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (Login.getUserType_Login().Equals("Worker"))
            {
                this.Hide();
                HomePage_Administrator homePage_Administrator = new HomePage_Administrator();
                homePage_Administrator.Show();
            }
            else
            {
                this.Hide();
                HomePage_Customer homePage_Customer = new HomePage_Customer();
                homePage_Customer.Show();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Login.getUserType_Login().Equals("Worker"))
            {
                this.Hide();
                HomePage_Administrator homePage_Administrator = new HomePage_Administrator();
                homePage_Administrator.Show();
            }
            else
            {
                this.Hide();
                HomePage_Customer homePage_Customer = new HomePage_Customer();
                homePage_Customer.Show();                
            }
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
