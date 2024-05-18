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
    public partial class Exam_Schedulefrm : Form
    {
        private SQLiteConnection _connection;
        private SQLiteDataAdapter _dataAdapter;
        private DataTable _dataTable;


        public Exam_Schedulefrm()
        {
            InitializeComponent();

        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2.Instance.dashboard_visibility(sender, EventArgs.Empty);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Exam_Schedulefrm_Load_1(object sender, EventArgs e)
        {

            string dbPath = @$"{Directory.GetCurrentDirectory()}\exam_schedule.db";


            _connection = new SQLiteConnection($"Data Source={dbPath};Version=3;");
            _connection.Open();


            string query = "SELECT * FROM Exam_Schedule";
            _dataAdapter = new SQLiteDataAdapter(query, _connection);
            _dataTable = new DataTable();
            _dataAdapter.Fill(_dataTable);


            dataGridView1.DataSource = _dataTable;


            _connection.Close();
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
