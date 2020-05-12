namespace Hall_Management_System.Database
{
    partial class dbSettings
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
            this.submitB = new System.Windows.Forms.Button();
            this.masterPasswordTF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dbPasswordTF = new System.Windows.Forms.TextBox();
            this.dbUsernameTF = new System.Windows.Forms.TextBox();
            this.dbNameTF = new System.Windows.Forms.TextBox();
            this.dbServerAddressTF = new System.Windows.Forms.TextBox();
            this.dbServerTitleTF = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cancelB = new System.Windows.Forms.Button();
            this.updateB = new System.Windows.Forms.Button();
            this.loginB = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.submitB);
            this.groupBox1.Controls.Add(this.masterPasswordTF);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Annex";
            // 
            // submitB
            // 
            this.submitB.Location = new System.Drawing.Point(326, 39);
            this.submitB.Name = "submitB";
            this.submitB.Size = new System.Drawing.Size(75, 23);
            this.submitB.TabIndex = 3;
            this.submitB.Text = "Submit";
            this.submitB.UseVisualStyleBackColor = true;
            this.submitB.Click += new System.EventHandler(this.submitB_Click);
            // 
            // masterPasswordTF
            // 
            this.masterPasswordTF.Location = new System.Drawing.Point(162, 41);
            this.masterPasswordTF.Name = "masterPasswordTF";
            this.masterPasswordTF.Size = new System.Drawing.Size(158, 20);
            this.masterPasswordTF.TabIndex = 2;
            this.masterPasswordTF.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Master Password:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dbPasswordTF);
            this.groupBox2.Controls.Add(this.dbUsernameTF);
            this.groupBox2.Controls.Add(this.dbNameTF);
            this.groupBox2.Controls.Add(this.dbServerAddressTF);
            this.groupBox2.Controls.Add(this.dbServerTitleTF);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(13, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 235);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information Annex";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dbPasswordTF
            // 
            this.dbPasswordTF.Location = new System.Drawing.Point(217, 161);
            this.dbPasswordTF.Name = "dbPasswordTF";
            this.dbPasswordTF.Size = new System.Drawing.Size(184, 20);
            this.dbPasswordTF.TabIndex = 9;
            // 
            // dbUsernameTF
            // 
            this.dbUsernameTF.Location = new System.Drawing.Point(217, 128);
            this.dbUsernameTF.Name = "dbUsernameTF";
            this.dbUsernameTF.Size = new System.Drawing.Size(184, 20);
            this.dbUsernameTF.TabIndex = 8;
            // 
            // dbNameTF
            // 
            this.dbNameTF.Location = new System.Drawing.Point(217, 94);
            this.dbNameTF.Name = "dbNameTF";
            this.dbNameTF.Size = new System.Drawing.Size(184, 20);
            this.dbNameTF.TabIndex = 7;
            // 
            // dbServerAddressTF
            // 
            this.dbServerAddressTF.Location = new System.Drawing.Point(217, 61);
            this.dbServerAddressTF.Name = "dbServerAddressTF";
            this.dbServerAddressTF.Size = new System.Drawing.Size(184, 20);
            this.dbServerAddressTF.TabIndex = 6;
            // 
            // dbServerTitleTF
            // 
            this.dbServerTitleTF.Location = new System.Drawing.Point(217, 29);
            this.dbServerTitleTF.Name = "dbServerTitleTF";
            this.dbServerTitleTF.Size = new System.Drawing.Size(184, 20);
            this.dbServerTitleTF.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Database Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Database Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Database Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Database Server Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Database Server Title";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.loginB);
            this.groupBox3.Controls.Add(this.cancelB);
            this.groupBox3.Controls.Add(this.updateB);
            this.groupBox3.Location = new System.Drawing.Point(13, 367);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(463, 74);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Action Annex";
            // 
            // cancelB
            // 
            this.cancelB.Location = new System.Drawing.Point(355, 30);
            this.cancelB.Name = "cancelB";
            this.cancelB.Size = new System.Drawing.Size(75, 23);
            this.cancelB.TabIndex = 1;
            this.cancelB.Text = "Cancel";
            this.cancelB.UseVisualStyleBackColor = true;
            this.cancelB.Click += new System.EventHandler(this.cancelB_Click);
            // 
            // updateB
            // 
            this.updateB.Enabled = false;
            this.updateB.Location = new System.Drawing.Point(274, 30);
            this.updateB.Name = "updateB";
            this.updateB.Size = new System.Drawing.Size(75, 23);
            this.updateB.TabIndex = 0;
            this.updateB.Text = "Update";
            this.updateB.UseVisualStyleBackColor = true;
            this.updateB.Click += new System.EventHandler(this.updateB_Click);
            // 
            // loginB
            // 
            this.loginB.Location = new System.Drawing.Point(148, 30);
            this.loginB.Name = "loginB";
            this.loginB.Size = new System.Drawing.Size(120, 23);
            this.loginB.TabIndex = 2;
            this.loginB.Text = "Back To Login Form";
            this.loginB.UseVisualStyleBackColor = true;
            this.loginB.Click += new System.EventHandler(this.loginB_Click);
            // 
            // dbSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 453);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "dbSettings";
            this.Text = "dbSettings";
            this.Load += new System.EventHandler(this.dbSettings_Load);
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
        private System.Windows.Forms.TextBox masterPasswordTF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dbPasswordTF;
        private System.Windows.Forms.TextBox dbUsernameTF;
        private System.Windows.Forms.TextBox dbNameTF;
        private System.Windows.Forms.TextBox dbServerAddressTF;
        private System.Windows.Forms.TextBox dbServerTitleTF;
        private System.Windows.Forms.Button cancelB;
        private System.Windows.Forms.Button updateB;
        private System.Windows.Forms.Button loginB;
    }
}