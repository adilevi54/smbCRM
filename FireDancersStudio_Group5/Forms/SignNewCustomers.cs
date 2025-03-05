using FireDancersStudio_Group5.Classes;
using FireDancersStudio_Group5.Enums;
using FireDancersStudio_Group5.Forms.Finish_Screens;
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

namespace FireDancersStudio_Group5.Forms
{
    public partial class SignNewCustomers : Form
    {
        public SignNewCustomers()
        {
            InitializeComponent();
            Fill_Comboboxes();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            First_Screen first_Screen = new First_Screen();
            first_Screen.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string id = ID_textBox.Text;
            string firstName = firstName_textBox.Text;
            string lastName = lastName_textBox.Text;
            string email = Email_textBox.Text;
            string phoneNumber = phoneNumber_textBox.Text;
            string password = password_textBox.Text;

            if(id.Equals("") || firstName.Equals("") || lastName.Equals("") || email.Equals("") || phoneNumber.Equals("") || password.Equals(""))
            {
                MessageBox.Show("חסרים פרטי הרשמה", "המשך", MessageBoxButtons.OK);
                return;
            }

            GenderEnum gender = (GenderEnum)Enum.Parse(typeof(GenderEnum), Gender_comboBox.Text);
            BranchEnum branch = (BranchEnum)Enum.Parse(typeof(BranchEnum), branch_comboBox.Text);
            CustomerEnum customerType = (CustomerEnum)Enum.Parse(typeof(CustomerEnum), CustomerType_comboBox.Text);
            HealthDeclarationEnum healthDeclaration = (HealthDeclarationEnum)Enum.Parse(typeof(HealthDeclarationEnum), Health_comboBox.Text);
            SourceEnum sourceName = (SourceEnum)Enum.Parse(typeof(SourceEnum), Source_comboBox.Text);

            DateTime birthdate = birthdate_dateTimePicker.Value;

            if (!phoneNumber.Contains("-"))
            {
                SqlCommand c = new SqlCommand();
                c.CommandText = "EXECUTE dbo.InsertCustomer @customerID, @firstName, @lastName, @birthdate, @branch, @sourceName, @email, @phoneNumber, @gender, @healthDeclaration, @password, @customerTypeName";
                c.Parameters.AddWithValue("@customerID", id);
                c.Parameters.AddWithValue("@firstName", firstName);
                c.Parameters.AddWithValue("@lastName", lastName);
                c.Parameters.AddWithValue("@birthdate", birthdate);
                c.Parameters.AddWithValue("@branch", branch.ToString());
                c.Parameters.AddWithValue("@sourceName", sourceName.ToString());
                c.Parameters.AddWithValue("@email", email);
                c.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                c.Parameters.AddWithValue("@gender", gender.ToString());
                c.Parameters.AddWithValue("@healthDeclaration", healthDeclaration.Equals("Yes") ? true : false);
                c.Parameters.AddWithValue("@password", password);
                c.Parameters.AddWithValue("@customerTypeName", customerType.ToString());

                SQL_CON SC = new SQL_CON();
                SC.execute_non_query(c);


                Customer new_c = new Customer(
                    id: id,
                    gender: gender,
                    firstName: firstName,
                    lastName: lastName,
                    birthDate: birthdate,
                    branch: branch,
                    source: sourceName.ToString(),
                    customerType: customerType,
                    email: email,
                    phoneNumber: phoneNumber,
                    isNew: false,
                    attendances: new List<Attendance>(),
                    membershipOrders: null
                );
                Program.Customers.Add(new_c);

                this.Hide();
                SuccessCustomerRegistration successCustomerRegistration = new SuccessCustomerRegistration();
                successCustomerRegistration.Show();
            }
        }

        private void Health_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Fill_Comboboxes()
        {
            branch_comboBox.DataSource = Enum.GetValues(typeof(BranchEnum));
            Source_comboBox.DataSource = Enum.GetValues(typeof(SourceEnum));
            Gender_comboBox.DataSource = Enum.GetValues(typeof(GenderEnum));
            Health_comboBox.DataSource = Enum.GetValues(typeof(HealthDeclarationEnum));
            CustomerType_comboBox.DataSource = Enum.GetValues(typeof(CustomerEnum));
        }

        private void branch_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
