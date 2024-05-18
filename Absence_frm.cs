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
using System.IO;

namespace Student_Information_System
{
    public partial class Absence_frm : Form
    {
        private SQLiteConnection sqlite_conn_att;
        private SQLiteCommand sqlite_cmd;

        public static Absence_frm instance;
        public Absence_frm()
        {
            InitializeComponent();
            instance = this;
        }

        public void form_closer(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Exit_button_Click(object sender, EventArgs e)
        {
            Form2.Instance.dashboard_visibility(sender, EventArgs.Empty);
            this.Close();
        }

        private void Absence_frm_Load(object sender, EventArgs e)
        {

            string paramNumber = Form1.StudentNumber;
            int totalAbsences = 0;

            string db_path = $@"{Directory.GetCurrentDirectory()}\Attendence.db";
            sqlite_conn_att = new SQLiteConnection($"Data Source={db_path};Version=3;");
            sqlite_conn_att.Open();
            sqlite_cmd = new SQLiteCommand("SELECT * FROM Attendence", sqlite_conn_att);
            SQLiteDataReader reader = sqlite_cmd.ExecuteReader();
            System.Data.DataTable dataTable = new System.Data.DataTable();
            dataTable.Columns.Add("Date");
            while (reader.Read())
            {
                string numbersText = reader.GetString(0);
                string date = reader.GetString(1);
                string[] numbersArray = numbersText.Replace("(", "").Replace(")", "").Split(',');
                foreach (string number in numbersArray)
                {
                    if (number.Trim() == paramNumber)
                    {
                        totalAbsences++;
                        dataTable.Rows.Add(date);
                        break;
                    }
                }

            }
            reader.Close();
            sqlite_conn_att.Close();
            label2.Text = totalAbsences.ToString() + "/" + "20";
            dataGridView1.DataSource = dataTable;
            dataGridView1.AutoResizeColumns();


        }
    }
}
