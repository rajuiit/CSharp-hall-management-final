namespace Hall_Management_System.Attendance
{
    partial class take_attendance
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.elapsed_time_L = new System.Windows.Forms.Label();
            this.remaining_time_L = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.status_countdown_L = new System.Windows.Forms.Label();
            this.end_countdown_L = new System.Windows.Forms.Label();
            this.start_countdown_L = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.informationAnnexGB = new System.Windows.Forms.GroupBox();
            this.studentDGV = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.presentB = new System.Windows.Forms.Button();
            this.studentIdTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchCriteriaGB = new System.Windows.Forms.GroupBox();
            this.roomSearchRB = new System.Windows.Forms.RadioButton();
            this.registrationSearchRB = new System.Windows.Forms.RadioButton();
            this.anySearchRB = new System.Windows.Forms.RadioButton();
            this.searchB = new System.Windows.Forms.Button();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.rollSearchRB = new System.Windows.Forms.RadioButton();
            this.idSearchRB = new System.Windows.Forms.RadioButton();
            this.nameSearchRB = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.informationAnnexGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDGV)).BeginInit();
            this.panel4.SuspendLayout();
            this.searchCriteriaGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1346, 72);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(418, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(436, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "Attendance Countdown";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.elapsed_time_L);
            this.panel2.Controls.Add(this.remaining_time_L);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.status_countdown_L);
            this.panel2.Controls.Add(this.end_countdown_L);
            this.panel2.Controls.Add(this.start_countdown_L);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1346, 72);
            this.panel2.TabIndex = 5;
            // 
            // elapsed_time_L
            // 
            this.elapsed_time_L.AutoSize = true;
            this.elapsed_time_L.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elapsed_time_L.Location = new System.Drawing.Point(1093, 47);
            this.elapsed_time_L.Name = "elapsed_time_L";
            this.elapsed_time_L.Size = new System.Drawing.Size(45, 19);
            this.elapsed_time_L.TabIndex = 7;
            this.elapsed_time_L.Text = "label5";
            // 
            // remaining_time_L
            // 
            this.remaining_time_L.AutoSize = true;
            this.remaining_time_L.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remaining_time_L.Location = new System.Drawing.Point(1093, 3);
            this.remaining_time_L.Name = "remaining_time_L";
            this.remaining_time_L.Size = new System.Drawing.Size(45, 19);
            this.remaining_time_L.TabIndex = 6;
            this.remaining_time_L.Text = "label5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(904, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 26);
            this.label7.TabIndex = 5;
            this.label7.Text = "Time Elapsed:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(904, -2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 26);
            this.label8.TabIndex = 4;
            this.label8.Text = "Time Remaining: ";
            // 
            // status_countdown_L
            // 
            this.status_countdown_L.AutoSize = true;
            this.status_countdown_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_countdown_L.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.status_countdown_L.Location = new System.Drawing.Point(421, 21);
            this.status_countdown_L.Name = "status_countdown_L";
            this.status_countdown_L.Size = new System.Drawing.Size(342, 26);
            this.status_countdown_L.TabIndex = 1;
            this.status_countdown_L.Text = "Attendance Coundown is not Start";
            // 
            // end_countdown_L
            // 
            this.end_countdown_L.AutoSize = true;
            this.end_countdown_L.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_countdown_L.Location = new System.Drawing.Point(222, 49);
            this.end_countdown_L.Name = "end_countdown_L";
            this.end_countdown_L.Size = new System.Drawing.Size(139, 19);
            this.end_countdown_L.TabIndex = 3;
            this.end_countdown_L.Text = "8/12/2014 11:38 AM";
            // 
            // start_countdown_L
            // 
            this.start_countdown_L.AutoSize = true;
            this.start_countdown_L.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_countdown_L.Location = new System.Drawing.Point(222, 5);
            this.start_countdown_L.Name = "start_countdown_L";
            this.start_countdown_L.Size = new System.Drawing.Size(139, 19);
            this.start_countdown_L.TabIndex = 2;
            this.start_countdown_L.Text = "8/12/2014 11:37 AM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Countdown End At: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Countdown Start At: ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.searchCriteriaGB);
            this.panel3.Location = new System.Drawing.Point(12, 168);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1346, 139);
            this.panel3.TabIndex = 5;
            // 
            // informationAnnexGB
            // 
            this.informationAnnexGB.Controls.Add(this.studentDGV);
            this.informationAnnexGB.Location = new System.Drawing.Point(12, 313);
            this.informationAnnexGB.Name = "informationAnnexGB";
            this.informationAnnexGB.Size = new System.Drawing.Size(1346, 248);
            this.informationAnnexGB.TabIndex = 6;
            this.informationAnnexGB.TabStop = false;
            this.informationAnnexGB.Text = "Information Annex";
            // 
            // studentDGV
            // 
            this.studentDGV.AllowUserToAddRows = false;
            this.studentDGV.AllowUserToDeleteRows = false;
            this.studentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentDGV.Location = new System.Drawing.Point(3, 16);
            this.studentDGV.Name = "studentDGV";
            this.studentDGV.ReadOnly = true;
            this.studentDGV.Size = new System.Drawing.Size(1340, 229);
            this.studentDGV.TabIndex = 0;
            this.studentDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentDGV_CellClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.presentB);
            this.panel4.Controls.Add(this.studentIdTB);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(15, 567);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1346, 87);
            this.panel4.TabIndex = 5;
            // 
            // presentB
            // 
            this.presentB.Location = new System.Drawing.Point(623, 14);
            this.presentB.Name = "presentB";
            this.presentB.Size = new System.Drawing.Size(96, 41);
            this.presentB.TabIndex = 2;
            this.presentB.Text = "PRESENT";
            this.presentB.UseVisualStyleBackColor = true;
            this.presentB.Click += new System.EventHandler(this.presentB_Click);
            // 
            // studentIdTB
            // 
            this.studentIdTB.Enabled = false;
            this.studentIdTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIdTB.Location = new System.Drawing.Point(394, 22);
            this.studentIdTB.Name = "studentIdTB";
            this.studentIdTB.Size = new System.Drawing.Size(198, 26);
            this.studentIdTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Attendance Student ID";
            // 
            // searchCriteriaGB
            // 
            this.searchCriteriaGB.Controls.Add(this.roomSearchRB);
            this.searchCriteriaGB.Controls.Add(this.registrationSearchRB);
            this.searchCriteriaGB.Controls.Add(this.anySearchRB);
            this.searchCriteriaGB.Controls.Add(this.searchB);
            this.searchCriteriaGB.Controls.Add(this.searchTB);
            this.searchCriteriaGB.Controls.Add(this.rollSearchRB);
            this.searchCriteriaGB.Controls.Add(this.idSearchRB);
            this.searchCriteriaGB.Controls.Add(this.nameSearchRB);
            this.searchCriteriaGB.Location = new System.Drawing.Point(389, 14);
            this.searchCriteriaGB.Name = "searchCriteriaGB";
            this.searchCriteriaGB.Size = new System.Drawing.Size(567, 108);
            this.searchCriteriaGB.TabIndex = 10;
            this.searchCriteriaGB.TabStop = false;
            this.searchCriteriaGB.Text = "Search Criteria";
            // 
            // roomSearchRB
            // 
            this.roomSearchRB.AutoSize = true;
            this.roomSearchRB.Location = new System.Drawing.Point(292, 76);
            this.roomSearchRB.Name = "roomSearchRB";
            this.roomSearchRB.Size = new System.Drawing.Size(104, 17);
            this.roomSearchRB.TabIndex = 7;
            this.roomSearchRB.Text = "Search by Room";
            this.roomSearchRB.UseVisualStyleBackColor = true;
            // 
            // registrationSearchRB
            // 
            this.registrationSearchRB.AutoSize = true;
            this.registrationSearchRB.Location = new System.Drawing.Point(154, 76);
            this.registrationSearchRB.Name = "registrationSearchRB";
            this.registrationSearchRB.Size = new System.Drawing.Size(132, 17);
            this.registrationSearchRB.TabIndex = 6;
            this.registrationSearchRB.Text = "Search by Registration";
            this.registrationSearchRB.UseVisualStyleBackColor = true;
            // 
            // anySearchRB
            // 
            this.anySearchRB.AutoSize = true;
            this.anySearchRB.Checked = true;
            this.anySearchRB.Location = new System.Drawing.Point(46, 53);
            this.anySearchRB.Name = "anySearchRB";
            this.anySearchRB.Size = new System.Drawing.Size(103, 17);
            this.anySearchRB.TabIndex = 5;
            this.anySearchRB.TabStop = true;
            this.anySearchRB.Text = "Search Anything";
            this.anySearchRB.UseVisualStyleBackColor = true;
            // 
            // searchB
            // 
            this.searchB.Location = new System.Drawing.Point(422, 19);
            this.searchB.Name = "searchB";
            this.searchB.Size = new System.Drawing.Size(75, 23);
            this.searchB.TabIndex = 4;
            this.searchB.Text = "Search";
            this.searchB.UseVisualStyleBackColor = true;
            this.searchB.Click += new System.EventHandler(this.searchB_Click);
            // 
            // searchTB
            // 
            this.searchTB.Location = new System.Drawing.Point(46, 23);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(350, 20);
            this.searchTB.TabIndex = 3;
            // 
            // rollSearchRB
            // 
            this.rollSearchRB.AutoSize = true;
            this.rollSearchRB.Location = new System.Drawing.Point(46, 76);
            this.rollSearchRB.Name = "rollSearchRB";
            this.rollSearchRB.Size = new System.Drawing.Size(94, 17);
            this.rollSearchRB.TabIndex = 2;
            this.rollSearchRB.Text = "Search by Roll";
            this.rollSearchRB.UseVisualStyleBackColor = true;
            // 
            // idSearchRB
            // 
            this.idSearchRB.AutoSize = true;
            this.idSearchRB.Location = new System.Drawing.Point(154, 53);
            this.idSearchRB.Name = "idSearchRB";
            this.idSearchRB.Size = new System.Drawing.Size(87, 17);
            this.idSearchRB.TabIndex = 1;
            this.idSearchRB.Text = "Search by ID";
            this.idSearchRB.UseVisualStyleBackColor = true;
            // 
            // nameSearchRB
            // 
            this.nameSearchRB.AutoSize = true;
            this.nameSearchRB.Location = new System.Drawing.Point(292, 53);
            this.nameSearchRB.Name = "nameSearchRB";
            this.nameSearchRB.Size = new System.Drawing.Size(102, 17);
            this.nameSearchRB.TabIndex = 0;
            this.nameSearchRB.Text = "Search by name";
            this.nameSearchRB.UseVisualStyleBackColor = true;
            // 
            // take_attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 742);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.informationAnnexGB);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "take_attendance";
            this.Text = "take_attendance";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.take_attendance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.informationAnnexGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentDGV)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.searchCriteriaGB.ResumeLayout(false);
            this.searchCriteriaGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label end_countdown_L;
        private System.Windows.Forms.Label start_countdown_L;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label elapsed_time_L;
        private System.Windows.Forms.Label remaining_time_L;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label status_countdown_L;
        private System.Windows.Forms.GroupBox informationAnnexGB;
        private System.Windows.Forms.DataGridView studentDGV;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox studentIdTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button presentB;
        private System.Windows.Forms.GroupBox searchCriteriaGB;
        private System.Windows.Forms.RadioButton roomSearchRB;
        private System.Windows.Forms.RadioButton registrationSearchRB;
        private System.Windows.Forms.RadioButton anySearchRB;
        private System.Windows.Forms.Button searchB;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.RadioButton rollSearchRB;
        private System.Windows.Forms.RadioButton idSearchRB;
        private System.Windows.Forms.RadioButton nameSearchRB;
    }
}