using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Hall_Management_System.Basic;
namespace Hall_Management_System
{
    public partial class MDIMain : Form
    {

        public string globalUserId;
        
        public string globalUsername;
        public string globalPassword;
        public string globalName;
        public string globalAdded_by;
        information_load bi = new information_load();
        form_method fm = new form_method();

        public MDIMain()
        {
            InitializeComponent();
        }

        
        
        

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDIMain_Load(object sender, EventArgs e)
        {
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aa = new AboutBox();
            aa.Show();
        }

        private void signOutLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sign_out();        
        }

        private void newUserTSMI_Click(object sender, EventArgs e)
        {
            User.addUserForm au = new User.addUserForm();
            //au.MdiParent = this;
            au.Show();

        }

        private void updateUserTSMI_Click(object sender, EventArgs e)
        {
            User.updateUserForm uu = new User.updateUserForm();
            //uu.MdiParent = this;
            uu.Show();

            

        }
        private void sign_out() {
            Form1 ff = new Form1();
            ff.Show();
            globalUserId = "";
            globalUsername = "";
            globalPassword = "";
            globalName = "";
            globalAdded_by = "";

            this.Visible = false;
            notifyIcon1.Dispose();
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void signOutTSMI_Click(object sender, EventArgs e)
        {
            sign_out();

        }

        private void backToLoginPageTSMI_Click(object sender, EventArgs e)
        {
            sign_out();

        }

        private void allUserTSMI_Click(object sender, EventArgs e)
        {
            User.all_user aa = new User.all_user();
            aa.MdiParent = this;
            aa.Show();

        }

        private void deleteUserTSMI_Click(object sender, EventArgs e)
        {
            User.deleteUserForm du = new User.deleteUserForm();
            du.MdiParent = this;
            du.Show();

        }

        private void hall_infoTSMI_Click(object sender, EventArgs e)
        {
            Hall.Hall_info hh = new Hall.Hall_info();
            hh.MdiParent = this;
            hh.Show();

        }

        private void hallReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.hallReportWithSearch hr = new Report.hallReportWithSearch();
            hr.MdiParent = this;
            hr.Show();

        }

        private void studentInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student.student_info ss= new Student.student_info();
            
            ss.Show();

            
        }

        private void createCouponToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Special.coupon sc = new Special.coupon();
            sc.MdiParent = this;
            sc.Show();

        }

        private void createHallIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void MDIMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            fm.closeForm(e);
            
           
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Will Close Your Application 
            notifyIcon1.Dispose();
            Application.Exit();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sign_out();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.Show();

        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bi.tool_load("calc.exe");
        }

        private void notePadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bi.tool_load("notepad.exe");
        }

        private void notificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = notificationToolStripMenuItem.Checked;
        }

        private void addNewStudentTSB_Click(object sender, EventArgs e)
        {
            Student.student_info ss = new Student.student_info();
            ss.Show();
        }

        private void imageFolderLocationSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.imageLocation il = new Settings.imageLocation();
            il.MdiParent = this;
            il.Show();
        }

        private void allInfoTSMI_Click(object sender, EventArgs e)
        {
            Edit.all_info eai = new Edit.all_info();
            eai.MdiParent = this;
            eai.Visible = true;
        }

        private void roomInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.room_info aii = new Settings.room_info();
            aii.MdiParent = this;
            aii.Visible = true;
        }

        private void dept_infoTSMI_Click(object sender, EventArgs e)
        {
            Edit.dept_info hh = new Edit.dept_info();
            hh.MdiParent = this;
            hh.Show();

        }

        private void faculty_infoTSMI_Click(object sender, EventArgs e)
        {
            Edit.faculty_info hh = new Edit.faculty_info();
            hh.MdiParent = this;
            hh.Show();
        }

        private void qouta_infoTSMI_Click(object sender, EventArgs e)
        {
            Edit.qouta hh = new Edit.qouta();
            hh.MdiParent = this;
            hh.Show();
        }

        private void showAllStudentInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        

       
        
    }
}
