namespace Student_Information_System
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            panel3 = new Panel();
            pictureBox6 = new PictureBox();
            Absence_label = new Label();
            exam_schedule_panel = new Panel();
            Exam_schedule = new Label();
            pictureBox2 = new PictureBox();
            syllabus_panel = new Panel();
            Syllabus = new Label();
            pictureBox3 = new PictureBox();
            homeworks_panel = new Panel();
            Homework = new Label();
            pictureBox4 = new PictureBox();
            grades_panel = new Panel();
            Grades = new Label();
            pictureBox5 = new PictureBox();
            exit_panel = new Panel();
            Exit = new Label();
            panel2 = new Panel();
            date_time = new Label();
            department_info = new Label();
            season_info = new Label();
            student_name = new Label();
            pictureBox1 = new PictureBox();
            Dashboards_title = new Label();
            dashboard_panel = new Panel();
            dashboard_panel_top = new Panel();
            Dashboard_title = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            exam_schedule_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            syllabus_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            homeworks_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            grades_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            exit_panel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            dashboard_panel_top.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 51, 73);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(exam_schedule_panel);
            panel1.Controls.Add(syllabus_panel);
            panel1.Controls.Add(homeworks_panel);
            panel1.Controls.Add(grades_panel);
            panel1.Controls.Add(exit_panel);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(Dashboards_title);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(338, 977);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(46, 51, 73);
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(pictureBox6);
            panel3.Controls.Add(Absence_label);
            panel3.Cursor = Cursors.Hand;
            panel3.Location = new Point(3, 782);
            panel3.Name = "panel3";
            panel3.Size = new Size(332, 76);
            panel3.TabIndex = 11;
            panel3.Click += panel3_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(270, 13);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(37, 42);
            pictureBox6.TabIndex = 2;
            pictureBox6.TabStop = false;
            pictureBox6.Click += panel3_Click;
            // 
            // Absence_label
            // 
            Absence_label.AutoSize = true;
            Absence_label.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            Absence_label.ForeColor = SystemColors.ControlLight;
            Absence_label.Location = new Point(21, 20);
            Absence_label.Name = "Absence_label";
            Absence_label.Size = new Size(170, 35);
            Absence_label.TabIndex = 9;
            Absence_label.Text = "Absence Info";
            Absence_label.TextAlign = ContentAlignment.MiddleCenter;
            Absence_label.Click += panel3_Click;
            // 
            // exam_schedule_panel
            // 
            exam_schedule_panel.BackColor = Color.FromArgb(46, 51, 73);
            exam_schedule_panel.BorderStyle = BorderStyle.Fixed3D;
            exam_schedule_panel.Controls.Add(Exam_schedule);
            exam_schedule_panel.Controls.Add(pictureBox2);
            exam_schedule_panel.Cursor = Cursors.Hand;
            exam_schedule_panel.Location = new Point(3, 377);
            exam_schedule_panel.Name = "exam_schedule_panel";
            exam_schedule_panel.Size = new Size(332, 76);
            exam_schedule_panel.TabIndex = 1;
            exam_schedule_panel.Click += exam_schedule_panel_Click;
            exam_schedule_panel.Paint += exam_schedule_panel_Paint;
            // 
            // Exam_schedule
            // 
            Exam_schedule.AutoSize = true;
            Exam_schedule.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            Exam_schedule.ForeColor = SystemColors.ControlLight;
            Exam_schedule.Location = new Point(21, 22);
            Exam_schedule.Name = "Exam_schedule";
            Exam_schedule.Size = new Size(191, 35);
            Exam_schedule.TabIndex = 10;
            Exam_schedule.Text = "Exam Schedule";
            Exam_schedule.TextAlign = ContentAlignment.MiddleCenter;
            Exam_schedule.Click += exam_schedule_panel_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(270, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 42);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += exam_schedule_panel_Click;
            // 
            // syllabus_panel
            // 
            syllabus_panel.BackColor = Color.FromArgb(46, 51, 73);
            syllabus_panel.BorderStyle = BorderStyle.Fixed3D;
            syllabus_panel.Controls.Add(Syllabus);
            syllabus_panel.Controls.Add(pictureBox3);
            syllabus_panel.Cursor = Cursors.Hand;
            syllabus_panel.Location = new Point(3, 471);
            syllabus_panel.Name = "syllabus_panel";
            syllabus_panel.Size = new Size(332, 76);
            syllabus_panel.TabIndex = 11;
            syllabus_panel.Click += syllabus_panel_Click;
            syllabus_panel.Paint += syllabus_panel_Paint;
            // 
            // Syllabus
            // 
            Syllabus.AutoSize = true;
            Syllabus.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            Syllabus.ForeColor = SystemColors.ControlLight;
            Syllabus.Location = new Point(21, 21);
            Syllabus.Name = "Syllabus";
            Syllabus.Size = new Size(110, 35);
            Syllabus.TabIndex = 7;
            Syllabus.Text = "Syllabus";
            Syllabus.TextAlign = ContentAlignment.MiddleCenter;
            Syllabus.Click += syllabus_panel_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(270, 21);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(37, 42);
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            pictureBox3.Click += syllabus_panel_Click;
            // 
            // homeworks_panel
            // 
            homeworks_panel.BackColor = Color.FromArgb(46, 51, 73);
            homeworks_panel.BorderStyle = BorderStyle.Fixed3D;
            homeworks_panel.Controls.Add(Homework);
            homeworks_panel.Controls.Add(pictureBox4);
            homeworks_panel.Cursor = Cursors.Hand;
            homeworks_panel.Location = new Point(3, 584);
            homeworks_panel.Name = "homeworks_panel";
            homeworks_panel.Size = new Size(332, 76);
            homeworks_panel.TabIndex = 2;
            homeworks_panel.Click += homeworks_panel_Click;
            // 
            // Homework
            // 
            Homework.AutoSize = true;
            Homework.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            Homework.ForeColor = SystemColors.ControlLight;
            Homework.Location = new Point(21, 20);
            Homework.Name = "Homework";
            Homework.Size = new Size(156, 35);
            Homework.TabIndex = 8;
            Homework.Text = "Homeworks";
            Homework.TextAlign = ContentAlignment.MiddleCenter;
            Homework.Click += homeworks_panel_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(270, 13);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(37, 42);
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            pictureBox4.Click += homeworks_panel_Click;
            // 
            // grades_panel
            // 
            grades_panel.BackColor = Color.FromArgb(46, 51, 73);
            grades_panel.BorderStyle = BorderStyle.Fixed3D;
            grades_panel.Controls.Add(Grades);
            grades_panel.Controls.Add(pictureBox5);
            grades_panel.Cursor = Cursors.Hand;
            grades_panel.Location = new Point(3, 684);
            grades_panel.Name = "grades_panel";
            grades_panel.Size = new Size(332, 76);
            grades_panel.TabIndex = 10;
            grades_panel.Click += grades_panel_Click;
            // 
            // Grades
            // 
            Grades.AutoSize = true;
            Grades.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            Grades.ForeColor = SystemColors.ControlLight;
            Grades.Location = new Point(21, 20);
            Grades.Name = "Grades";
            Grades.Size = new Size(96, 35);
            Grades.TabIndex = 9;
            Grades.Text = "Grades";
            Grades.TextAlign = ContentAlignment.MiddleCenter;
            Grades.Click += grades_panel_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(270, 13);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(37, 42);
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            pictureBox5.Click += grades_panel_Click;
            // 
            // exit_panel
            // 
            exit_panel.BackColor = Color.FromArgb(46, 51, 73);
            exit_panel.BorderStyle = BorderStyle.Fixed3D;
            exit_panel.Controls.Add(Exit);
            exit_panel.Cursor = Cursors.Hand;
            exit_panel.Location = new Point(3, 875);
            exit_panel.Name = "exit_panel";
            exit_panel.Size = new Size(332, 76);
            exit_panel.TabIndex = 3;
            exit_panel.Click += exit_panel_MouseClick;
            exit_panel.Paint += panel7_Paint;
            // 
            // Exit
            // 
            Exit.AutoSize = true;
            Exit.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            Exit.ForeColor = SystemColors.ControlLight;
            Exit.Location = new Point(121, 13);
            Exit.Name = "Exit";
            Exit.Size = new Size(80, 46);
            Exit.TabIndex = 11;
            Exit.Text = "Exit";
            Exit.Click += exit_panel_MouseClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(date_time);
            panel2.Controls.Add(department_info);
            panel2.Controls.Add(season_info);
            panel2.Controls.Add(student_name);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(335, 349);
            panel2.TabIndex = 3;
            // 
            // date_time
            // 
            date_time.AutoSize = true;
            date_time.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            date_time.ForeColor = SystemColors.ControlLight;
            date_time.Location = new Point(105, 321);
            date_time.Name = "date_time";
            date_time.Size = new Size(110, 28);
            date_time.TabIndex = 7;
            date_time.Text = "Date Time";
            // 
            // department_info
            // 
            department_info.AutoSize = true;
            department_info.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            department_info.ForeColor = SystemColors.ControlLight;
            department_info.Location = new Point(126, 249);
            department_info.Name = "department_info";
            department_info.Size = new Size(59, 28);
            department_info.TabIndex = 6;
            department_info.Text = "Class";
            // 
            // season_info
            // 
            season_info.AutoSize = true;
            season_info.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            season_info.ForeColor = SystemColors.ControlLight;
            season_info.Location = new Point(104, 182);
            season_info.Name = "season_info";
            season_info.Size = new Size(78, 28);
            season_info.TabIndex = 4;
            season_info.Text = "Season";
            // 
            // student_name
            // 
            student_name.AutoSize = true;
            student_name.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            student_name.ForeColor = SystemColors.ControlLight;
            student_name.Location = new Point(104, 131);
            student_name.Name = "student_name";
            student_name.Size = new Size(148, 28);
            student_name.TabIndex = 3;
            student_name.Text = "Student Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-4, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(342, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Dashboards_title
            // 
            Dashboards_title.AutoSize = true;
            Dashboards_title.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Dashboards_title.ForeColor = SystemColors.ControlLight;
            Dashboards_title.Location = new Point(0, 0);
            Dashboards_title.Name = "Dashboards_title";
            Dashboards_title.Size = new Size(0, 28);
            Dashboards_title.TabIndex = 2;
            // 
            // dashboard_panel
            // 
            dashboard_panel.BackColor = Color.FromArgb(46, 51, 73);
            dashboard_panel.Dock = DockStyle.Bottom;
            dashboard_panel.Location = new Point(338, 120);
            dashboard_panel.Name = "dashboard_panel";
            dashboard_panel.Size = new Size(992, 857);
            dashboard_panel.TabIndex = 1;
            dashboard_panel.Visible = false;
            dashboard_panel.Paint += dashboard_panel_Paint;
            // 
            // dashboard_panel_top
            // 
            dashboard_panel_top.Controls.Add(Dashboard_title);
            dashboard_panel_top.Dock = DockStyle.Top;
            dashboard_panel_top.Location = new Point(338, 0);
            dashboard_panel_top.Name = "dashboard_panel_top";
            dashboard_panel_top.Size = new Size(992, 125);
            dashboard_panel_top.TabIndex = 2;
            dashboard_panel_top.Visible = false;
            // 
            // Dashboard_title
            // 
            Dashboard_title.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Dashboard_title.AutoSize = true;
            Dashboard_title.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Dashboard_title.ForeColor = SystemColors.Control;
            Dashboard_title.Location = new Point(438, 46);
            Dashboard_title.Name = "Dashboard_title";
            Dashboard_title.Size = new Size(79, 31);
            Dashboard_title.TabIndex = 0;
            Dashboard_title.Text = "label1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1330, 977);
            Controls.Add(dashboard_panel_top);
            Controls.Add(dashboard_panel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form2";
            Text = "Student Information System";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            exam_schedule_panel.ResumeLayout(false);
            exam_schedule_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            syllabus_panel.ResumeLayout(false);
            syllabus_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            homeworks_panel.ResumeLayout(false);
            homeworks_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            grades_panel.ResumeLayout(false);
            grades_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            exit_panel.ResumeLayout(false);
            exit_panel.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            dashboard_panel_top.ResumeLayout(false);
            dashboard_panel_top.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label Dashboards_title;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label department_info;
        private Label season_info;
        private Label student_name;
        private Label Exam_schedule;
        private Label Grades;
        private Label Homework;
        private Label Exit;
        private Label Syllabus;
        private Label date_time;
        private Panel exam_schedule_panel;
        private Panel exit_panel;
        private Panel grades_panel;
        private PictureBox pictureBox5;
        private Panel homeworks_panel;
        private PictureBox pictureBox4;
        private Panel syllabus_panel;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Panel dashboard_panel;
        private Panel dashboard_panel_top;
        private Label Dashboard_title;
        private Panel panel3;
        private Label Absence_label;
        private PictureBox pictureBox6;
    }
}