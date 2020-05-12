namespace Hall_Management_System.Hall
{
    partial class Hall_info
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
            this.searchHallToDeleteRB = new System.Windows.Forms.RadioButton();
            this.searchHallCB = new System.Windows.Forms.ComboBox();
            this.addHallRB = new System.Windows.Forms.RadioButton();
            this.searchHallToUpdateRB = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hallNameTB = new System.Windows.Forms.TextBox();
            this.hallIdL = new System.Windows.Forms.Label();
            this.hallTypeCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.addHallB = new System.Windows.Forms.Button();
            this.updateHallB = new System.Windows.Forms.Button();
            this.deleteHallB = new System.Windows.Forms.Button();
            this.cancelB = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchHallToDeleteRB);
            this.groupBox1.Controls.Add(this.searchHallCB);
            this.groupBox1.Controls.Add(this.addHallRB);
            this.groupBox1.Controls.Add(this.searchHallToUpdateRB);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Annex";
            // 
            // searchHallToDeleteRB
            // 
            this.searchHallToDeleteRB.AutoSize = true;
            this.searchHallToDeleteRB.Location = new System.Drawing.Point(36, 44);
            this.searchHallToDeleteRB.Name = "searchHallToDeleteRB";
            this.searchHallToDeleteRB.Size = new System.Drawing.Size(126, 17);
            this.searchHallToDeleteRB.TabIndex = 3;
            this.searchHallToDeleteRB.TabStop = true;
            this.searchHallToDeleteRB.Text = "Search Hall to Delete";
            this.searchHallToDeleteRB.UseVisualStyleBackColor = true;
            this.searchHallToDeleteRB.CheckedChanged += new System.EventHandler(this.searchHallToDeleteRB_CheckedChanged);
            // 
            // searchHallCB
            // 
            this.searchHallCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchHallCB.FormattingEnabled = true;
            this.searchHallCB.Location = new System.Drawing.Point(301, 20);
            this.searchHallCB.Name = "searchHallCB";
            this.searchHallCB.Size = new System.Drawing.Size(134, 21);
            this.searchHallCB.TabIndex = 2;
            this.searchHallCB.SelectedIndexChanged += new System.EventHandler(this.searchHallCB_SelectedIndexChanged);
            // 
            // addHallRB
            // 
            this.addHallRB.AutoSize = true;
            this.addHallRB.Location = new System.Drawing.Point(36, 67);
            this.addHallRB.Name = "addHallRB";
            this.addHallRB.Size = new System.Drawing.Size(138, 17);
            this.addHallRB.TabIndex = 1;
            this.addHallRB.Text = "I want to add a new hall";
            this.addHallRB.UseVisualStyleBackColor = true;
            this.addHallRB.CheckedChanged += new System.EventHandler(this.addHallRB_CheckedChanged);
            // 
            // searchHallToUpdateRB
            // 
            this.searchHallToUpdateRB.AutoSize = true;
            this.searchHallToUpdateRB.Checked = true;
            this.searchHallToUpdateRB.Location = new System.Drawing.Point(36, 20);
            this.searchHallToUpdateRB.Name = "searchHallToUpdateRB";
            this.searchHallToUpdateRB.Size = new System.Drawing.Size(159, 17);
            this.searchHallToUpdateRB.TabIndex = 0;
            this.searchHallToUpdateRB.TabStop = true;
            this.searchHallToUpdateRB.Text = "Search Hall name to Update";
            this.searchHallToUpdateRB.UseVisualStyleBackColor = true;
            this.searchHallToUpdateRB.CheckedChanged += new System.EventHandler(this.searchHallToUpdateRB_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.hallNameTB);
            this.groupBox2.Controls.Add(this.hallIdL);
            this.groupBox2.Controls.Add(this.hallTypeCB);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(13, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 239);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information Annex";
            // 
            // hallNameTB
            // 
            this.hallNameTB.Location = new System.Drawing.Point(113, 96);
            this.hallNameTB.Name = "hallNameTB";
            this.hallNameTB.Size = new System.Drawing.Size(219, 20);
            this.hallNameTB.TabIndex = 5;
            // 
            // hallIdL
            // 
            this.hallIdL.AutoSize = true;
            this.hallIdL.Location = new System.Drawing.Point(110, 52);
            this.hallIdL.Name = "hallIdL";
            this.hallIdL.Size = new System.Drawing.Size(56, 13);
            this.hallIdL.TabIndex = 4;
            this.hallIdL.Text = "No Hall ID";
            // 
            // hallTypeCB
            // 
            this.hallTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hallTypeCB.FormattingEnabled = true;
            this.hallTypeCB.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.hallTypeCB.Location = new System.Drawing.Point(113, 147);
            this.hallTypeCB.Name = "hallTypeCB";
            this.hallTypeCB.Size = new System.Drawing.Size(126, 21);
            this.hallTypeCB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hall Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hall Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hall ID:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.addHallB);
            this.groupBox3.Controls.Add(this.updateHallB);
            this.groupBox3.Controls.Add(this.deleteHallB);
            this.groupBox3.Controls.Add(this.cancelB);
            this.groupBox3.Location = new System.Drawing.Point(12, 354);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(495, 68);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Action Annex";
            // 
            // addHallB
            // 
            this.addHallB.Location = new System.Drawing.Point(159, 30);
            this.addHallB.Name = "addHallB";
            this.addHallB.Size = new System.Drawing.Size(75, 23);
            this.addHallB.TabIndex = 3;
            this.addHallB.Text = "Add";
            this.addHallB.UseVisualStyleBackColor = true;
            this.addHallB.Click += new System.EventHandler(this.addHallB_Click);
            // 
            // updateHallB
            // 
            this.updateHallB.Location = new System.Drawing.Point(240, 30);
            this.updateHallB.Name = "updateHallB";
            this.updateHallB.Size = new System.Drawing.Size(75, 23);
            this.updateHallB.TabIndex = 2;
            this.updateHallB.Text = "Update";
            this.updateHallB.UseVisualStyleBackColor = true;
            this.updateHallB.Click += new System.EventHandler(this.updateHallB_Click);
            // 
            // deleteHallB
            // 
            this.deleteHallB.Location = new System.Drawing.Point(333, 30);
            this.deleteHallB.Name = "deleteHallB";
            this.deleteHallB.Size = new System.Drawing.Size(75, 23);
            this.deleteHallB.TabIndex = 1;
            this.deleteHallB.Text = "Delete";
            this.deleteHallB.UseVisualStyleBackColor = true;
            this.deleteHallB.Click += new System.EventHandler(this.deleteHallB_Click);
            // 
            // cancelB
            // 
            this.cancelB.Location = new System.Drawing.Point(414, 30);
            this.cancelB.Name = "cancelB";
            this.cancelB.Size = new System.Drawing.Size(75, 23);
            this.cancelB.TabIndex = 0;
            this.cancelB.Text = "Cancel";
            this.cancelB.UseVisualStyleBackColor = true;
            this.cancelB.Click += new System.EventHandler(this.cancelB_Click);
            // 
            // Hall_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 434);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Hall_info";
            this.Text = "Hall Management System Hall Information";
            this.Load += new System.EventHandler(this.searchHallToUpdateRB_CheckedChanged);
            this.Shown += new System.EventHandler(this.searchHallToUpdateRB_CheckedChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton addHallRB;
        private System.Windows.Forms.RadioButton searchHallToUpdateRB;
        private System.Windows.Forms.ComboBox searchHallCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox hallTypeCB;
        private System.Windows.Forms.TextBox hallNameTB;
        private System.Windows.Forms.Label hallIdL;
        private System.Windows.Forms.Button addHallB;
        private System.Windows.Forms.Button updateHallB;
        private System.Windows.Forms.Button deleteHallB;
        private System.Windows.Forms.Button cancelB;
        private System.Windows.Forms.RadioButton searchHallToDeleteRB;
    }
}