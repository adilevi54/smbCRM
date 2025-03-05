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
    public partial class CreateNewLesson : Form
    {
        public CreateNewLesson()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Hide();
            HomePage_Administrator homePage_Administrator = new HomePage_Administrator();
            homePage_Administrator.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage_Administrator homePage_Administrator = new HomePage_Administrator();
            homePage_Administrator.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.Hide();
            ManageWorkers manageWorkers = new ManageWorkers();
            manageWorkers.Show();
        }

        private void CreateNewLesson_Load(object sender, EventArgs e)
        {

        }

        private void CreateNewLesson_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
