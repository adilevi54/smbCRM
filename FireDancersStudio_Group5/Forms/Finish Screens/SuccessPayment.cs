﻿using System;
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
    public partial class SuccessPayment : Form
    {
        public SuccessPayment()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage_Customer homePage_Customer = new HomePage_Customer();
            homePage_Customer.Show();
        }
    }
}
