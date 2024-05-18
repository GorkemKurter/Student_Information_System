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
    public partial class Homeworks_frm : Form
    {
        public Homeworks_frm()
        {
            InitializeComponent();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2.Instance.dashboard_visibility(sender, EventArgs.Empty);
        }

        private void Homeworks_frm_Load(object sender, EventArgs e)
        {

            dataGridView1.Columns.Add("lecture", "Lecture");
            dataGridView1.Columns.Add("Date", "Date");
            dataGridView1.Columns.Add("Time", "Time");
            dataGridView1.Columns.Add("Upload", "Homework Upload");

            string connectionString = $@"Data Source={Directory.GetCurrentDirectory()}\homework_schedule.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Ödev takviminden verileri çekme
                string query = "SELECT * FROM Homework_Schedule";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                      
                            dataGridView1.Rows.Add(reader["lecture"], reader["Date"], reader["Time"],"Click to Add");
                        }
                    }
                }

                connection.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Upload"].Index)
            {

                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf"; 
                openFileDialog.FilterIndex = 1; 
                openFileDialog.Multiselect = false; 

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    string filepath = openFileDialog.FileName;
                    MessageBox.Show("Homework uploaded successfully!" + "\n" + "Current Date Time : " + DateTime.Now);
                    
                }
            }
        }
    }
}
