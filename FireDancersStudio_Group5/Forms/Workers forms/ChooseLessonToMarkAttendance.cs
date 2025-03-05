using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireDancersStudio_Group5.Classes;

namespace FireDancersStudio_Group5.Forms.Workers_forms
{
    public partial class ChooseLessonToMarkAttendance : Form
    {

        public ChooseLessonToMarkAttendance()
        {
            InitializeComponent();
            GetClassInfo(Attendance.showInstructorLessons(Login.getCustomerID_Login()));
        }

        public void GetClassInfo(List<StudioClass> studioClass)
        {
            foreach (StudioClass studioclass in studioClass)
            {
                //Add new line to grid
                int rowIndex = MarkAttendance_dataGridView.Rows.Add();

                // מילוי שם הלקוח בעמודה הראשונה
                MarkAttendance_dataGridView.Rows[rowIndex].Cells[0].Value = false;
                MarkAttendance_dataGridView.Rows[rowIndex].Cells[1].Value = studioclass.getDateTime().ToString();
                MarkAttendance_dataGridView.Rows[rowIndex].Cells[2].Value = studioclass.GetRoom().GetRoomID();
                MarkAttendance_dataGridView.Rows[rowIndex].Cells[3].Value = studioclass.getDifficulty().ToString();
                MarkAttendance_dataGridView.Rows[rowIndex].Cells[4].Value = studioclass.getDetails();


            }
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage_Administrator homePage_Administrator = new HomePage_Administrator();
            homePage_Administrator.Show();
        }


        //Check if there is any checkbox mark
        private bool checkForMarkedCheckbox(DataGridView dataGridView)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (dataGridView.Rows[i].IsNewRow)
                    continue;

                DataGridViewRow row = dataGridView.Rows[i];
                if (row.Cells["Select"].Value != null && row.Cells["Select"].Value is bool)
                {
                    bool isChecked = (bool)row.Cells["Select"].Value;

                    if (isChecked)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DateTime startTime = new DateTime();
            string roomID = "";
            DataGridView dataGridView = MarkAttendance_dataGridView;
            MarkAttendance_dataGridView.Refresh();

            if (!checkForMarkedCheckbox(dataGridView))
            {
                MessageBox.Show("לא נבחר אף שיעור לצורך מילוי נוכחות", "המשך", MessageBoxButtons.OK);
                return;
            }

            for (int i = 0; i < MarkAttendance_dataGridView.Rows.Count; i++)
            {
                if (MarkAttendance_dataGridView.Rows[i].IsNewRow)
                    continue;

                DataGridViewRow row = dataGridView.Rows[i];
                if (row.Cells["Select"].Value != null && row.Cells["Select"].Value is bool)
                {
                    bool isChecked = (bool)row.Cells["Select"].Value;

                    // אם ה-CheckBox מסומן
                    if (isChecked)
                    {
                        // קבלת המידע מהשורות המסומנות
                        startTime = DateTime.Parse(row.Cells["Start_Time"].Value.ToString());
                        roomID = row.Cells["Room"].Value.ToString();
                    }
                }
            }
            this.Hide();
            Mark_Attendance mark_Attendance = new Mark_Attendance(startTime, roomID, Login.getCustomerID_Login());
            mark_Attendance.Show();
        }

        private void MarkAttendance_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCheckBoxCell checkBoxCell;
            // CheckBox to choose only one row
            if (MarkAttendance_dataGridView.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                foreach (DataGridViewRow row in MarkAttendance_dataGridView.Rows)
                {
                    if (row.Index != e.RowIndex)
                    {
                        //Uncheck all other checkboxes
                        checkBoxCell = (DataGridViewCheckBoxCell)row.Cells["Select"];
                        checkBoxCell.Value = false;
                    }
                    else
                    { 
                        checkBoxCell = (DataGridViewCheckBoxCell)row.Cells["Select"];
                        checkBoxCell.Value = true;
                    }
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage_Administrator homePage_Administrator = new HomePage_Administrator();
            homePage_Administrator.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReadMessages readMessages = new ReadMessages();
            readMessages.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateNewMessage createNewMessage = new CreateNewMessage();
            createNewMessage.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
