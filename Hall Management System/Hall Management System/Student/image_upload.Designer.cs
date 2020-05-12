namespace Hall_Management_System.Student
{
    partial class image_upload
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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.reloadB = new System.Windows.Forms.Button();
            this.browseB = new System.Windows.Forms.Button();
            this.takePhotoB = new System.Windows.Forms.Button();
            this.studentPB = new System.Windows.Forms.PictureBox();
            this.mobileNoL = new System.Windows.Forms.Label();
            this.s_idL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.s_name = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentPB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.reloadB);
            this.groupBox6.Controls.Add(this.browseB);
            this.groupBox6.Controls.Add(this.takePhotoB);
            this.groupBox6.Controls.Add(this.studentPB);
            this.groupBox6.Location = new System.Drawing.Point(98, 72);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(319, 379);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Image";
            // 
            // reloadB
            // 
            this.reloadB.Location = new System.Drawing.Point(6, 350);
            this.reloadB.Name = "reloadB";
            this.reloadB.Size = new System.Drawing.Size(75, 23);
            this.reloadB.TabIndex = 3;
            this.reloadB.Text = "Reload";
            this.reloadB.UseVisualStyleBackColor = true;
            this.reloadB.Click += new System.EventHandler(this.reloadB_Click);
            // 
            // browseB
            // 
            this.browseB.Location = new System.Drawing.Point(231, 350);
            this.browseB.Name = "browseB";
            this.browseB.Size = new System.Drawing.Size(75, 23);
            this.browseB.TabIndex = 2;
            this.browseB.Text = "Browse";
            this.browseB.UseVisualStyleBackColor = true;
            this.browseB.Click += new System.EventHandler(this.browseB_Click);
            // 
            // takePhotoB
            // 
            this.takePhotoB.Location = new System.Drawing.Point(109, 350);
            this.takePhotoB.Name = "takePhotoB";
            this.takePhotoB.Size = new System.Drawing.Size(75, 23);
            this.takePhotoB.TabIndex = 1;
            this.takePhotoB.Text = "Take Photo";
            this.takePhotoB.UseVisualStyleBackColor = true;
            this.takePhotoB.Click += new System.EventHandler(this.takePhotoB_Click);
            // 
            // studentPB
            // 
            this.studentPB.ImageLocation = "";
            this.studentPB.InitialImage = null;
            this.studentPB.Location = new System.Drawing.Point(6, 14);
            this.studentPB.Name = "studentPB";
            this.studentPB.Size = new System.Drawing.Size(300, 300);
            this.studentPB.TabIndex = 0;
            this.studentPB.TabStop = false;
            // 
            // mobileNoL
            // 
            this.mobileNoL.AutoSize = true;
            this.mobileNoL.Location = new System.Drawing.Point(380, 34);
            this.mobileNoL.Name = "mobileNoL";
            this.mobileNoL.Size = new System.Drawing.Size(37, 13);
            this.mobileNoL.TabIndex = 28;
            this.mobileNoL.Text = "mobile";
            // 
            // s_idL
            // 
            this.s_idL.AutoSize = true;
            this.s_idL.Location = new System.Drawing.Point(125, 9);
            this.s_idL.Name = "s_idL";
            this.s_idL.Size = new System.Drawing.Size(32, 13);
            this.s_idL.TabIndex = 27;
            this.s_idL.Text = "s_idL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Student Mobile No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Student ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Student Name:";
            // 
            // s_name
            // 
            this.s_name.AutoSize = true;
            this.s_name.Location = new System.Drawing.Point(125, 43);
            this.s_name.Name = "s_name";
            this.s_name.Size = new System.Drawing.Size(50, 13);
            this.s_name.TabIndex = 30;
            this.s_name.Text = "s_nameL";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // image_upload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 491);
            this.Controls.Add(this.s_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mobileNoL);
            this.Controls.Add(this.s_idL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox6);
            this.Name = "image_upload";
            this.Text = "Hall Management System Image Upload";
            this.Activated += new System.EventHandler(this.reloadB_Click);
            this.Load += new System.EventHandler(this.image_upload_Load);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button browseB;
        private System.Windows.Forms.Button takePhotoB;
        private System.Windows.Forms.PictureBox studentPB;
        private System.Windows.Forms.Label mobileNoL;
        private System.Windows.Forms.Label s_idL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label s_name;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button reloadB;
    }
}