namespace Hall_Management_System.Edit
{
    partial class dept_info
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchDeptToDeleteRB = new System.Windows.Forms.RadioButton();
            this.searchDeptCB = new System.Windows.Forms.ComboBox();
            this.addDeptRB = new System.Windows.Forms.RadioButton();
            this.searchDeptToUpdateRB = new System.Windows.Forms.RadioButton();
            this.deptNameTB = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.addDeptB = new System.Windows.Forms.Button();
            this.updateDeptB = new System.Windows.Forms.Button();
            this.deleteDeptB = new System.Windows.Forms.Button();
            this.cancelB = new System.Windows.Forms.Button();
            this.facultyNameCB = new System.Windows.Forms.ComboBox();
            this.deptIdL = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchDeptToDeleteRB);
            this.groupBox1.Controls.Add(this.searchDeptCB);
            this.groupBox1.Controls.Add(this.addDeptRB);
            this.groupBox1.Controls.Add(this.searchDeptToUpdateRB);
            this.groupBox1.Location = new System.Drawing.Point(21, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 90);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Annex";
            // 
            // searchDeptToDeleteRB
            // 
            this.searchDeptToDeleteRB.AutoSize = true;
            this.searchDeptToDeleteRB.Location = new System.Drawing.Point(85, 44);
            this.searchDeptToDeleteRB.Name = "searchDeptToDeleteRB";
            this.searchDeptToDeleteRB.Size = new System.Drawing.Size(131, 17);
            this.searchDeptToDeleteRB.TabIndex = 3;
            this.searchDeptToDeleteRB.TabStop = true;
            this.searchDeptToDeleteRB.Text = "Search Dept to Delete";
            this.searchDeptToDeleteRB.UseVisualStyleBackColor = true;
            this.searchDeptToDeleteRB.CheckedChanged += new System.EventHandler(this.searchDeptToDeleteRB_CheckedChanged);
            // 
            // searchDeptCB
            // 
            this.searchDeptCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchDeptCB.FormattingEnabled = true;
            this.searchDeptCB.Location = new System.Drawing.Point(320, 27);
            this.searchDeptCB.Name = "searchDeptCB";
            this.searchDeptCB.Size = new System.Drawing.Size(134, 21);
            this.searchDeptCB.TabIndex = 2;
            this.searchDeptCB.SelectedIndexChanged += new System.EventHandler(this.searchDeptCB_SelectedIndexChanged);
            // 
            // addDeptRB
            // 
            this.addDeptRB.AutoSize = true;
            this.addDeptRB.Location = new System.Drawing.Point(85, 67);
            this.addDeptRB.Name = "addDeptRB";
            this.addDeptRB.Size = new System.Drawing.Size(145, 17);
            this.addDeptRB.TabIndex = 1;
            this.addDeptRB.Text = "I want to add a new Dept";
            this.addDeptRB.UseVisualStyleBackColor = true;
            this.addDeptRB.CheckedChanged += new System.EventHandler(this.addDeptRB_CheckedChanged);
            // 
            // searchDeptToUpdateRB
            // 
            this.searchDeptToUpdateRB.AutoSize = true;
            this.searchDeptToUpdateRB.Checked = true;
            this.searchDeptToUpdateRB.Location = new System.Drawing.Point(85, 20);
            this.searchDeptToUpdateRB.Name = "searchDeptToUpdateRB";
            this.searchDeptToUpdateRB.Size = new System.Drawing.Size(164, 17);
            this.searchDeptToUpdateRB.TabIndex = 0;
            this.searchDeptToUpdateRB.TabStop = true;
            this.searchDeptToUpdateRB.Text = "Search Dept name to Update";
            this.searchDeptToUpdateRB.UseVisualStyleBackColor = true;
            this.searchDeptToUpdateRB.CheckedChanged += new System.EventHandler(this.searchDeptToUpdateRB_CheckedChanged);
            // 
            // deptNameTB
            // 
            this.deptNameTB.Location = new System.Drawing.Point(162, 96);
            this.deptNameTB.Name = "deptNameTB";
            this.deptNameTB.Size = new System.Drawing.Size(219, 20);
            this.deptNameTB.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.addDeptB);
            this.groupBox3.Controls.Add(this.updateDeptB);
            this.groupBox3.Controls.Add(this.deleteDeptB);
            this.groupBox3.Controls.Add(this.cancelB);
            this.groupBox3.Location = new System.Drawing.Point(20, 349);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(495, 68);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Action Annex";
            // 
            // addDeptB
            // 
            this.addDeptB.Location = new System.Drawing.Point(151, 30);
            this.addDeptB.Name = "addDeptB";
            this.addDeptB.Size = new System.Drawing.Size(75, 23);
            this.addDeptB.TabIndex = 3;
            this.addDeptB.Text = "Add";
            this.addDeptB.UseVisualStyleBackColor = true;
            this.addDeptB.Click += new System.EventHandler(this.addDeptB_Click);
            // 
            // updateDeptB
            // 
            this.updateDeptB.Location = new System.Drawing.Point(232, 30);
            this.updateDeptB.Name = "updateDeptB";
            this.updateDeptB.Size = new System.Drawing.Size(75, 23);
            this.updateDeptB.TabIndex = 2;
            this.updateDeptB.Text = "Update";
            this.updateDeptB.UseVisualStyleBackColor = true;
            this.updateDeptB.Click += new System.EventHandler(this.updateDeptB_Click);
            // 
            // deleteDeptB
            // 
            this.deleteDeptB.Location = new System.Drawing.Point(325, 30);
            this.deleteDeptB.Name = "deleteDeptB";
            this.deleteDeptB.Size = new System.Drawing.Size(75, 23);
            this.deleteDeptB.TabIndex = 1;
            this.deleteDeptB.Text = "Delete";
            this.deleteDeptB.UseVisualStyleBackColor = true;
            this.deleteDeptB.Click += new System.EventHandler(this.deleteDeptB_Click);
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
            // facultyNameCB
            // 
            this.facultyNameCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.facultyNameCB.FormattingEnabled = true;
            this.facultyNameCB.Location = new System.Drawing.Point(172, 153);
            this.facultyNameCB.Name = "facultyNameCB";
            this.facultyNameCB.Size = new System.Drawing.Size(126, 21);
            this.facultyNameCB.TabIndex = 3;
            // 
            // deptIdL
            // 
            this.deptIdL.AutoSize = true;
            this.deptIdL.Location = new System.Drawing.Point(159, 52);
            this.deptIdL.Name = "deptIdL";
            this.deptIdL.Size = new System.Drawing.Size(61, 13);
            this.deptIdL.TabIndex = 4;
            this.deptIdL.Text = "No Dept ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deptNameTB);
            this.groupBox2.Controls.Add(this.deptIdL);
            this.groupBox2.Controls.Add(this.facultyNameCB);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(21, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 239);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information Annex";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Faculty Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dept Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dept ID:";
            // 
            // dept_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 424);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "dept_info";
            this.Text = "Hall Management System Department Information";
            this.Load += new System.EventHandler(this.searchDeptToUpdateRB_CheckedChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton searchDeptToDeleteRB;
        private System.Windows.Forms.ComboBox searchDeptCB;
        private System.Windows.Forms.RadioButton addDeptRB;
        private System.Windows.Forms.RadioButton searchDeptToUpdateRB;
        private System.Windows.Forms.TextBox deptNameTB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button addDeptB;
        private System.Windows.Forms.Button updateDeptB;
        private System.Windows.Forms.Button deleteDeptB;
        private System.Windows.Forms.Button cancelB;
        private System.Windows.Forms.ComboBox facultyNameCB;
        private System.Windows.Forms.Label deptIdL;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}