namespace Hall_Management_System.Settings
{
    partial class basic_settings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.anim_pictureLB = new System.Windows.Forms.ListBox();
            this.anamtionCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteTSSM = new System.Windows.Forms.ToolStripMenuItem();
            this.loginpageBrowseB = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginPagePB = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reportheaderimageBrowseB = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportHeaderPB = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.anamtionCMS.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginPagePB)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportHeaderPB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1346, 94);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Annex";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(402, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hall Basic Settings Wizard";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.splitContainer1);
            this.groupBox2.Location = new System.Drawing.Point(13, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1345, 508);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information Annex";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 16);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.loginpageBrowseB);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.reportheaderimageBrowseB);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Size = new System.Drawing.Size(1339, 489);
            this.splitContainer1.SplitterDistance = 658;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.anim_pictureLB);
            this.panel3.Location = new System.Drawing.Point(44, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(418, 117);
            this.panel3.TabIndex = 4;
            // 
            // anim_pictureLB
            // 
            this.anim_pictureLB.ContextMenuStrip = this.anamtionCMS;
            this.anim_pictureLB.FormattingEnabled = true;
            this.anim_pictureLB.Location = new System.Drawing.Point(4, 4);
            this.anim_pictureLB.Name = "anim_pictureLB";
            this.anim_pictureLB.Size = new System.Drawing.Size(409, 108);
            this.anim_pictureLB.TabIndex = 0;
            this.anim_pictureLB.SelectedIndexChanged += new System.EventHandler(this.anim_pictureLB_SelectedIndexChanged);
            // 
            // anamtionCMS
            // 
            this.anamtionCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteTSSM});
            this.anamtionCMS.Name = "anamtionCMS";
            this.anamtionCMS.Size = new System.Drawing.Size(153, 48);
            // 
            // deleteTSSM
            // 
            this.deleteTSSM.Name = "deleteTSSM";
            this.deleteTSSM.Size = new System.Drawing.Size(152, 22);
            this.deleteTSSM.Text = "Delete";
            this.deleteTSSM.Click += new System.EventHandler(this.deleteTSSM_Click);
            // 
            // loginpageBrowseB
            // 
            this.loginpageBrowseB.Location = new System.Drawing.Point(222, 418);
            this.loginpageBrowseB.Name = "loginpageBrowseB";
            this.loginpageBrowseB.Size = new System.Drawing.Size(226, 23);
            this.loginpageBrowseB.TabIndex = 3;
            this.loginpageBrowseB.Text = "Browse && upload anmation image";
            this.loginpageBrowseB.UseVisualStyleBackColor = true;
            this.loginpageBrowseB.Click += new System.EventHandler(this.loginpageBrowseB_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.loginPagePB);
            this.panel1.Location = new System.Drawing.Point(43, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 214);
            this.panel1.TabIndex = 2;
            // 
            // loginPagePB
            // 
            this.loginPagePB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginPagePB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPagePB.Location = new System.Drawing.Point(0, 0);
            this.loginPagePB.Name = "loginPagePB";
            this.loginPagePB.Size = new System.Drawing.Size(417, 212);
            this.loginPagePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loginPagePB.TabIndex = 1;
            this.loginPagePB.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Himalaya", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log In Page Image Upload";
            // 
            // reportheaderimageBrowseB
            // 
            this.reportheaderimageBrowseB.Location = new System.Drawing.Point(40, 296);
            this.reportheaderimageBrowseB.Name = "reportheaderimageBrowseB";
            this.reportheaderimageBrowseB.Size = new System.Drawing.Size(75, 23);
            this.reportheaderimageBrowseB.TabIndex = 4;
            this.reportheaderimageBrowseB.Text = "Browse";
            this.reportheaderimageBrowseB.UseVisualStyleBackColor = true;
            this.reportheaderimageBrowseB.Click += new System.EventHandler(this.reportheaderimageBrowseB_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.reportHeaderPB);
            this.panel2.Location = new System.Drawing.Point(26, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 214);
            this.panel2.TabIndex = 3;
            // 
            // reportHeaderPB
            // 
            this.reportHeaderPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportHeaderPB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportHeaderPB.Location = new System.Drawing.Point(0, 0);
            this.reportHeaderPB.Name = "reportHeaderPB";
            this.reportHeaderPB.Size = new System.Drawing.Size(417, 212);
            this.reportHeaderPB.TabIndex = 1;
            this.reportHeaderPB.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Himalaya", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(19, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 40);
            this.label3.TabIndex = 1;
            this.label3.Text = "Report Header Image";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(13, 626);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1345, 57);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Action Annex";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // basic_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "basic_settings";
            this.Text = "basic_settings";
            this.Load += new System.EventHandler(this.basic_settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.anamtionCMS.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loginPagePB)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reportHeaderPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox loginPagePB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox reportHeaderPB;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button loginpageBrowseB;
        private System.Windows.Forms.Button reportheaderimageBrowseB;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox anim_pictureLB;
        private System.Windows.Forms.ContextMenuStrip anamtionCMS;
        private System.Windows.Forms.ToolStripMenuItem deleteTSSM;
    }
}