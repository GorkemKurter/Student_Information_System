namespace Student_Information_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pass_forgot = new Label();
            login_button = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            Login_title = new Label();
            ID = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(pass_forgot);
            panel1.Controls.Add(login_button);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Login_title);
            panel1.Controls.Add(ID);
            panel1.Location = new Point(240, 111);
            panel1.Name = "panel1";
            panel1.Size = new Size(492, 282);
            panel1.TabIndex = 0;
            // 
            // pass_forgot
            // 
            pass_forgot.AutoSize = true;
            pass_forgot.Cursor = Cursors.Hand;
            pass_forgot.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            pass_forgot.ForeColor = SystemColors.ControlLight;
            pass_forgot.Location = new Point(57, 221);
            pass_forgot.Name = "pass_forgot";
            pass_forgot.Size = new Size(182, 23);
            pass_forgot.TabIndex = 6;
            pass_forgot.Text = "Forgot your password?";
            pass_forgot.Click += pass_forgot_Click;
            // 
            // login_button
            // 
            login_button.Location = new Point(297, 219);
            login_button.Name = "login_button";
            login_button.Size = new Size(94, 29);
            login_button.TabIndex = 5;
            login_button.Text = "Login";
            login_button.UseVisualStyleBackColor = true;
            login_button.Click += login_button_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = SystemColors.Menu;
            textBox1.Location = new Point(246, 170);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(184, 27);
            textBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(108, 177);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(35, 106);
            label1.Name = "label1";
            label1.Size = new Size(153, 20);
            label1.TabIndex = 2;
            label1.Text = "Student/Lecturer ID:";
            // 
            // Login_title
            // 
            Login_title.AutoSize = true;
            Login_title.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Login_title.ForeColor = SystemColors.ControlLight;
            Login_title.Location = new Point(70, 28);
            Login_title.Name = "Login_title";
            Login_title.Size = new Size(374, 28);
            Login_title.TabIndex = 1;
            Login_title.Text = "Welcome to Student Information System";
            Login_title.Click += label1_Click;
            // 
            // ID
            // 
            ID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ID.BackColor = SystemColors.Menu;
            ID.Location = new Point(246, 103);
            ID.Name = "ID";
            ID.Size = new Size(184, 27);
            ID.TabIndex = 0;
            ID.TextChanged += ID_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(46, 51, 73);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(951, 577);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form1";
            Text = "Student Information System";
            TransparencyKey = Color.White;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox ID;
        private Label Login_title;
        private Label label1;
        private Label pass_forgot;
        private Button login_button;
        private TextBox textBox1;
        private Label label2;
    }
}