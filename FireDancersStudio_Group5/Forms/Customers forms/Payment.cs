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
using System.Xml.Linq;
using FireDancersStudio_Group5.Classes;
using FireDancersStudio_Group5.Forms.Workers_forms;
using System.Net;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using FireDancersStudio_Group5.Forms.Finish_Screens;

namespace FireDancersStudio_Group5.Forms.Customers_forms
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
            LoadAvailablePackages();
            LoadUnAvailablePackages();
        }

        //Load customer current packages
        private void LoadAvailablePackages()
        {
            List<MembershipOrder> currentOrders = MembershipOrder.showCustomersOrders(Login.getCustomerID_Login());

            foreach (MembershipOrder orders in currentOrders)
            {
                //Add new line to grid
                int rowIndex = ownPackages_dataGridView.Rows.Add();

                // מילוי שם הלקוח בעמודה הראשונה
                ownPackages_dataGridView.Rows[rowIndex].Cells[0].Value = orders.GetPackage().GetPackageName();
            }
        }

        //Load customer missing packages
        private void LoadUnAvailablePackages()
        {
            List<MembershipPackage> unavailablePackages = MembershipOrder.showCustomersMissingPackages(Login.getCustomerID_Login());

            foreach (MembershipPackage package in unavailablePackages)
            {
                //Add new line to grid
                int rowIndex = newPackages_dataGridView.Rows.Add();

                if (newPackages_dataGridView.ColumnCount >= 5)
                {
                    // מילוי שם הלקוח בעמודה הראשונה
                    newPackages_dataGridView.Rows[rowIndex].Cells[0].Value = false;
                    newPackages_dataGridView.Rows[rowIndex].Cells[1].Value = package.GetPackageName();
                    newPackages_dataGridView.Rows[rowIndex].Cells[2].Value = package.GetClassesLimitPerWeek().ToString();
                    newPackages_dataGridView.Rows[rowIndex].Cells[3].Value = package.GetPaymentCycle().ToString();
                    newPackages_dataGridView.Rows[rowIndex].Cells[4].Value = package.GetPrice();
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCheckBoxCell checkBoxCell;
            // CheckBox to choose only one row
            if (newPackages_dataGridView.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                foreach (DataGridViewRow row in newPackages_dataGridView.Rows)
                {
                    if (row.Index != e.RowIndex)
                    {
                        //Uncheck all other checkboxes
                        checkBoxCell = (DataGridViewCheckBoxCell)row.Cells["Select"];
                        checkBoxCell.Value = false;
                    }
                    else
                    {
                        checkBoxCell = (DataGridViewCheckBoxCell)row.Cells["Select"];
                        checkBoxCell.Value = true;
                    }
                }
            }
        }

        private void newPackages_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCheckBoxCell checkBoxCell;
            // CheckBox to choose only one row
            if (newPackages_dataGridView.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                foreach (DataGridViewRow row in newPackages_dataGridView.Rows)
                {
                    if (row.Index != e.RowIndex)
                    {
                        //Uncheck all other checkboxes
                        checkBoxCell = (DataGridViewCheckBoxCell)row.Cells["Select"];
                        checkBoxCell.Value = false;
                    }
                    else
                    {
                        checkBoxCell = (DataGridViewCheckBoxCell)row.Cells["Select"];
                        checkBoxCell.Value = true;
                    }
                }
            }
        }

        //Check if there is any checkbox mark
        private bool checkForMarkedCheckbox(DataGridView dataGridView)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (dataGridView.Rows[i].IsNewRow)
                    continue;

                DataGridViewRow row = dataGridView.Rows[i];
                if (row.Cells["Select"].Value != null && row.Cells["Select"].Value is bool)
                {
                    bool isChecked = (bool)row.Cells["Select"].Value;

                    if (isChecked)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string orderID = "";
            string packageName = "";
            string customerID = "";
            string price = "";
            string paymentConfirmation = "";
            bool flag = true;
            int asciiValue;



            for (int i = 0; i < creditCard_textBox.Text.Length; i++)
            {
                asciiValue = creditCard_textBox.Text[i];  // קבלת ערך ASCII של התו

                // אם ערך ה-ASCII לא נמצא בטווח של 48 עד 57, זה לא ספרה
                if (asciiValue < 48 || asciiValue > 57)
                {
                    flag = false;
                    break; // יציאה מהלולאה ברגע שמצאנו תו שאינו ספרה
                }
            }

            //Check if the info is valid and get all the other needed info
            if (creditCard_textBox.Text.Length == 16 && flag)
            {
                DataGridView dataGridView = newPackages_dataGridView;

                if(!checkForMarkedCheckbox(dataGridView))
                {
                    MessageBox.Show("לא נבחרה אף חבילה", "המשך", MessageBoxButtons.OK);
                    return;
                }

                for (int i = 0; i < newPackages_dataGridView.Rows.Count; i++)
                {
                    if (newPackages_dataGridView.Rows[i].IsNewRow)
                        continue;

                    DataGridViewRow row = dataGridView.Rows[i];
                    if (row.Cells["Select"].Value != null && row.Cells["Select"].Value is bool)
                    {
                        bool isChecked = (bool)row.Cells["Select"].Value;

                        if (isChecked)
                        {
                            packageName = row.Cells[1].Value.ToString();
                            orderID = Login.getCustomerID_Login().ToString() + packageName + DateTime.Now.ToString();
                            price = row.Cells[4].Value.ToString();
                            paymentConfirmation = "Confirmed";
                            customerID = Login.getCustomerID_Login();
                            break;
                        }
                    }
                }

                //MembershipPackage membershipPackage = Program.seekMembershipPackage(packageName);
                MembershipOrder membershipOrder = new MembershipOrder(orderID, price, paymentConfirmation, Program.seekMembershipPackage(packageName),
                    Program.seekCustomer(customerID));

                membershipOrder.InsertNewOrder();

                string fromMail = "firedancernituz@gmail.com";
                string fromPassword = "qjaulfmlualtqixs";
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(fromMail);
                mail.Subject = "אישור תשלום";
                mail.To.Add(email_textBox.Text);
                mail.Body = "<html><body> התשלום בוצע בהצלחה </body></html>";
                mail.IsBodyHtml = true;

                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(fromMail, fromPassword),
                    EnableSsl = true,
                };
                smtpClient.Send(mail);

                this.Hide();
                LoadingPayment loadingPayment = new LoadingPayment();
                loadingPayment.Show();

                SuccessPayment successPayment = new SuccessPayment();

                System.Threading.Tasks.Task.Delay(4000).ContinueWith(t =>
                {
                    this.Invoke(new Action(() => loadingPayment.Hide()));
                    this.Invoke(new Action(() => successPayment.Show()));
                });

            }
            else
            {
                MessageBox.Show("כרטיס אשראי שגוי", "המשך", MessageBoxButtons.OK);
            }
        }


        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage_Administrator homePage_Administrator = new HomePage_Administrator();
            homePage_Administrator.Show();
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
    }
}
