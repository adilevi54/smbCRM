using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace FireDancersStudio_Group5
{
    class SQL_CON
    {
        SqlConnection conn;

        public SQL_CON()
        {
            conn = new SqlConnection("Data Source=IEMDBS;Initial Catalog=SADM_5;Integrated Security=True");
        }

        public bool execute_non_query(SqlCommand cmd)
        {
            bool suceess = false;
            try
            {
                // open a connection object
                this.conn.Open();
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                //MessageBox.Show(" השאילתה בוצעה בהצלחה", "המשך", MessageBoxButtons.OK);
                suceess = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בביצוע השאילתה", "המשך", MessageBoxButtons.OK);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return suceess;
        }
        public SqlDataReader execute_query(SqlCommand cmd)
        {
            try
            {
                // open a connection object
                conn.Open();
                cmd.Connection = conn;
                SqlDataReader READER = cmd.ExecuteReader();
                return READER;
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בביצוע השאילתה", "המשך", MessageBoxButtons.OK);
                return null;
            }
        }
    }
}