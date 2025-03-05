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
    public partial class ManageWorkers : Form
    {
        public ManageWorkers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchWorker f = new searchWorker();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            createWorker c = new createWorker();
            c.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage_Administrator homePage_Administrator = new HomePage_Administrator();
            homePage_Administrator.Show();
        }
    }
}
