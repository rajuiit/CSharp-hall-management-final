namespace Hall_Management_System.Student
{
    partial class search_student
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
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cancelB = new System.Windows.Forms.Button();
            this.informationAnnexGB = new System.Windows.Forms.GroupBox();
            this.studentDGV = new System.Windows.Forms.DataGridView();
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
            this.groupBox7.SuspendLayout();
            this.informationAnnexGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDGV)).BeginInit();
            this.inputAnnexGB.SuspendLayout();
            this.searchCriteriaGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cancelB);
            this.groupBox7.Location = new System.Drawing.Point(18, 617);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1286, 56);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Action";
            // 
            // cancelB
            // 
            this.cancelB.Location = new System.Drawing.Point(1151, 19);
            this.cancelB.Name = "cancelB";
            this.cancelB.Size = new System.Drawing.Size(75, 23);
            this.cancelB.TabIndex = 4;
            this.cancelB.Text = "Cancel";
            this.cancelB.UseVisualStyleBackColor = true;
            // 
            // informationAnnexGB
            // 
            this.informationAnnexGB.Controls.Add(this.studentDGV);
            this.informationAnnexGB.Location = new System.Drawing.Point(12, 166);
            this.informationAnnexGB.Name = "informationAnnexGB";
            this.informationAnnexGB.Size = new System.Drawing.Size(1292, 445);
            this.informationAnnexGB.TabIndex = 5;
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
            this.studentDGV.Size = new System.Drawing.Size(1286, 426);
            this.studentDGV.TabIndex = 0;
            this.studentDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentDGV_CellContentClick);
            // 
            // inputAnnexGB
            // 
            this.inputAnnexGB.Controls.Add(this.searchCriteriaGB);
            this.inputAnnexGB.Location = new System.Drawing.Point(12, 12);
            this.inputAnnexGB.Name = "inputAnnexGB";
            this.inputAnnexGB.Size = new System.Drawing.Size(1292, 148);
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
            this.searchCriteriaGB.Location = new System.Drawing.Point(110, 19);
            this.searchCriteriaGB.Name = "searchCriteriaGB";
            this.searchCriteriaGB.Size = new System.Drawing.Size(828, 108);
            this.searchCriteriaGB.TabIndex = 8;
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
            // search_student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 685);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.informationAnnexGB);
            this.Controls.Add(this.inputAnnexGB);
            this.Name = "search_student";
            this.Text = "search_student";
            this.Load += new System.EventHandler(this.search_student_Load);
            this.groupBox7.ResumeLayout(false);
            this.informationAnnexGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentDGV)).EndInit();
            this.inputAnnexGB.ResumeLayout(false);
            this.searchCriteriaGB.ResumeLayout(false);
            this.searchCriteriaGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button cancelB;
        private System.Windows.Forms.GroupBox informationAnnexGB;
        private System.Windows.Forms.DataGridView studentDGV;
        private System.Windows.Forms.GroupBox inputAnnexGB;
        private System.Windows.Forms.GroupBox searchCriteriaGB;
        private System.Windows.Forms.RadioButton anySearchRB;
        private System.Windows.Forms.Button searchB;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.RadioButton rollSearchRB;
        private System.Windows.Forms.RadioButton idSearchRB;
        private System.Windows.Forms.RadioButton nameSearchRB;
        private System.Windows.Forms.RadioButton roomSearchRB;
        private System.Windows.Forms.RadioButton registrationSearchRB;


    }
}