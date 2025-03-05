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
    public partial class searchWorker : Form
    {
        private Worker exist_Worker;
        public searchWorker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //הצגת הכפתורים
            updateWorker_button.Show();
            deleteWorker_button.Show();
            //איתור המופע המתאים והצגת הפרטים
            exist_Worker = Program.seekWorker(ID_insert_textBox.Text);
            firstname_textBox.Text = exist_Worker.getFirstName();
            lastname_textBox.Text = exist_Worker.getLastName();
            phone_textBox.Text = exist_Worker.getPhone();
            email_textBox.Text = exist_Worker.getEmail();
            role_textBox.Text = exist_Worker.getRole().ToString();
            firstname_textBox.Enabled = true;
            lastname_textBox.Enabled = true;
            phone_textBox.Enabled = true;
            email_textBox.Enabled = true;
            role_textBox.Enabled = false;
        }

        private void searchWorker_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            exist_Worker.DeleteWorker();

            searchWorker sw = new searchWorker();
            sw.Show();
            this.Close();
        }

        private void updateWorker_button_Click(object sender, EventArgs e)
        {
            exist_Worker.set_firstName(firstname_textBox.Text);
            exist_Worker.set_lastName(lastname_textBox.Text);
            exist_Worker.set_phone(phone_textBox.Text);
            exist_Worker.set_email(email_textBox.Text);
            exist_Worker.UpdateWorker();

            searchWorker sw = new searchWorker();
            sw.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void return_button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageWorkers mw = new ManageWorkers();
            mw.Show();
        }

        private void ID_insert_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
