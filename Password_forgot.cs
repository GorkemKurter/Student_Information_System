using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Windows;

namespace Student_Information_System
{
    public partial class Password_forgot : Form
    {
        private SQLiteConnection sqlite_conn;
        private SQLiteCommand sqlite_cmd;
        private SQLiteConnection sqlite_conn_auth;
        private SQLiteCommand sqlite_cmd_auth;
        public string paramName;
        public string paramSurname;
        public string paramnewPassword;
        public string paramStudentID;
        public Password_forgot()
        {
            InitializeComponent();
        }

        private void Password_forgot_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            paramName = textBox1.Text.ToUpper();
            paramSurname = textBox2.Text.ToUpper();
            paramnewPassword = textBox3.Text.ToUpper();

            sqlite_conn = new SQLiteConnection($@"Data Source={Directory.GetCurrentDirectory()}\Students.db;Version=3;");
            sqlite_conn.Open();
            string query = "SELECT Name,Surname,Number FROM Students where Name=@paramName AND Surname=@paramSurname";
            sqlite_cmd = new SQLiteCommand(query, sqlite_conn);
            sqlite_cmd.Parameters.AddWithValue("@paramName", paramName);
            sqlite_cmd.Parameters.AddWithValue("@paramSurname", paramSurname);
            SQLiteDataReader reader = sqlite_cmd.ExecuteReader();
            if (reader.Read())
            {

                paramStudentID = reader["Number"].ToString();
                sqlite_conn_auth = new SQLiteConnection($@"Data Source={Directory.GetCurrentDirectory()}\Authorization.db;Version=3;");
                sqlite_conn_auth.Open();
                string update_query = "UPDATE Authorization SET Password = @newPassword WHERE Number = @paramStudentID";
                sqlite_cmd_auth = new SQLiteCommand(update_query, sqlite_conn_auth);
                sqlite_cmd_auth.Parameters.AddWithValue("@newPassword", paramnewPassword);
                sqlite_cmd_auth.Parameters.AddWithValue("@paramStudentID", paramStudentID);
                sqlite_cmd_auth.ExecuteNonQuery();
                System.Windows.MessageBox.Show("Password changed successfuly!");
                reader.Close();
                sqlite_conn.Close();
                sqlite_conn_auth.Close();
                this.Close();

            }
            else
            {
                System.Windows.MessageBox.Show("Invalid Name or Surname. Please try again!");

            }
        }
    }
}
