namespace Hall_Management_System.Attendance
{
    partial class attendance_settings
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
            this.saveB = new System.Windows.Forms.Button();
            this.startDTP = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.endDTP = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveB
            // 
            this.saveB.Location = new System.Drawing.Point(441, 260);
            this.saveB.Name = "saveB";
            this.saveB.Size = new System.Drawing.Size(75, 23);
            this.saveB.TabIndex = 0;
            this.saveB.Text = "Save";
            this.saveB.UseVisualStyleBackColor = true;
            this.saveB.Click += new System.EventHandler(this.saveB_Click);
            // 
            // startDTP
            // 
            this.startDTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startDTP.Location = new System.Drawing.Point(160, 68);
            this.startDTP.Name = "startDTP";
            this.startDTP.Size = new System.Drawing.Size(190, 20);
            this.startDTP.TabIndex = 1;
            this.startDTP.ValueChanged += new System.EventHandler(this.startDTP_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start Date && Time";
            // 
            // endDTP
            // 
            this.endDTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endDTP.Location = new System.Drawing.Point(160, 150);
            this.endDTP.Name = "endDTP";
            this.endDTP.Size = new System.Drawing.Size(190, 20);
            this.endDTP.TabIndex = 4;
            this.endDTP.ValueChanged += new System.EventHandler(this.endDTP_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "End Date && Time";
            // 
            // attendance_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 307);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.endDTP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startDTP);
            this.Controls.Add(this.saveB);
            this.Name = "attendance_settings";
            this.Text = "attendance_settings";
            this.Load += new System.EventHandler(this.attendance_settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveB;
        private System.Windows.Forms.DateTimePicker startDTP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker endDTP;
        private System.Windows.Forms.Label label2;
    }
}