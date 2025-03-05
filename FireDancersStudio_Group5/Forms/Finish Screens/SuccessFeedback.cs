using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireDancersStudio_Group5.Forms.Finish_Screens
{
    public partial class SuccessFeedback : Form
    {
        public SuccessFeedback()
        {
            InitializeComponent();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage_Customer homepage_customer = new HomePage_Customer();
            homepage_customer.Show();
        }
    }
}
