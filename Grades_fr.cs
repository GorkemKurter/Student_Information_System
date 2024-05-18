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
using System.Security.Cryptography.X509Certificates;
using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System.IO;

namespace Student_Information_System
{
    public partial class Grades_fr : Form
    {
        private SQLiteConnection sqlite_conn_Math;
        private SQLiteConnection sqlite_conn_Physics;
        private SQLiteConnection sqlite_conn_Chemistry;
        private SQLiteConnection sqlite_conn_Biology;
        private SQLiteConnection sqlite_conn_History;
        private SQLiteConnection sqlite_conn_Literature;
        private SQLiteConnection sqlite_conn_Turkish;
        private SQLiteConnection sqlite_conn_English;
        private SQLiteConnection sqlite_conn_Geography;
        private SQLiteConnection sqlite_conn_Religion;
        private SQLiteConnection sqlite_conn_Geometry;


        private SQLiteCommand sqlite_cmd;
        private SQLiteCommand sqlite_cmd_Physics;
        private SQLiteCommand sqlite_cmd_Chemistry;
        private SQLiteCommand sqlite_cmd_Biology;
        private SQLiteCommand sqlite_cmd_History;
        private SQLiteCommand sqlite_cmd_Literature;
        private SQLiteCommand sqlite_cmd_Turkish;
        private SQLiteCommand sqlite_cmd_English;
        private SQLiteCommand sqlite_cmd_Geography;
        private SQLiteCommand sqlite_cmd_Religion;
        private SQLiteCommand sqlite_cmd_Geometry;

        public string paramNumber;
        public Grades_fr()
        {
            InitializeComponent();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Form2.Instance.dashboard_visibility(sender, EventArgs.Empty);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Grades_fr_Load(object sender, EventArgs e)
        {
            paramNumber = Form1.StudentNumber;

            // Calculus Grades Block
            string math_db_path = $@"{Directory.GetCurrentDirectory()}\Calculus_grades.db";
            sqlite_conn_Math = new SQLiteConnection($"Data Source={math_db_path};Version=3;");
            sqlite_conn_Math.Open();
            sqlite_cmd = new SQLiteCommand("SELECT * FROM Calculus WHERE Student_Number = @paramNumber", sqlite_conn_Math);
            sqlite_cmd.Parameters.AddWithValue("@paramNumber", paramNumber);
            SQLiteDataReader math_reader = sqlite_cmd.ExecuteReader();
            if (math_reader.Read())
            {
                label53.Text = math_reader["Midterm"].ToString();
                label54.Text = math_reader["Final"].ToString();
                label55.Text = math_reader["H.W"].ToString();
                math_reader.Close();
                sqlite_conn_Math.Close();
            }
            // Calculus Grades END

            // Physics Grades Block
            string physics_db_path = $@"{Directory.GetCurrentDirectory()}\Physics_grades.db";
            sqlite_conn_Physics = new SQLiteConnection($"Data Source={physics_db_path};Version=3;");
            sqlite_conn_Physics.Open();
            sqlite_cmd_Physics = new SQLiteCommand("SELECT * FROM Physics_2023 WHERE Student_Number = @paramNumber", sqlite_conn_Physics);
            sqlite_cmd_Physics.Parameters.AddWithValue("@paramNumber", paramNumber);
            SQLiteDataReader physics_reader = sqlite_cmd_Physics.ExecuteReader();
            if (physics_reader.Read())
            {
                label63.Text = physics_reader["Midterm"].ToString();
                label62.Text = physics_reader["Final"].ToString();
                label61.Text = physics_reader["H.W"].ToString();
                physics_reader.Close();
                sqlite_conn_Physics.Close();
            }
            // Physics Grades END


            // Chemistry Grades Block
            string chemistry_db_path = $@"{Directory.GetCurrentDirectory()}\Chemistry_grades.db";
            sqlite_conn_Chemistry = new SQLiteConnection($"Data Source={chemistry_db_path};Version=3;");
            sqlite_conn_Chemistry.Open();
            sqlite_cmd_Chemistry = new SQLiteCommand("SELECT * FROM Chemistry_2023 WHERE Student_Number = @paramNumber", sqlite_conn_Chemistry);
            sqlite_cmd_Chemistry.Parameters.AddWithValue("@paramNumber", paramNumber);
            SQLiteDataReader chem_reader = sqlite_cmd_Chemistry.ExecuteReader();
            if (chem_reader.Read())
            {
                label67.Text = chem_reader["Midterm"].ToString();
                label66.Text = chem_reader["Final"].ToString();
                label65.Text = chem_reader["H.W"].ToString();
                chem_reader.Close();
                sqlite_conn_Chemistry.Close();
            }
            // Chemistry Grades END

            // Biology Grades Block
            string biology_db_path = $@"{Directory.GetCurrentDirectory()}\Biology_grades.db";
            sqlite_conn_Biology = new SQLiteConnection($"Data Source={biology_db_path};Version=3;");
            sqlite_conn_Biology.Open();
            sqlite_cmd_Biology = new SQLiteCommand("SELECT * FROM Biology_2023 WHERE Student_Number = @paramNumber", sqlite_conn_Biology);
            sqlite_cmd_Biology.Parameters.AddWithValue("@paramNumber", paramNumber);
            SQLiteDataReader bio_reader = sqlite_cmd_Biology.ExecuteReader();
            if (bio_reader.Read())
            {
                label71.Text = bio_reader["Midterm"].ToString();
                label70.Text = bio_reader["Final"].ToString();
                label69.Text = bio_reader["H.W"].ToString();
                bio_reader.Close();
                sqlite_conn_Biology.Close();
            }
            // Biology Grades END

            // History Grades Block
            string history_db_path = $@"{Directory.GetCurrentDirectory()}\History_grades.db";
            sqlite_conn_History = new SQLiteConnection($"Data Source={history_db_path};Version=3;");
            sqlite_conn_History.Open();
            sqlite_cmd_History = new SQLiteCommand("SELECT * FROM History_2023 WHERE Student_Number = @paramNumber", sqlite_conn_History);
            sqlite_cmd_History.Parameters.AddWithValue("@paramNumber", paramNumber);
            SQLiteDataReader history_reader = sqlite_cmd_History.ExecuteReader();
            if (history_reader.Read())
            {
                label87.Text = history_reader["Midterm"].ToString();
                label86.Text = history_reader["Final"].ToString();
                label85.Text = history_reader["H.W"].ToString();
                history_reader.Close();
                sqlite_conn_History.Close();
            }
            // History Grades END

            // Literature Grades Block
            string literature_db_path = $@"{Directory.GetCurrentDirectory()}\Literature_grades.db";
            sqlite_conn_Literature = new SQLiteConnection($"Data Source={literature_db_path};Version=3;");
            sqlite_conn_Literature.Open();
            sqlite_cmd_Literature = new SQLiteCommand("SELECT * FROM Literature_2023 WHERE Student_Number = @paramNumber", sqlite_conn_Literature);
            sqlite_cmd_Literature.Parameters.AddWithValue("@paramNumber", paramNumber);
            SQLiteDataReader lit_reader = sqlite_cmd_Literature.ExecuteReader();
            if (lit_reader.Read())
            {
                label75.Text = lit_reader["Midterm"].ToString();
                label74.Text = lit_reader["Final"].ToString();
                label73.Text = lit_reader["H.W"].ToString();
                lit_reader.Close();
                sqlite_conn_Literature.Close();
            }
            // Literature Grades END

            // Turkish Grades Block
            string turkish_db_path = $@"{Directory.GetCurrentDirectory()}\Turkish_grades.db";
            sqlite_conn_Turkish = new SQLiteConnection($"Data Source={turkish_db_path};Version=3;");
            sqlite_conn_Turkish.Open();
            sqlite_cmd_Turkish = new SQLiteCommand("SELECT * FROM Turkish_2023 WHERE Student_Number = @paramNumber", sqlite_conn_Turkish);
            sqlite_cmd_Turkish.Parameters.AddWithValue("@paramNumber", paramNumber);
            SQLiteDataReader turkish_reader = sqlite_cmd_Turkish.ExecuteReader();
            if (turkish_reader.Read())
            {
                label79.Text = turkish_reader["Midterm"].ToString();
                label78.Text = turkish_reader["Final"].ToString();
                label77.Text = turkish_reader["H.W"].ToString();
                turkish_reader.Close();
                sqlite_conn_Turkish.Close();
            }
            // Turkish Grades END

            // English Grades Block
            string english_db_path = $@"{Directory.GetCurrentDirectory()}\English_grades.db";
            sqlite_conn_English = new SQLiteConnection($"Data Source={english_db_path};Version=3;");
            sqlite_conn_English.Open();
            sqlite_cmd_English = new SQLiteCommand("SELECT * FROM English_2023 WHERE Student_Number = @paramNumber", sqlite_conn_English);
            sqlite_cmd_English.Parameters.AddWithValue("@paramNumber", paramNumber);
            SQLiteDataReader english_reader = sqlite_cmd_English.ExecuteReader();
            if (english_reader.Read())
            {
                label83.Text = english_reader["Midterm"].ToString();
                label82.Text = english_reader["Final"].ToString();
                label81.Text = english_reader["H.W"].ToString();
                english_reader.Close();
                sqlite_conn_English.Close();
            }
            // English Grades END

            // Geography Grades Block
            string geography_db_path = $@"{Directory.GetCurrentDirectory()}\Geography_grades.db";
            sqlite_conn_Geography = new SQLiteConnection($"Data Source={geography_db_path};Version=3;");
            sqlite_conn_Geography.Open();
            sqlite_cmd_Geography = new SQLiteCommand("SELECT * FROM Geography_2023 WHERE Student_Number = @paramNumber", sqlite_conn_Geography);
            sqlite_cmd_Geography.Parameters.AddWithValue("@paramNumber", paramNumber);
            SQLiteDataReader geo_reader = sqlite_cmd_Geography.ExecuteReader();
            if (geo_reader.Read())
            {
                label99.Text = geo_reader["Midterm"].ToString();
                label98.Text = geo_reader["Final"].ToString();
                label97.Text = geo_reader["H.W"].ToString();
                geo_reader.Close();
                sqlite_conn_Geography.Close();
            }
            // Geography Grades END

            // Religion Grades Block
            string religion_db_path = $@"{Directory.GetCurrentDirectory()}\Religion_grades.db";
            sqlite_conn_Religion = new SQLiteConnection($"Data Source={religion_db_path};Version=3;");
            sqlite_conn_Religion.Open();
            sqlite_cmd_Religion = new SQLiteCommand("SELECT * FROM Religion_2023 WHERE Student_Number = @paramNumber", sqlite_conn_Religion);
            sqlite_cmd_Religion.Parameters.AddWithValue("@paramNumber", paramNumber);
            SQLiteDataReader religion_reader = sqlite_cmd_Religion.ExecuteReader();
            if (religion_reader.Read())
            {
                label91.Text = religion_reader["Midterm"].ToString();
                label90.Text = religion_reader["Final"].ToString();
                label89.Text = religion_reader["H.W"].ToString();
                religion_reader.Close();
                sqlite_conn_Religion.Close();
            }
            // Religion Grades END

            // Geometry Grades Block
            string geometry_db_path = $@"{Directory.GetCurrentDirectory()}\Geometry_grades.db";
            sqlite_conn_Geometry = new SQLiteConnection($"Data Source={geometry_db_path};Version=3;");
            sqlite_conn_Geometry.Open();
            sqlite_cmd_Geometry = new SQLiteCommand("SELECT * FROM Geometry_2023 WHERE Student_Number = @paramNumber", sqlite_conn_Geometry);
            sqlite_cmd_Geometry.Parameters.AddWithValue("@paramNumber", paramNumber);
            SQLiteDataReader geometry_reader = sqlite_cmd_Geometry.ExecuteReader();
            if (geometry_reader.Read())
            {
                label95.Text = geometry_reader["Midterm"].ToString();
                label94.Text = geometry_reader["Final"].ToString();
                label93.Text = geometry_reader["H.W"].ToString();
                geometry_reader.Close();
                sqlite_conn_Geometry.Close();
            }
            // Geometry Grades END

        }
    }
}
