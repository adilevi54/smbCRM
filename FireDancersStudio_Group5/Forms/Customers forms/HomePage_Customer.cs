using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireDancersStudio_Group5.Forms.Customers_forms;

namespace FireDancersStudio_Group5.Forms
{
    public partial class HomePage_Customer : Form
    {
        public HomePage_Customer()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterToClass registerToClass = new RegisterToClass();
            registerToClass.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseFeedbackDate chooseFeedbackDate = new ChooseFeedbackDate();
            chooseFeedbackDate.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterToClass registerToClass = new RegisterToClass();
            registerToClass.Show();
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReadMessages readMessages = new ReadMessages();
            readMessages.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment payment = new Payment();
            payment.Show();
        }
    }
}
