namespace Student_Information_System
{
    partial class Homeworks_frm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            Exit_button = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Exit_button
            // 
            Exit_button.Location = new Point(12, 12);
            Exit_button.Name = "Exit_button";
            Exit_button.Size = new Size(94, 29);
            Exit_button.TabIndex = 2;
            Exit_button.Text = "<-";
            Exit_button.UseVisualStyleBackColor = true;
            Exit_button.Click += Exit_button_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.ControlLight;
            dataGridView1.Location = new Point(93, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(128, 255, 128);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.Size = new Size(645, 647);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            // 
            // Homeworks_frm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(800, 778);
            Controls.Add(dataGridView1);
            Controls.Add(Exit_button);
            Name = "Homeworks_frm";
            Text = "Homeworks_frm";
            Load += Homeworks_frm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Exit_button;
        private DataGridView dataGridView1;
    }
}