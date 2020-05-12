namespace Hall_Management_System.Edit
{
    partial class all_info
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.saveExcelB = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.infoTC = new System.Windows.Forms.TabControl();
            this.hallinfoTP = new System.Windows.Forms.TabPage();
            this.hallDGV = new System.Windows.Forms.DataGridView();
            this.facultyinfoTP = new System.Windows.Forms.TabPage();
            this.facultyDGV = new System.Windows.Forms.DataGridView();
            this.deptinfoTP = new System.Windows.Forms.TabPage();
            this.deptDGV = new System.Windows.Forms.DataGridView();
            this.qoutaTP = new System.Windows.Forms.TabPage();
            this.qoutaDGV = new System.Windows.Forms.DataGridView();
            this.popupmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ediitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.infoTC.SuspendLayout();
            this.hallinfoTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hallDGV)).BeginInit();
            this.facultyinfoTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facultyDGV)).BeginInit();
            this.deptinfoTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deptDGV)).BeginInit();
            this.qoutaTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qoutaDGV)).BeginInit();
            this.popupmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.saveExcelB);
            this.groupBox3.Location = new System.Drawing.Point(12, 402);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(507, 83);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Action";
            // 
            // saveExcelB
            // 
            this.saveExcelB.Location = new System.Drawing.Point(305, 32);
            this.saveExcelB.Name = "saveExcelB";
            this.saveExcelB.Size = new System.Drawing.Size(96, 23);
            this.saveExcelB.TabIndex = 0;
            this.saveExcelB.Text = "Save as Excel";
            this.saveExcelB.UseVisualStyleBackColor = true;
            this.saveExcelB.Click += new System.EventHandler(this.saveExcelB_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 83);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Access";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.infoTC);
            this.groupBox2.Location = new System.Drawing.Point(13, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(504, 294);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information Annex";
            // 
            // infoTC
            // 
            this.infoTC.Controls.Add(this.hallinfoTP);
            this.infoTC.Controls.Add(this.facultyinfoTP);
            this.infoTC.Controls.Add(this.deptinfoTP);
            this.infoTC.Controls.Add(this.qoutaTP);
            this.infoTC.Location = new System.Drawing.Point(6, 19);
            this.infoTC.Name = "infoTC";
            this.infoTC.SelectedIndex = 0;
            this.infoTC.Size = new System.Drawing.Size(492, 269);
            this.infoTC.TabIndex = 0;
            // 
            // hallinfoTP
            // 
            this.hallinfoTP.Controls.Add(this.hallDGV);
            this.hallinfoTP.Location = new System.Drawing.Point(4, 22);
            this.hallinfoTP.Name = "hallinfoTP";
            this.hallinfoTP.Padding = new System.Windows.Forms.Padding(3);
            this.hallinfoTP.Size = new System.Drawing.Size(484, 243);
            this.hallinfoTP.TabIndex = 0;
            this.hallinfoTP.Text = "Hall Info";
            this.hallinfoTP.UseVisualStyleBackColor = true;
            // 
            // hallDGV
            // 
            this.hallDGV.AllowUserToAddRows = false;
            this.hallDGV.AllowUserToDeleteRows = false;
            this.hallDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hallDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hallDGV.Location = new System.Drawing.Point(3, 3);
            this.hallDGV.Name = "hallDGV";
            this.hallDGV.ReadOnly = true;
            this.hallDGV.Size = new System.Drawing.Size(478, 237);
            this.hallDGV.TabIndex = 0;
            this.hallDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hallDGV_CellClick);
            this.hallDGV.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.hallDGV_CellMouseClick);
            this.hallDGV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hallDGV_MouseDown);
            // 
            // facultyinfoTP
            // 
            this.facultyinfoTP.Controls.Add(this.facultyDGV);
            this.facultyinfoTP.Location = new System.Drawing.Point(4, 22);
            this.facultyinfoTP.Name = "facultyinfoTP";
            this.facultyinfoTP.Padding = new System.Windows.Forms.Padding(3);
            this.facultyinfoTP.Size = new System.Drawing.Size(484, 243);
            this.facultyinfoTP.TabIndex = 1;
            this.facultyinfoTP.Text = "Faculty Info";
            this.facultyinfoTP.UseVisualStyleBackColor = true;
            // 
            // facultyDGV
            // 
            this.facultyDGV.AllowUserToAddRows = false;
            this.facultyDGV.AllowUserToDeleteRows = false;
            this.facultyDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facultyDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.facultyDGV.Location = new System.Drawing.Point(3, 3);
            this.facultyDGV.Name = "facultyDGV";
            this.facultyDGV.ReadOnly = true;
            this.facultyDGV.Size = new System.Drawing.Size(478, 237);
            this.facultyDGV.TabIndex = 1;
            // 
            // deptinfoTP
            // 
            this.deptinfoTP.Controls.Add(this.deptDGV);
            this.deptinfoTP.Location = new System.Drawing.Point(4, 22);
            this.deptinfoTP.Name = "deptinfoTP";
            this.deptinfoTP.Padding = new System.Windows.Forms.Padding(3);
            this.deptinfoTP.Size = new System.Drawing.Size(484, 243);
            this.deptinfoTP.TabIndex = 2;
            this.deptinfoTP.Text = "Department Info";
            this.deptinfoTP.UseVisualStyleBackColor = true;
            // 
            // deptDGV
            // 
            this.deptDGV.AllowUserToAddRows = false;
            this.deptDGV.AllowUserToDeleteRows = false;
            this.deptDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deptDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deptDGV.Location = new System.Drawing.Point(3, 3);
            this.deptDGV.Name = "deptDGV";
            this.deptDGV.ReadOnly = true;
            this.deptDGV.Size = new System.Drawing.Size(478, 237);
            this.deptDGV.TabIndex = 1;
            // 
            // qoutaTP
            // 
            this.qoutaTP.Controls.Add(this.qoutaDGV);
            this.qoutaTP.Location = new System.Drawing.Point(4, 22);
            this.qoutaTP.Name = "qoutaTP";
            this.qoutaTP.Padding = new System.Windows.Forms.Padding(3);
            this.qoutaTP.Size = new System.Drawing.Size(484, 243);
            this.qoutaTP.TabIndex = 3;
            this.qoutaTP.Text = "Qouta Info";
            this.qoutaTP.UseVisualStyleBackColor = true;
            // 
            // qoutaDGV
            // 
            this.qoutaDGV.AllowUserToAddRows = false;
            this.qoutaDGV.AllowUserToDeleteRows = false;
            this.qoutaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qoutaDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qoutaDGV.Location = new System.Drawing.Point(3, 3);
            this.qoutaDGV.Name = "qoutaDGV";
            this.qoutaDGV.ReadOnly = true;
            this.qoutaDGV.Size = new System.Drawing.Size(478, 237);
            this.qoutaDGV.TabIndex = 1;
            // 
            // popupmenu
            // 
            this.popupmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.ediitToolStripMenuItem});
            this.popupmenu.Name = "popupmenu";
            this.popupmenu.Size = new System.Drawing.Size(98, 48);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // ediitToolStripMenuItem
            // 
            this.ediitToolStripMenuItem.Name = "ediitToolStripMenuItem";
            this.ediitToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.ediitToolStripMenuItem.Text = "Ediit";
            // 
            // all_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 492);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "all_info";
            this.Text = "Hall Management System Information";
            this.Load += new System.EventHandler(this.all_info_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.infoTC.ResumeLayout(false);
            this.hallinfoTP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hallDGV)).EndInit();
            this.facultyinfoTP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.facultyDGV)).EndInit();
            this.deptinfoTP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deptDGV)).EndInit();
            this.qoutaTP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qoutaDGV)).EndInit();
            this.popupmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl infoTC;
        private System.Windows.Forms.TabPage hallinfoTP;
        private System.Windows.Forms.DataGridView hallDGV;
        private System.Windows.Forms.TabPage facultyinfoTP;
        private System.Windows.Forms.TabPage deptinfoTP;
        private System.Windows.Forms.TabPage qoutaTP;
        private System.Windows.Forms.DataGridView facultyDGV;
        private System.Windows.Forms.DataGridView deptDGV;
        private System.Windows.Forms.DataGridView qoutaDGV;
        private System.Windows.Forms.Button saveExcelB;
        private System.Windows.Forms.ContextMenuStrip popupmenu;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ediitToolStripMenuItem;
    }
}