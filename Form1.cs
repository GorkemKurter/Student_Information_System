using System.Data.SQLite;
using System.IO;
namespace Student_Information_System
{

    public partial class Form1 : Form
    {
        public static string StudentNumber = string.Empty;
        private SQLiteConnection sqlite_conn;
        private SQLiteCommand sqlite_cmd;
        public string paramNumber;
        public string paramPass;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {

            paramNumber = ID.Text;
            paramPass = textBox1.Text;
            sqlite_conn = new SQLiteConnection($@"Data Source={Directory.GetCurrentDirectory()}\Authorization.db;Version=3;");
            sqlite_conn.Open();
            string query = "SELECT * FROM Authorization where Number=@paramNumber AND Password=@paramPass";
            sqlite_cmd = new SQLiteCommand(query, sqlite_conn);
            sqlite_cmd.Parameters.AddWithValue("@paramNumber", paramNumber);
            sqlite_cmd.Parameters.AddWithValue("@paramPass", paramPass);
            SQLiteDataReader reader = sqlite_cmd.ExecuteReader();
            if (reader.Read())
            {
                StudentNumber = paramNumber;
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
                form2.FormClosed += (s, args) => this.Close();
                reader.Close();
                sqlite_conn.Close();

            }
            else
            {
                MessageBox.Show("Wrong Student ID or Password!\nPlease try again.");
            }

        }

        private void ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void pass_forgot_Click(object sender, EventArgs e)
        {
            Password_forgot formpass = new Password_forgot();
            formpass.Show();
     
        }
    }
}



