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
    public partial class SuccessCustomerRegistration : Form
    {
        public SuccessCustomerRegistration()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            First_Screen first_Screen = new First_Screen();
            first_Screen.Show();
        }
    }
}
