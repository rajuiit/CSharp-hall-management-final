namespace Hall_Management_System.User
{
    partial class all_user
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.userInfoDGV = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.saveExcelB = new System.Windows.Forms.Button();
            this.popupmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoDGV)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.popupmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Access";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.userInfoDGV);
            this.groupBox2.Location = new System.Drawing.Point(12, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(507, 295);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // userInfoDGV
            // 
            this.userInfoDGV.AllowUserToAddRows = false;
            this.userInfoDGV.AllowUserToDeleteRows = false;
            this.userInfoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userInfoDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userInfoDGV.Location = new System.Drawing.Point(3, 16);
            this.userInfoDGV.Name = "userInfoDGV";
            this.userInfoDGV.ReadOnly = true;
            this.userInfoDGV.Size = new System.Drawing.Size(501, 276);
            this.userInfoDGV.TabIndex = 0;
            this.userInfoDGV.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.userInfoDGV_CellMouseClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.saveExcelB);
            this.groupBox3.Location = new System.Drawing.Point(12, 402);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(507, 83);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Action";
            // 
            // saveExcelB
            // 
            this.saveExcelB.Location = new System.Drawing.Point(326, 34);
            this.saveExcelB.Name = "saveExcelB";
            this.saveExcelB.Size = new System.Drawing.Size(90, 23);
            this.saveExcelB.TabIndex = 0;
            this.saveExcelB.Text = "Save as Excel";
            this.saveExcelB.UseVisualStyleBackColor = true;
            this.saveExcelB.Click += new System.EventHandler(this.saveExcelB_Click);
            // 
            // popupmenu
            // 
            this.popupmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem});
            this.popupmenu.Name = "popupmenu";
            this.popupmenu.Size = new System.Drawing.Size(153, 70);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem.Text = "add";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editToolStripMenuItem.Text = "edit";
            // 
            // all_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 497);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "all_user";
            this.Text = "Hall Management System All User";
            this.Load += new System.EventHandler(this.all_user_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userInfoDGV)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.popupmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView userInfoDGV;
        private System.Windows.Forms.Button saveExcelB;
        private System.Windows.Forms.ContextMenuStrip popupmenu;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}