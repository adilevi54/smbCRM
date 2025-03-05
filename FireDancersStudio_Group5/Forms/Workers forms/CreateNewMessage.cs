using FireDancersStudio_Group5.Forms.Finish_Screens;
using FireDancersStudio_Group5.Forms.Workers_forms;
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
    public partial class CreateNewMessage : Form
    {
        public CreateNewMessage()
        {
            InitializeComponent();
            Fill_audience_comboBox();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Fill_audience_comboBox()
        {
            List<string> audienceList = new List<string>(Enum.GetNames(typeof(WorkerRoleEnum)));
            audienceList.Add("Customer");
            audience_comboBox.DataSource = audienceList.ToArray();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string workerID = Login.getCustomerID_Login();
            string subject = subject_textBox.Text;
            string content = content_textBox.Text;
            string targetAudience = audience_comboBox.Text;

            if(subject_textBox.Text.Equals("") || content_textBox.Text.Equals(""))
            {
                MessageBox.Show("חסר מידע לצורך שליחת ההודעה", "המשך", MessageBoxButtons.OK);
                return;
            }

            Message message = new Message(DateTime.Now, subject, content, Program.seekWorker(workerID), false);
            message.InsertNewMessage(targetAudience);

            this.Hide();
            SuccessSendingMessage successSendingMessage = new SuccessSendingMessage(targetAudience);
            successSendingMessage.Show();
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
            HomePage_Administrator homePage_Administrator = new HomePage_Administrator();
            homePage_Administrator.Show();
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

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseLessonToMarkAttendance chooseLessonToMarkAttendance = new ChooseLessonToMarkAttendance();
            chooseLessonToMarkAttendance.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
