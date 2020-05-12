using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Hall_Management_System
{
    public partial class mainui : Form
    {
        private int uid;
        Basic.information_load bi = new Basic.information_load();
        Database.DBConnect db = new Database.DBConnect();
       
        public mainui()
        {
            InitializeComponent();
        }

        private void mainui_Load(object sender, EventArgs e)
        {
            Basic.information_load.app_info(hallTSSL);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            bi.tool_load("calc.exe");
        }

        private void newUserButton_Click(object sender, EventArgs e)
        {
            //for admin check validation
            if (Basic.validation.check_admin(uid) == "no") return;

           
                User.addUserForm au = new User.addUserForm();
                //au.MdiParent = this;
                au.Show();
           

        }

        private void updateUserButton_Click(object sender, EventArgs e)
        {
            User.updateUserForm uu = new User.updateUserForm();
            uu.intial(uid);
            // uu.MdiParent = this;
            uu.Show();

        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            if (Basic.validation.check_admin(uid) == "no") return;

            User.deleteUserForm du = new User.deleteUserForm();
           // du.MdiParent = this;
            du.Show();

        }

        private void userInformationButton_Click(object sender, EventArgs e)
        {
            User.all_user aa = new User.all_user();
           // aa.MdiParent = this;
            aa.Show();

        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            sign_out();
        }

        private void sign_out()
        {
            this.Visible = false;
            Form1 ff = new Form1();
            ff.Visible = true;
            
            notifyIcon1.Dispose();
           
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void edit_hallButton_Click(object sender, EventArgs e)
        {
            Hall.Hall_info hi = new Hall.Hall_info();
            hi.intial("add", "");
            //hh.MdiParent = this;
            hi.Show();
        }

        private void edit_facultyButton_Click(object sender, EventArgs e)
        {
            Edit.faculty_info fi = new Edit.faculty_info();
            fi.intial("add","");
            //hh.MdiParent = this;
            fi.Show();
        }

        private void edit_departmentButton_Click(object sender, EventArgs e)
        {
            Edit.dept_info di = new Edit.dept_info();
            di.intial("add", "");
            //hh.MdiParent = this;
            di.Show();
        }

        private void edit_qoutaButton_Click(object sender, EventArgs e)
        {
            Edit.qouta qq = new Edit.qouta();
            qq.intial("add","");
            //hh.MdiParent = this;
            qq.Show();
        }

        private void all_informationButton_Click(object sender, EventArgs e)
        {
            Edit.all_info eai = new Edit.all_info();
            //eai.MdiParent = this;
            eai.Visible = true;
        }

        private void newStudentButton_Click(object sender, EventArgs e)
        {
            Student.student_info ss = new Student.student_info();
            ss.intial(uid, "add", "", "");
          //  ss.MdiParent = this;
            ss.Show();
        }

        private void search_reportButton_Click(object sender, EventArgs e)
        {
            Report.hallReportWithSearch hr = new Report.hallReportWithSearch();
            //hr.MdiParent = this;
            hr.Show();
        }

        private void createCouponButton_Click(object sender, EventArgs e)
        {
            Special.coupon sc = new Special.coupon();
            //sc.MdiParent = this;
            sc.Show();
        }

        private void room_settings_button_Click(object sender, EventArgs e)
        {
            Settings.room_info aii = new Settings.room_info();
            aii.intial("add", "", "");
          //  aii.MdiParent = this;
            aii.Visible = true;
        }

        private void notepadButton_Click(object sender, EventArgs e)
        {
            bi.tool_load("notepad.exe");
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            AboutBox aa = new AboutBox();
            aa.Show();
        }

        private void hall_basic_settings_button_Click(object sender, EventArgs e)
        {
            Settings.basic_settings bc = new Settings.basic_settings();
            bc.Show();
        }

        private void updateStudentButton_Click(object sender, EventArgs e)
        {
            Student.student_info ss = new Student.student_info();
            ss.intial(uid, "update", "", "");
            //  ss.MdiParent = this;
            ss.Show();
        }

        private void deleteStudentButton_Click(object sender, EventArgs e)
        {
            Student.student_info ss = new Student.student_info();
            ss.intial(uid, "delete", "", "");
            //  ss.MdiParent = this;
            ss.Show();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Help Option is not available now. Please Contact your Administrator.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void developerButton_Click(object sender, EventArgs e)
        {
            developer dd = new developer();
            dd.Show();
        }

        private void notificationButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This service is not available now. Please Contact your Administrator.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void searchStudentB_Click(object sender, EventArgs e)
        {
            Student.search_student ss = new Student.search_student();
            ss.Visible = true;
        }

        private void searchB_Click(object sender, EventArgs e)
        {
            string radio="";
            string text = "";
            if (idSearchRB.Checked == true)
            {
                radio = "hall_std_id";
            }
            if (nameSearchRB.Checked == true)
            {
                radio = "student_info.name";
            }
            if (rollSearchRB.Checked == true)
            {
                radio = "class_roll";
            }

            if (searchTB.Text == "")
            {
                MessageBox.Show("Please fill up the empty field.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                searchTB.Focus();
                return;
            }
            else {
                text = searchTB.Text;
            }

            Student.single_student_report cs = new Student.single_student_report();
            cs.radio = radio;
            cs.text = text;
            cs.button = true;
            cs.Show();

        }




        internal void intial(int u_id)
        {
           uid=  u_id;
        }

        private void signoutupB_Click(object sender, EventArgs e)
        {
            sign_out();
        }

        private void singel_student_reportB_Click(object sender, EventArgs e)
        {
            Student.single_student_report ss = new Student.single_student_report();
            ss.Show();
        }

        private void take_attendanceB_Click(object sender, EventArgs e)
        {
            Attendance.take_attendance ta = new Attendance.take_attendance();
            ta.Visible = true;

        }

        private void ateendanceSettingsB_Click(object sender, EventArgs e)
        {
            Attendance.attendance_settings ui = new Attendance.attendance_settings();
            ui.Visible = true;
           
        }

        private void addRemarkB_Click(object sender, EventArgs e)
        {
            Remark.remark_info ri = new Remark.remark_info();
            ri.Visible = true;
        }

        
        
    }
}
