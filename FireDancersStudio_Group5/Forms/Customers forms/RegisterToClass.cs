using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireDancersStudio_Group5.Forms.Finish_Screens;

namespace FireDancersStudio_Group5.Forms
{
    public partial class RegisterToClass : Form
    {
        public RegisterToClass()
        {
            InitializeComponent();            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            InitGridCheckboxes();

            // CheckBox to choose only one row
            if (lessons_dataGridView.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                foreach (DataGridViewRow row in lessons_dataGridView.Rows)
                {
                    if (row.Index == e.RowIndex)
                    {
                        //Uncheck all other checkboxes
                        DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)row.Cells["Select"];
                        checkBoxCell.Value = true;
                    }
                }
            }
        }

        //Search foe lessons by date
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        //Choose lesson to sign
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage_Customer homepage_customer = new HomePage_Customer();
            homepage_customer.Show();
        }

        private void InitGridCheckboxes()
        {
            for (int i = 0; i < lessons_dataGridView.Rows.Count; i++)
            {
                if (lessons_dataGridView.Rows[i].IsNewRow)
                    continue;

                DataGridViewRow row = lessons_dataGridView.Rows[i];

                lessons_dataGridView.Rows[i].Cells[0].Value = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string customerID = "";
            DateTime startTime = new DateTime();
            string roomID = "";
            string workerID = "";
            bool isChecked = false;

            DataGridView dataGridView = lessons_dataGridView;

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (dataGridView.Rows[i].IsNewRow)
                    continue;

                DataGridViewRow row = dataGridView.Rows[i];

                Console.WriteLine(row.Cells[0].Value);

                if (row.Cells[0].Value != null && row.Cells[0].Value is bool)
                {
                    isChecked = (bool)row.Cells[0].Value;

                    if (isChecked)
                    {
                        customerID = Login.getCustomerID_Login();
                        startTime = DateTime.Parse(row.Cells[1].Value.ToString());
                        roomID = row.Cells["roomID"].Value.ToString();
                        workerID = row.Cells["instructor"].Value.ToString();
                        break;
                    }
                }


                //    foreach (DataGridViewRow row in dataGridView.Rows)
                //{
                //    DataGridViewCheckBoxCell checkBoxCell = row.Cells["Select"] as DataGridViewCheckBoxCell;

                //    if (checkBoxCell != null && checkBoxCell.Value != null && (bool)checkBoxCell.Value)
                //    {
                //        // קבלת נתונים מעמודות אחרות בשורה המסומנת
                //        customerID = Login.getCustomerID_Login();
                //        startTime = DateTime.Parse(row.Cells[1].Value.ToString());
                //        roomID = row.Cells["roomID"].Value.ToString();
                //        workerID = row.Cells["instructor"].Value.ToString();
                //        break;
                //    }
                //}
            }

            //Check if the customer is already signed to the studio class
            if (isChecked)
            {
                Customer current_customer = Program.seekCustomer(customerID);
                List<Attendance> customer_attendance_list = current_customer.GetAttendanceList();
                foreach(Attendance attendance in customer_attendance_list)
                {
                    if(attendance.GetStudioClass().getDateTime().Equals(startTime) &&
                        attendance.GetStudioClass().GetRoom().GetRoomID().Equals(roomID)&&
                        attendance.GetStudioClass().GetWorker().getID().Equals(workerID)&&
                        attendance.GetCustomer().GetID().Equals(customerID))
                    {
                        MessageBox.Show("קיימת הרשמה קודמת לשיעור זה", "המשך", MessageBoxButtons.OK);
                        return;
                    }
                }
            }

            if (isChecked)
            {
                SqlCommand c = new SqlCommand();
                c.CommandText = "EXECUTE dbo.SP_EnrollCustomer @customerID, @startTime, @roomID, @workerID";
                c.Parameters.AddWithValue("@customerID", customerID);
                c.Parameters.AddWithValue("@startTime", startTime);
                c.Parameters.AddWithValue("@roomID", roomID);
                c.Parameters.AddWithValue("@workerID", workerID);

                SQL_CON SC = new SQL_CON();
                SC.execute_non_query(c);

                Attendance new_attendance = new Attendance(Program.seekCustomer(customerID), Program.seekStudioClasses(startTime, roomID),
                            Program.seekWorker(workerID), false);
                Program.Attendances.Add(new_attendance);
                Program.seekCustomer(customerID).InsertNewAttendance(new_attendance);
                Program.seekStudioClasses(startTime, roomID).InsertNewAttendance(new_attendance);

                this.Hide();
                SuccessRegister successRegister = new SuccessRegister();
                successRegister.Show();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;
            StudioClass studioClass = new StudioClass(selectedDate);


            //SqlCommand c = new SqlCommand();
            //c.CommandText = "EXECUTE dbo.SP_GetStudioClassDetails @startTime";
            //c.Parameters.AddWithValue("@startTime", selectedDate);
            //SQL_CON SC = new SQL_CON();
            //SC.execute_non_query(c);

            SqlCommand c = studioClass.GetStudioClassInfoByDate();

            try
            {
                // ביצוע השאילתה והחזרת תוצאה ב-DataTable
                SqlDataAdapter da = new SqlDataAdapter(c);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // הצגת הנתונים ב-DataGridView
                lessons_dataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage_Customer homePage_Customer = new HomePage_Customer();
            homePage_Customer.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseFeedbackDate chooseFeedbackDate = new ChooseFeedbackDate();
            chooseFeedbackDate.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
