using FireDancersStudio_Group5;
using FireDancersStudio_Group5.Forms;
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

namespace FireDancersStudio_Group5
{
    public partial class Login : Form
    {
        private static string userID;
        private static string password;
        private static string userType;

        public Login()
        {
            InitializeComponent();
            SetPlaceholderText();
            this.KeyPreview = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyEnter);
            this.ID_textBox.Enter += new System.EventHandler(this.ID_textBox_Enter);
            this.ID_textBox.Leave += new System.EventHandler(this.ID_textBox_Leave);
            this.Password_textBox.Enter += new System.EventHandler(this.Password_textBox_Enter);
            this.Password_textBox.Leave += new System.EventHandler(this.Password_textBox_Leave);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void ID_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void resizeControl(Rectangle r, Control c)
        {
            
        }

        private void Login_Load_resize(object sender, EventArgs e)
        {

        }

        //Clean the textboxes
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ID_textBox.Text = string.Empty;
            Password_textBox.Text = string.Empty;
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            userID = ID_textBox.Text;
            password = Password_textBox.Text;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "EXECUTE dbo.GetUserDetails @userID, @Password";

            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@Password", password);

            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(cmd);

            if(rdr == null || !rdr.HasRows)
                MessageBox.Show("לא נמצא משתמש עם פרטים אלה, אנא נסה שנית", "המשך", MessageBoxButtons.OK);
            else
            {
                while (rdr.Read())
                {
                    userID = rdr.GetValue(0).ToString();
                    password = rdr.GetValue(1).ToString();
                    userType = rdr.GetValue(2).ToString();
                }

                if (userType == "Worker")
                {
                    this.Hide();
                    HomePage_Administrator homePage_Administrator = new HomePage_Administrator();
                    homePage_Administrator.Show();
                }
                else
                {
                    this.Hide();
                    HomePage_Customer homePage_customer = new HomePage_Customer();
                    homePage_customer.Show();
                }
            }   
        }

        public static string getCustomerID_Login()
        {
            return userID;
        }

        public static string getUserType_Login()
        {
            return userType;
        }

        //Press the "log-in" key
        private void Login_KeyEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // בודק אם נלחץ כפתור Enter
            {
                pictureBox2_Click(sender, e); // מפעיל את הפונקציה של כפתור ההתחברות
            }
        }















        private void SetPlaceholderText()
        {
            // טקסט מקדים לשדה ה-ID
            if (string.IsNullOrWhiteSpace(ID_textBox.Text))
            {
                ID_textBox.ForeColor = Color.Gray;  // שינוי צבע הטקסט (למראית עין כמו טקסט מקדים)
                ID_textBox.Text = "הכנס שם משתמש"; // טקסט מקדים
            }

            // טקסט מקדים לשדה הסיסמה
            if (string.IsNullOrWhiteSpace(Password_textBox.Text))
            {
                Password_textBox.ForeColor = Color.Gray;  // שינוי צבע הטקסט
                Password_textBox.Text = "הכנס סיסמה"; // טקסט מקדים
            }
        }

        // אירוע שיתרחש כאשר השדה מקבל את הסמן (focus)
        private void TextBox_GotFocus(object sender, EventArgs e)
        {
            TextBox txtBox = sender as TextBox;

            if (txtBox != null && txtBox.ForeColor == Color.Gray)
            {
                txtBox.Text = ""; // מוחק את הטקסט המקדימי
                txtBox.ForeColor = Color.Black; // משנה את צבע הטקסט לצבע רגיל
            }
        }

        // אירוע שיתרחש כאשר השדה מאבד את הסמן (lost focus)
        private void TextBox_LostFocus(object sender, EventArgs e)
        {
            TextBox txtBox = sender as TextBox;

            if (txtBox != null && string.IsNullOrWhiteSpace(txtBox.Text))
            {
                // אם השדה ריק, מחזירים את הטקסט המקדימי
                if (txtBox.Name == "ID_textBox")
                {
                    txtBox.Text = "הכנס שם משתמש";
                }
                else if (txtBox.Name == "Password_textBox")
                {
                    txtBox.Text = "הכנס סיסמה";
                }

                txtBox.ForeColor = Color.Gray; // מחזירים את הצבע לאפור
            }
        }

        private void ID_textBox_Enter(object sender, EventArgs e)
        {
            TextBox_GotFocus(sender, e);
        }

        private void ID_textBox_Leave(object sender, EventArgs e)
        {
            TextBox_LostFocus(sender, e);
        }

        private void Password_textBox_Enter(object sender, EventArgs e)
        {
            TextBox_GotFocus(sender, e);
        }

        private void Password_textBox_Leave(object sender, EventArgs e)
        {
            TextBox_LostFocus(sender, e);
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            First_Screen first_Screen = new First_Screen();
            first_Screen.Show();
        }
    }
}























