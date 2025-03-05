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
using FireDancersStudio_Group5.Classes;
using FireDancersStudio_Group5.Forms.Finish_Screens;

namespace FireDancersStudio_Group5.Forms.Workers_forms
{
    public partial class Mark_Attendance : Form
    {

        private DateTime start_time;
        private string roomID;
        private string workerID;

        public Mark_Attendance(DateTime start_time, string roomID, string workerID)
        {
            this.start_time = start_time;
            this.roomID = roomID;
            this.workerID = workerID;
            InitializeComponent();
            GetAttendanceInfo(Attendance.showRegisteredCustomers(start_time, roomID));
        }

        public void GetAttendanceInfo(List<Attendance> attendance_list)
        {
            foreach (Attendance attendance in attendance_list)
            {
                //Add new line to grid
                int rowIndex = Attendance_dataGridView.Rows.Add();
                string customer_name = "";

                foreach (Customer customer in Program.Customers)
                {
                    if (attendance.GetCustomer().GetID() == customer.GetID())
                    {
                        customer_name = customer.GetFirstName() + " " + customer.GetLastName();
                        break;
                    }
                }

                if(attendance.GetStatus() == true)
                {
                    Attendance_dataGridView.Rows[rowIndex].Cells[2].Value = true;
                    Attendance_dataGridView.Rows[rowIndex].Cells[3].Value = false;
                }
                else
                {
                    Attendance_dataGridView.Rows[rowIndex].Cells[2].Value = false;
                    Attendance_dataGridView.Rows[rowIndex].Cells[3].Value = true;
                }

                
                Attendance_dataGridView.Rows[rowIndex].Cells["Customer_Name"].Value = customer_name;
                Attendance_dataGridView.Rows[rowIndex].Cells["Customer_ID"].Value = attendance.GetCustomer().GetID();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage_Administrator homePage_Administrator = new HomePage_Administrator();
            homePage_Administrator.Show();
        }

        private void Attendance_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = Attendance_dataGridView.Rows[e.RowIndex];

            // אם ה-CheckBox הראשון הוסמן, נסיר את הסימון מה-CheckBox השני
            if (e.ColumnIndex == Attendance_dataGridView.Columns["Present"].Index)
            {

                row.Cells["Present"].Value = true;
                row.Cells["Not_Present"].Value = false;               
            }
            // אם ה-CheckBox השני הוסמן, נסיר את הסימון מה-CheckBox הראשון
            else if (e.ColumnIndex == Attendance_dataGridView.Columns["Not_Present"].Index)
            {
                row.Cells["Not_Present"].Value = true;
                row.Cells["Present"].Value = false;
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Variables
            DataGridViewRow row;
            Customer customer;
            bool status = false;
            Attendance attendance;

            for (int i = 0; i < Attendance_dataGridView.Rows.Count; i++)
            {
                row = Attendance_dataGridView.Rows[i];


                customer = Program.seekCustomer(Attendance_dataGridView.Rows[i].Cells[1].Value.ToString());
                attendance = Program.seekAttendance(customer, start_time, roomID);

                if ((bool)row.Cells["Present"].Value == false)
                    status =  false;
                else
                    status = true;

                attendance.UpdateAttendanceStatus(start_time, roomID, status);
            }

            this.Hide();
            SuccessAttendance successAttendance = new SuccessAttendance();
            successAttendance.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateNewMessage createNewMessage = new CreateNewMessage();
            createNewMessage.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReadMessages readMessages = new ReadMessages();
            readMessages.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage_Administrator homePage_Administrator = new HomePage_Administrator();
            homePage_Administrator.Show();
        }
    }
}
