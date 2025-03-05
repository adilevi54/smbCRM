using FireDancersStudio_Group5.Forms;
using FireDancersStudio_Group5.Forms.Workers_forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireDancersStudio_Group5
{
    public partial class HomePage_Administrator : Form
    {
        public HomePage_Administrator()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.Hide();
            Manage_Lessons manage_Lessons = new Manage_Lessons();
            manage_Lessons.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.Hide();
            ManageWorkers manageWorkers = new ManageWorkers();
            manageWorkers.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageWorkers manageWorkers = new ManageWorkers();
            manageWorkers.Show();
        }

        private void Logout_TextChanged(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReadMessages readMessages = new ReadMessages();
            readMessages.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseLessonToMarkAttendance chooseLessonToMarkAttendance = new ChooseLessonToMarkAttendance();
            chooseLessonToMarkAttendance.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseLessonToMarkAttendance chooseLessonToMarkAttendance = new ChooseLessonToMarkAttendance();
            chooseLessonToMarkAttendance.Show();
        }
    }
}
