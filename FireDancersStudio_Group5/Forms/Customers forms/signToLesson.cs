using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireDancersStudio_Group5.Forms
{
    public partial class signToLesson : Form
    {
        public signToLesson()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage_Administrator homePage_Administrator = new HomePage_Administrator();
            homePage_Administrator.Show();
        }
    }
}
