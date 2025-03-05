using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FireDancersStudio_Group5
{
    public partial class createWorker: Form
    {
        public createWorker()
        {
            InitializeComponent();
            RoleComboBox.DataSource = Enum.GetValues(typeof(WorkerRoleEnum));//אתחול הקומבובוקס
            GenderComboBox.DataSource = Enum.GetValues(typeof(GenderEnum));//אתחול הקומבובוקס
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void addWorker_button_Click(object sender, EventArgs e)
        {
            Worker W = new Worker(id_textBox2.Text, firstname_textBox2.Text, lastname_textBox2.Text, (GenderEnum)Enum.Parse(typeof(GenderEnum), GenderComboBox.Text), DateTime.Parse(birthdate_textBox2.Text), address_textBox2.Text, phonetextBox2.Text, email_textBox2.Text, (WorkerRoleEnum)Enum.Parse(typeof(WorkerRoleEnum), RoleComboBox.Text), workerPasswordTextBox.Text, true);//יצירת עובד חדש


            ManageWorkers mw = new ManageWorkers();
            mw.Show();
            this.Close();
        }

        private void birthdate_textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (!DateTime.TryParse(birthdate_textBox2.Text, out _))
            {
                e.Cancel = true;
                MessageBox.Show("Invalid date format. Please enter a valid date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void birthdate_textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void phonetextBox2_Validating(object sender, CancelEventArgs e)
        {
            if (!IsValidPhoneNumber(phonetextBox2.Text))
            {
                e.Cancel = true;
                MessageBox.Show("Invalid phone number. Please enter a 10-digit phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidPhoneNumber(string phone)
        {
            // This is a simple validation. Adjust as needed for your specific requirements.
            return System.Text.RegularExpressions.Regex.IsMatch(phone, @"^\d{10}$");
        }

        private void email_textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (!IsValidEmail(email_textBox2.Text))
            {
                e.Cancel = true;
                MessageBox.Show("Invalid email format. Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageWorkers mw = new ManageWorkers();
            mw.Show();
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
