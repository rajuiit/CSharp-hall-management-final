namespace Hall_Management_System.Edit
{
    partial class faculty_info
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
            this.updateFacultyB = new System.Windows.Forms.Button();
            this.facultyIdL = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchFacultyToDeleteRB = new System.Windows.Forms.RadioButton();
            this.searchFacultyCB = new System.Windows.Forms.ComboBox();
            this.addFacultyRB = new System.Windows.Forms.RadioButton();
            this.searchFacultyToUpdateRB = new System.Windows.Forms.RadioButton();
            this.addFacultyB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.facultyNameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.deleteFacultyB = new System.Windows.Forms.Button();
            this.cancelB = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateFacultyB
            // 
            this.updateFacultyB.Location = new System.Drawing.Point(232, 30);
            this.updateFacultyB.Name = "updateFacultyB";
            this.updateFacultyB.Size = new System.Drawing.Size(75, 23);
            this.updateFacultyB.TabIndex = 2;
            this.updateFacultyB.Text = "Update";
            this.updateFacultyB.UseVisualStyleBackColor = true;
            this.updateFacultyB.Click += new System.EventHandler(this.updateFacultyB_Click);
            // 
            // facultyIdL
            // 
            this.facultyIdL.AutoSize = true;
            this.facultyIdL.Location = new System.Drawing.Point(159, 52);
            this.facultyIdL.Name = "facultyIdL";
            this.facultyIdL.Size = new System.Drawing.Size(72, 13);
            this.facultyIdL.TabIndex = 4;
            this.facultyIdL.Text = "No Faculty ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchFacultyToDeleteRB);
            this.groupBox1.Controls.Add(this.searchFacultyCB);
            this.groupBox1.Controls.Add(this.addFacultyRB);
            this.groupBox1.Controls.Add(this.searchFacultyToUpdateRB);
            this.groupBox1.Location = new System.Drawing.Point(8, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 90);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Annex";
            // 
            // searchFacultyToDeleteRB
            // 
            this.searchFacultyToDeleteRB.AutoSize = true;
            this.searchFacultyToDeleteRB.Location = new System.Drawing.Point(85, 44);
            this.searchFacultyToDeleteRB.Name = "searchFacultyToDeleteRB";
            this.searchFacultyToDeleteRB.Size = new System.Drawing.Size(142, 17);
            this.searchFacultyToDeleteRB.TabIndex = 3;
            this.searchFacultyToDeleteRB.TabStop = true;
            this.searchFacultyToDeleteRB.Text = "Search Faculty to Delete";
            this.searchFacultyToDeleteRB.UseVisualStyleBackColor = true;
            this.searchFacultyToDeleteRB.CheckedChanged += new System.EventHandler(this.searchFacultyToDeleteRB_CheckedChanged);
            // 
            // searchFacultyCB
            // 
            this.searchFacultyCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchFacultyCB.FormattingEnabled = true;
            this.searchFacultyCB.Location = new System.Drawing.Point(320, 27);
            this.searchFacultyCB.Name = "searchFacultyCB";
            this.searchFacultyCB.Size = new System.Drawing.Size(134, 21);
            this.searchFacultyCB.TabIndex = 2;
            this.searchFacultyCB.SelectedIndexChanged += new System.EventHandler(this.searchFacultyCB_SelectedIndexChanged);
            // 
            // addFacultyRB
            // 
            this.addFacultyRB.AutoSize = true;
            this.addFacultyRB.Location = new System.Drawing.Point(85, 67);
            this.addFacultyRB.Name = "addFacultyRB";
            this.addFacultyRB.Size = new System.Drawing.Size(156, 17);
            this.addFacultyRB.TabIndex = 1;
            this.addFacultyRB.Text = "I want to add a new Faculty";
            this.addFacultyRB.UseVisualStyleBackColor = true;
            this.addFacultyRB.CheckedChanged += new System.EventHandler(this.addFacultyRB_CheckedChanged);
            // 
            // searchFacultyToUpdateRB
            // 
            this.searchFacultyToUpdateRB.AutoSize = true;
            this.searchFacultyToUpdateRB.Checked = true;
            this.searchFacultyToUpdateRB.Location = new System.Drawing.Point(85, 20);
            this.searchFacultyToUpdateRB.Name = "searchFacultyToUpdateRB";
            this.searchFacultyToUpdateRB.Size = new System.Drawing.Size(175, 17);
            this.searchFacultyToUpdateRB.TabIndex = 0;
            this.searchFacultyToUpdateRB.TabStop = true;
            this.searchFacultyToUpdateRB.Text = "Search Faculty name to Update";
            this.searchFacultyToUpdateRB.UseVisualStyleBackColor = true;
            this.searchFacultyToUpdateRB.CheckedChanged += new System.EventHandler(this.searchFacultyToUpdateRB_CheckedChanged);
            // 
            // addFacultyB
            // 
            this.addFacultyB.Location = new System.Drawing.Point(151, 30);
            this.addFacultyB.Name = "addFacultyB";
            this.addFacultyB.Size = new System.Drawing.Size(75, 23);
            this.addFacultyB.TabIndex = 3;
            this.addFacultyB.Text = "Add";
            this.addFacultyB.UseVisualStyleBackColor = true;
            this.addFacultyB.Click += new System.EventHandler(this.addFacultyB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Faculty Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.facultyNameTB);
            this.groupBox2.Controls.Add(this.facultyIdL);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(8, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 239);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information Annex";
            // 
            // facultyNameTB
            // 
            this.facultyNameTB.Location = new System.Drawing.Point(162, 96);
            this.facultyNameTB.Name = "facultyNameTB";
            this.facultyNameTB.Size = new System.Drawing.Size(219, 20);
            this.facultyNameTB.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Faculty ID:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.addFacultyB);
            this.groupBox3.Controls.Add(this.updateFacultyB);
            this.groupBox3.Controls.Add(this.deleteFacultyB);
            this.groupBox3.Controls.Add(this.cancelB);
            this.groupBox3.Location = new System.Drawing.Point(7, 354);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(495, 68);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Action Annex";
            // 
            // deleteFacultyB
            // 
            this.deleteFacultyB.Location = new System.Drawing.Point(325, 30);
            this.deleteFacultyB.Name = "deleteFacultyB";
            this.deleteFacultyB.Size = new System.Drawing.Size(75, 23);
            this.deleteFacultyB.TabIndex = 1;
            this.deleteFacultyB.Text = "Delete";
            this.deleteFacultyB.UseVisualStyleBackColor = true;
            this.deleteFacultyB.Click += new System.EventHandler(this.deleteFacultyB_Click);
            // 
            // cancelB
            // 
            this.cancelB.Location = new System.Drawing.Point(406, 30);
            this.cancelB.Name = "cancelB";
            this.cancelB.Size = new System.Drawing.Size(75, 23);
            this.cancelB.TabIndex = 0;
            this.cancelB.Text = "Cancel";
            this.cancelB.UseVisualStyleBackColor = true;
            this.cancelB.Click += new System.EventHandler(this.cancelB_Click);
            // 
            // faculty_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 434);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "faculty_info";
            this.Text = "Hall Management System Faculty Information";
            this.Load += new System.EventHandler(this.searchFacultyToUpdateRB_CheckedChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button updateFacultyB;
        private System.Windows.Forms.Label facultyIdL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton searchFacultyToDeleteRB;
        private System.Windows.Forms.ComboBox searchFacultyCB;
        private System.Windows.Forms.RadioButton addFacultyRB;
        private System.Windows.Forms.RadioButton searchFacultyToUpdateRB;
        private System.Windows.Forms.Button addFacultyB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox facultyNameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button deleteFacultyB;
        private System.Windows.Forms.Button cancelB;
    }
}