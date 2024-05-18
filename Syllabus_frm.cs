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
using System.Data.Common;
using System.Web;

namespace Student_Information_System
{
    public partial class Syllabus_frm : Form
    {
        public static Syllabus_frm instance;
        public string paramnumber;
        private SQLiteConnection sqlite_conn;
        private SQLiteCommand sqlite_cmd;
        private SQLiteDataAdapter _dataAdapter;
        private DataTable _dataTable;
        public string classparam;
        private SQLiteConnection _connection;
        public Syllabus_frm()
        {
            InitializeComponent();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2.Instance.dashboard_visibility(sender, EventArgs.Empty);
        }

        private void Syllabus_frm_Load(object sender, EventArgs e)
        {
            paramnumber = Form1.StudentNumber;
            sqlite_conn = new SQLiteConnection(@$"Data Source={Directory.GetCurrentDirectory()}\Students.db;Version=3;");
            sqlite_conn.Open();

            string query = "SELECT Class FROM Students where Number=@paramNumber";
            sqlite_cmd = new SQLiteCommand(query, sqlite_conn);
            sqlite_cmd.Parameters.AddWithValue("@paramNumber", paramnumber);
            SQLiteDataReader reader = sqlite_cmd.ExecuteReader();

            if (reader.Read())
            {
                label1.Text = reader["Class"].ToString() + " " + "Syllabus";
                classparam = reader["Class"].ToString();
                reader.Close();
                sqlite_conn.Close();
                if (classparam == "Class A")
                {

                    _connection = new SQLiteConnection(@$"Data Source={Directory.GetCurrentDirectory()}\Syllabus.db;Version=3;");
                    string syllabus_query = "SELECT Monday,Tuesday,Wednesday,Thursday,Friday FROM Syllabus where Class LIKE 'Class_A_Lecture%' ";
                    _dataAdapter = new SQLiteDataAdapter(syllabus_query, _connection);
                    _dataTable = new DataTable();
                    _dataAdapter.Fill(_dataTable);
                    dataGridView1.DataSource = _dataTable;
                    _connection.Close();


                }
                else if (classparam == "Class B")
                {
                    _connection = new SQLiteConnection(@$"Data Source={Directory.GetCurrentDirectory()}\Syllabus.db;Version=3;");
                    string syllabus_query = "SELECT Monday,Tuesday,Wednesday,Thursday,Friday FROM Syllabus where Class LIKE 'Class_B_Lecture%' ";
                    _dataAdapter = new SQLiteDataAdapter(syllabus_query, _connection);
                    _dataTable = new DataTable();
                    _dataAdapter.Fill(_dataTable);
                    dataGridView1.DataSource = _dataTable;
                    _connection.Close();

                }
                else if(classparam == "Class C")
                {
                    _connection = new SQLiteConnection($@"Data Source={Directory.GetCurrentDirectory()}\Syllabus.db;Version=3;");
                    string syllabus_query = "SELECT Monday,Tuesday,Wednesday,Thursday,Friday FROM Syllabus where Class LIKE 'Class_B_Lecture%' ";
                    _dataAdapter = new SQLiteDataAdapter(syllabus_query, _connection);
                    _dataTable = new DataTable();
                    _dataAdapter.Fill(_dataTable);
                    dataGridView1.DataSource = _dataTable;
                    _connection.Close();


                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }



}