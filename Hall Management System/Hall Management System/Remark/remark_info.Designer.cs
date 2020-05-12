namespace Hall_Management_System.Remark
{
    partial class remark_info
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
            this.inputAnnexGB = new System.Windows.Forms.GroupBox();
            this.searchCriteriaGB = new System.Windows.Forms.GroupBox();
            this.roomSearchRB = new System.Windows.Forms.RadioButton();
            this.registrationSearchRB = new System.Windows.Forms.RadioButton();
            this.anySearchRB = new System.Windows.Forms.RadioButton();
            this.searchB = new System.Windows.Forms.Button();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.rollSearchRB = new System.Windows.Forms.RadioButton();
            this.idSearchRB = new System.Windows.Forms.RadioButton();
            this.nameSearchRB = new System.Windows.Forms.RadioButton();
            this.searchRemarkToDeleteRB = new System.Windows.Forms.RadioButton();
            this.addRemarkRB = new System.Windows.Forms.RadioButton();
            this.searchRemarkToUpdateRB = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.studentDGV = new System.Windows.Forms.DataGridView();
            this.updateRemarkB = new System.Windows.Forms.Button();
            this.addRemarkB = new System.Windows.Forms.Button();
            this.deleteRemarkB = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cancelB = new System.Windows.Forms.Button();
            this.informationAnnexGB = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.remarkDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.remarkIDL = new System.Windows.Forms.Label();
            this.remarkTB = new System.Windows.Forms.TextBox();
            this.authorTB = new System.Windows.Forms.TextBox();
            this.hall_std_IDL = new System.Windows.Forms.Label();
            this.inputAnnexGB.SuspendLayout();
            this.searchCriteriaGB.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDGV)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.informationAnnexGB.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.remarkDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // inputAnnexGB
            // 
            this.inputAnnexGB.Controls.Add(this.searchCriteriaGB);
            this.inputAnnexGB.Controls.Add(this.searchRemarkToDeleteRB);
            this.inputAnnexGB.Controls.Add(this.addRemarkRB);
            this.inputAnnexGB.Controls.Add(this.searchRemarkToUpdateRB);
            this.inputAnnexGB.Location = new System.Drawing.Point(12, 12);
            this.inputAnnexGB.Name = "inputAnnexGB";
            this.inputAnnexGB.Size = new System.Drawing.Size(1292, 125);
            this.inputAnnexGB.TabIndex = 4;
            this.inputAnnexGB.TabStop = false;
            this.inputAnnexGB.Text = "Input Annex";
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
            this.searchCriteriaGB.Location = new System.Drawing.Point(350, 11);
            this.searchCriteriaGB.Name = "searchCriteriaGB";
            this.searchCriteriaGB.Size = new System.Drawing.Size(828, 108);
            this.searchCriteriaGB.TabIndex = 9;
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
            // searchRemarkToDeleteRB
            // 
            this.searchRemarkToDeleteRB.AutoSize = true;
            this.searchRemarkToDeleteRB.Location = new System.Drawing.Point(74, 65);
            this.searchRemarkToDeleteRB.Name = "searchRemarkToDeleteRB";
            this.searchRemarkToDeleteRB.Size = new System.Drawing.Size(145, 17);
            this.searchRemarkToDeleteRB.TabIndex = 3;
            this.searchRemarkToDeleteRB.Text = "Search Remark to Delete";
            this.searchRemarkToDeleteRB.UseVisualStyleBackColor = true;
            this.searchRemarkToDeleteRB.CheckedChanged += new System.EventHandler(this.searchRemarkToDeleteRB_CheckedChanged);
            // 
            // addRemarkRB
            // 
            this.addRemarkRB.AutoSize = true;
            this.addRemarkRB.Checked = true;
            this.addRemarkRB.Location = new System.Drawing.Point(74, 19);
            this.addRemarkRB.Name = "addRemarkRB";
            this.addRemarkRB.Size = new System.Drawing.Size(122, 17);
            this.addRemarkRB.TabIndex = 1;
            this.addRemarkRB.TabStop = true;
            this.addRemarkRB.Text = "I want to add remark";
            this.addRemarkRB.UseVisualStyleBackColor = true;
            this.addRemarkRB.CheckedChanged += new System.EventHandler(this.addRemarkRB_CheckedChanged);
            // 
            // searchRemarkToUpdateRB
            // 
            this.searchRemarkToUpdateRB.AutoSize = true;
            this.searchRemarkToUpdateRB.Location = new System.Drawing.Point(74, 42);
            this.searchRemarkToUpdateRB.Name = "searchRemarkToUpdateRB";
            this.searchRemarkToUpdateRB.Size = new System.Drawing.Size(149, 17);
            this.searchRemarkToUpdateRB.TabIndex = 0;
            this.searchRemarkToUpdateRB.Text = "Search Remark to Update";
            this.searchRemarkToUpdateRB.UseVisualStyleBackColor = true;
            this.searchRemarkToUpdateRB.CheckedChanged += new System.EventHandler(this.searchRemarkToUpdateRB_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.studentDGV);
            this.panel1.Location = new System.Drawing.Point(12, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1292, 127);
            this.panel1.TabIndex = 6;
            // 
            // studentDGV
            // 
            this.studentDGV.AllowUserToAddRows = false;
            this.studentDGV.AllowUserToDeleteRows = false;
            this.studentDGV.AllowUserToOrderColumns = true;
            this.studentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentDGV.Location = new System.Drawing.Point(0, 0);
            this.studentDGV.MultiSelect = false;
            this.studentDGV.Name = "studentDGV";
            this.studentDGV.ReadOnly = true;
            this.studentDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentDGV.Size = new System.Drawing.Size(1290, 125);
            this.studentDGV.TabIndex = 0;
            this.studentDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentDGV_CellContentClick);
            this.studentDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentDGV_CellContentClick);
            // 
            // updateRemarkB
            // 
            this.updateRemarkB.Location = new System.Drawing.Point(651, 19);
            this.updateRemarkB.Name = "updateRemarkB";
            this.updateRemarkB.Size = new System.Drawing.Size(75, 23);
            this.updateRemarkB.TabIndex = 6;
            this.updateRemarkB.Text = "Update";
            this.updateRemarkB.UseVisualStyleBackColor = true;
            this.updateRemarkB.Click += new System.EventHandler(this.updateStudentB_Click);
            // 
            // addRemarkB
            // 
            this.addRemarkB.Location = new System.Drawing.Point(570, 19);
            this.addRemarkB.Name = "addRemarkB";
            this.addRemarkB.Size = new System.Drawing.Size(75, 23);
            this.addRemarkB.TabIndex = 7;
            this.addRemarkB.Text = "Add";
            this.addRemarkB.UseVisualStyleBackColor = true;
            this.addRemarkB.Click += new System.EventHandler(this.addStudentB_Click);
            // 
            // deleteRemarkB
            // 
            this.deleteRemarkB.Location = new System.Drawing.Point(743, 19);
            this.deleteRemarkB.Name = "deleteRemarkB";
            this.deleteRemarkB.Size = new System.Drawing.Size(75, 23);
            this.deleteRemarkB.TabIndex = 5;
            this.deleteRemarkB.Text = "Delete";
            this.deleteRemarkB.UseVisualStyleBackColor = true;
            this.deleteRemarkB.Click += new System.EventHandler(this.deleteStudentB_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.addRemarkB);
            this.groupBox7.Controls.Add(this.updateRemarkB);
            this.groupBox7.Controls.Add(this.deleteRemarkB);
            this.groupBox7.Controls.Add(this.cancelB);
            this.groupBox7.Location = new System.Drawing.Point(18, 689);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1286, 56);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Action";
            // 
            // cancelB
            // 
            this.cancelB.Location = new System.Drawing.Point(824, 19);
            this.cancelB.Name = "cancelB";
            this.cancelB.Size = new System.Drawing.Size(75, 23);
            this.cancelB.TabIndex = 4;
            this.cancelB.Text = "Cancel";
            this.cancelB.UseVisualStyleBackColor = true;
            // 
            // informationAnnexGB
            // 
            this.informationAnnexGB.Controls.Add(this.hall_std_IDL);
            this.informationAnnexGB.Controls.Add(this.authorTB);
            this.informationAnnexGB.Controls.Add(this.remarkTB);
            this.informationAnnexGB.Controls.Add(this.remarkIDL);
            this.informationAnnexGB.Controls.Add(this.label4);
            this.informationAnnexGB.Controls.Add(this.label3);
            this.informationAnnexGB.Controls.Add(this.label2);
            this.informationAnnexGB.Controls.Add(this.label1);
            this.informationAnnexGB.Location = new System.Drawing.Point(12, 422);
            this.informationAnnexGB.Name = "informationAnnexGB";
            this.informationAnnexGB.Size = new System.Drawing.Size(1292, 261);
            this.informationAnnexGB.TabIndex = 5;
            this.informationAnnexGB.TabStop = false;
            this.informationAnnexGB.Text = "Information Annex";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.remarkDGV);
            this.panel2.Location = new System.Drawing.Point(12, 289);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1292, 127);
            this.panel2.TabIndex = 7;
            // 
            // remarkDGV
            // 
            this.remarkDGV.AllowUserToAddRows = false;
            this.remarkDGV.AllowUserToDeleteRows = false;
            this.remarkDGV.AllowUserToOrderColumns = true;
            this.remarkDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.remarkDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remarkDGV.Location = new System.Drawing.Point(0, 0);
            this.remarkDGV.MultiSelect = false;
            this.remarkDGV.Name = "remarkDGV";
            this.remarkDGV.ReadOnly = true;
            this.remarkDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.remarkDGV.Size = new System.Drawing.Size(1290, 125);
            this.remarkDGV.TabIndex = 0;
            this.remarkDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.remarkDGV_CellContentClick);
            this.remarkDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.remarkDGV_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Remark ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hall Student ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Remark:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Author:";
            // 
            // remarkIDL
            // 
            this.remarkIDL.AutoSize = true;
            this.remarkIDL.Location = new System.Drawing.Point(184, 20);
            this.remarkIDL.Name = "remarkIDL";
            this.remarkIDL.Size = new System.Drawing.Size(161, 13);
            this.remarkIDL.TabIndex = 4;
            this.remarkIDL.Text = "It Will Be generate automatically.";
            // 
            // remarkTB
            // 
            this.remarkTB.Location = new System.Drawing.Point(173, 103);
            this.remarkTB.Multiline = true;
            this.remarkTB.Name = "remarkTB";
            this.remarkTB.Size = new System.Drawing.Size(233, 98);
            this.remarkTB.TabIndex = 5;
            // 
            // authorTB
            // 
            this.authorTB.Location = new System.Drawing.Point(173, 207);
            this.authorTB.Name = "authorTB";
            this.authorTB.Size = new System.Drawing.Size(233, 20);
            this.authorTB.TabIndex = 6;
            // 
            // hall_std_IDL
            // 
            this.hall_std_IDL.AutoSize = true;
            this.hall_std_IDL.Location = new System.Drawing.Point(184, 58);
            this.hall_std_IDL.Name = "hall_std_IDL";
            this.hall_std_IDL.Size = new System.Drawing.Size(161, 13);
            this.hall_std_IDL.TabIndex = 7;
            this.hall_std_IDL.Text = "It Will Be generate automatically.";
            // 
            // remark_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1362, 742);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.inputAnnexGB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.informationAnnexGB);
            this.Name = "remark_info";
            this.Text = "remark_info";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.inputAnnexGB.ResumeLayout(false);
            this.inputAnnexGB.PerformLayout();
            this.searchCriteriaGB.ResumeLayout(false);
            this.searchCriteriaGB.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentDGV)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.informationAnnexGB.ResumeLayout(false);
            this.informationAnnexGB.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.remarkDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox inputAnnexGB;
        private System.Windows.Forms.GroupBox searchCriteriaGB;
        private System.Windows.Forms.RadioButton roomSearchRB;
        private System.Windows.Forms.RadioButton registrationSearchRB;
        private System.Windows.Forms.RadioButton anySearchRB;
        private System.Windows.Forms.Button searchB;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.RadioButton rollSearchRB;
        private System.Windows.Forms.RadioButton idSearchRB;
        private System.Windows.Forms.RadioButton nameSearchRB;
        private System.Windows.Forms.RadioButton searchRemarkToDeleteRB;
        private System.Windows.Forms.RadioButton addRemarkRB;
        private System.Windows.Forms.RadioButton searchRemarkToUpdateRB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView studentDGV;
        private System.Windows.Forms.Button updateRemarkB;
        private System.Windows.Forms.Button addRemarkB;
        private System.Windows.Forms.Button deleteRemarkB;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button cancelB;
        private System.Windows.Forms.GroupBox informationAnnexGB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView remarkDGV;
        private System.Windows.Forms.TextBox authorTB;
        private System.Windows.Forms.TextBox remarkTB;
        private System.Windows.Forms.Label remarkIDL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label hall_std_IDL;
    }
}