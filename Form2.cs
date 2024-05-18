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
namespace Student_Information_System
{
    public partial class Form2 : Form
    {
        private SQLiteConnection sqlite_conn;
        private SQLiteCommand sqlite_cmd;
        public string paramNumber;
        public static Form2 Instance;
        public string season;
        public Form2()
        {
            InitializeComponent();
            
            Instance = this;
            Exam_schedule.ForeColor = Color.White;
        }
        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exit_panel_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void exam_schedule_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        public void exam_schedule_panel_Click(object sender, EventArgs e)
        {
            this.dashboard_panel.Controls.Clear();
            dashboard_panel.Visible = true;
            dashboard_panel_top.Visible = true;
            Dashboard_title.Text = "Exam Schedule";
            Exam_Schedulefrm exam_Schedulefrm = new Exam_Schedulefrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            exam_Schedulefrm.FormBorderStyle = FormBorderStyle.None;
            this.dashboard_panel.Controls.Add(exam_Schedulefrm);
            exam_Schedulefrm.Show();

            
        }

        public void dashboard_visibility(object sender, EventArgs e)
        {

            dashboard_panel.Visible = false;
            dashboard_panel_top.Visible = false;

        }

        private void syllabus_panel_Click(object sender, EventArgs e)
        {
            this.dashboard_panel.Controls.Clear();
            dashboard_panel.Visible = true;
            dashboard_panel_top.Visible = true;
            Dashboard_title.Text = "Syllabus";

            Syllabus_frm syllabus_Frm = new Syllabus_frm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            syllabus_Frm.FormBorderStyle = FormBorderStyle.None;
            this.dashboard_panel.Controls.Add(syllabus_Frm);
            syllabus_Frm.Show();

        }

        private void homeworks_panel_Click(object sender, EventArgs e)
        {
            this.dashboard_panel.Controls.Clear();
            dashboard_panel.Visible = true;
            dashboard_panel_top.Visible = true;
            Dashboard_title.Text = "Homeworks";

            Homeworks_frm homeworks_Frm = new Homeworks_frm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            homeworks_Frm.FormBorderStyle = FormBorderStyle.None;
            this.dashboard_panel.Controls.Add(homeworks_Frm);
            homeworks_Frm.Show();
        }

        private void grades_panel_Click(object sender, EventArgs e)
        {
            this.dashboard_panel.Controls.Clear();
            dashboard_panel.Visible = true;
            dashboard_panel_top.Visible = true;
            Dashboard_title.Text = "Grades";

            Grades_fr grades_Fr = new Grades_fr() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            grades_Fr.FormBorderStyle = FormBorderStyle.None;
            this.dashboard_panel.Controls.Add(grades_Fr);
            grades_Fr.Show();

        }

        private void panel3_Click(object sender, EventArgs e)
        {
            this.dashboard_panel.Controls.Clear();
            dashboard_panel.Visible = true;
            dashboard_panel_top.Visible = true;
            Dashboard_title.Text = "Absence Information";

            Absence_frm abnsence_frm = new Absence_frm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            abnsence_frm.FormBorderStyle = FormBorderStyle.None;
            this.dashboard_panel.Controls.Add(abnsence_frm);
            abnsence_frm.Show();
        }

        private void dashboard_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Exam_schedule.ForeColor = Color.White;
            paramNumber = Form1.StudentNumber;
            sqlite_conn = new SQLiteConnection(@$"Data Source={Directory.GetCurrentDirectory()}\Students.db;Version=3;");
            sqlite_conn.Open();
            string query = "SELECT * FROM Students where Number=@paramNumber";
            sqlite_cmd = new SQLiteCommand(query, sqlite_conn);
            sqlite_cmd.Parameters.AddWithValue("@paramNumber", paramNumber);
            SQLiteDataReader reader = sqlite_cmd.ExecuteReader();
            if (reader.Read())
            {
                student_name.Text = reader["Name"].ToString() + " " + reader["Surname"].ToString();
                department_info.Text = reader["Class"].ToString();
                reader.Close();
                sqlite_conn.Close();
                DateTime currentDate = DateTime.Now;
                string year = currentDate.Year.ToString();
                string month = currentDate.Month.ToString();
                if (Convert.ToInt32(month) < 10)
                {
                    month = "0" + currentDate.Month.ToString();
                }
                string day = currentDate.Day.ToString();  
                if (currentDate.Month >= 6 && currentDate.Month <= 8) 
                {
                    season = "Summer";
                }
                else if (currentDate.Month >= 12 || currentDate.Month <= 2) 
                {
                    season = "Winter";
                }
                else if (currentDate.Month >= 3 && currentDate.Month <= 5) 
                {
                    season = "Spring";
                }
                else 
                {
                    season = "Fall";
                }

                season_info.Text = season + " " + currentDate.Year;
                date_time.Text = $"{day}.{month}.{year}";
            }
        }

        private void syllabus_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exit_panel_MouseClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
