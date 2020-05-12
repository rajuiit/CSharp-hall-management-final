using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;


namespace Hall_Management_System.Report
{
    
    public partial class hallReportWithSearch : Form
    {
      //  StringFormat strFormat;
        //List<int> arrColumnLefts;
        //List<int> arrColumnWidths;
        //arrColumnLefts.Clear();
        //arrColumnWidths.Clear();
      //  int iCellHeight ;
        //int iCount ;
        /// <summary>
        /// 
        /// </summary>
//int iRow;
  //      int iTotalWidth,iHeaderHeight;
    //    bool bFirstPage ,bNewPage ;
        String selected_column,columnName, value;
        Basic.information_load il = new Basic.information_load();
        public hallReportWithSearch()
        {
            InitializeComponent();
            //for load infformation
           
          

            
        }

        private void hallSearchRB_CheckedChanged(object sender, EventArgs e)
        {
            hallCB.Visible = true;
            deptCB.Visible = false;
            facultyCB.Visible = false;
            qoutaCB.Visible = false;

            il.load(hallCB, "hall_info", "hall_name"); 
           

          
           
        }

        private void departmentSearchRB_CheckedChanged(object sender, EventArgs e)
        {
            hallCB.Visible = false;
            deptCB.Visible = true;
            facultyCB.Visible = false;
            qoutaCB.Visible = false;
            il.load(deptCB, "dept_info", "dept_name");
        }

        private void facultySearchRB_CheckedChanged(object sender, EventArgs e)
        {
            hallCB.Visible = false;
            deptCB.Visible = false;
            facultyCB.Visible = true;
            qoutaCB.Visible = false;
            il.load(facultyCB, "faculty_info", "faculty_name");


        }

        private void qoutaSearchRB_CheckedChanged(object sender, EventArgs e)
        {
            hallCB.Visible = false;
            deptCB.Visible = false;
            facultyCB.Visible = false;
            qoutaCB.Visible = true;
            il.load(qoutaCB, "qouta", "qouta_name");
        }

        

        private void showAllB_Click(object sender, EventArgs e)
        {
            string query = "SELECT student_info.hall_std_id, student_info.session, student_info.class_roll, student_info.registration_no, student_info.name, student_info.f_name, student_info.m_name, student_info.address, student_info.sex, student_info.religion, student_info.mobile, student_info.phone, student_info.email, student_info.blood_group, student_info.alloted_room, `user`.name AS Added_By, qouta.qouta_name, dept_info.dept_name, hall_info.hall_name,faculty_info.faculty_name FROM student_info INNER JOIN dept_info ON student_info.dept_id = dept_info.dept_id INNER JOIN                         faculty_info ON student_info.faculty_id = faculty_info.faculty_id INNER JOIN                         hall_info ON student_info.hall_id = hall_info.hall_id INNER JOIN                         qouta ON student_info.qouta_id = qouta.qouta_id INNER JOIN                         `user` ON student_info.added_by = `user`.user_id";
            
            il.datagridview_load(query, dataGridView1);

        
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //for selected column
            selected_column = null;
            if (allChB.Checked)
            {
                selected_column = selected_column + ",student_info.hall_std_id, student_info.session, student_info.class_roll, student_info.registration_no, student_info.name, student_info.f_name, student_info.m_name, student_info.address, student_info.sex, student_info.religion, student_info.mobile, student_info.phone, student_info.email, student_info.blood_group, student_info.alloted_room, `user`.name AS Added_By, qouta.qouta_name, dept_info.dept_name, hall_info.hall_name,faculty_info.faculty_name";
            }
            chbcheckornot(studentIdChB,"student_info.hall_std_id");
            chbcheckornot(studentNameChb, "student_info.name");
            chbcheckornot(fatherNameChb, "student_info.f_name");
            chbcheckornot(motherNameChb, "student_info.m_name");
            chbcheckornot(departmentNameChB, "dept_info.dept_name");
            chbcheckornot(hallNameChB, "hall_info.hall_name");
            chbcheckornot(qoutaChB, "qouta.qouta_name");
            chbcheckornot(facultyChB, "faculty_info.faculty_name");
            chbcheckornot(addressChB, "student_info.address");
            chbcheckornot(classRollChB, "student_info.class_roll");
            chbcheckornot(registrationNoChB, "student_info.registration_no");
            chbcheckornot(sexChB, "student_info.sex");
            chbcheckornot(religionChB, "student_info.religion");
            chbcheckornot(emailChB, "student_info.email");
            chbcheckornot(mobileChb, "student_info.mobile");
            chbcheckornot(phoneChB, "student_info.phone");
            chbcheckornot(bloodGroupChB, "student_info.blood_group");
            chbcheckornot(allotedRoomChB, "student_info.alloted_room");
            chbcheckornot(added_byChB, "user.name AS Added_By");
            
            
            selected_column = selected_column.Remove(0,1);
            
//for where clause

            rbcheckornot(hallSearchRB, "hall_name", hallCB);
            rbcheckornot(departmentSearchRB, "dept_name", deptCB);
            rbcheckornot(facultySearchRB, "faculty_name", facultyCB);
            rbcheckornot(qoutaSearchRB, "qouta_name", qoutaCB);


//load the info 
            string query = "Select " + selected_column + " FROM            student_info INNER JOIN dept_info ON student_info.dept_id = dept_info.dept_id INNER JOIN                         faculty_info ON student_info.faculty_id = faculty_info.faculty_id INNER JOIN                         hall_info ON student_info.hall_id = hall_info.hall_id INNER JOIN qouta ON student_info.qouta_id = qouta.qouta_id INNER JOIN `user` ON student_info.added_by = `user`.user_id where " + columnName + " = '" + value + "'";
            il.datagridview_load(query, dataGridView1);

        }

        private void allChB_CheckedChanged(object sender, EventArgs e)
        {
            if (allChB.Checked) {
                studentIdChB.Checked = false;
                studentNameChb.Checked = false;
                fatherNameChb.Checked = false;
                motherNameChb.Checked = false;
               
                departmentNameChB.Checked = false;
                hallNameChB.Checked = false;
                qoutaChB.Checked = false;
                facultyChB.Checked = false;
                addressChB.Checked = false;

                classRollChB.Checked = false;
                registrationNoChB.Checked = false;
                sexChB.Checked = false;
                religionChB.Checked = false;
                emailChB.Checked = false;

                mobileChb.Checked = false;
                phoneChB.Checked = false;
                bloodGroupChB.Checked = false;
                allotedRoomChB.Checked = false;
                added_byChB.Checked = false;
                }
        }

        private void all_off(CheckBox combo) {
            if (combo.Checked)
            {
                allChB.Checked = false;
            }
        
        
        }

        private void studentIdChB_CheckedChanged(object sender, EventArgs e)
        {
            all_off(studentIdChB);
        }

        private void studentNameChb_CheckedChanged(object sender, EventArgs e)
        {
            all_off(studentNameChb);

        }

        private void fatherNameChb_CheckedChanged(object sender, EventArgs e)
        {
            all_off(fatherNameChb);
        }

        
        
        private void saveEXCELB_Click(object sender, EventArgs e)
        {
            Basic.excel_load el = new Basic.excel_load();
            el.saveAsExcel(dataGridView1);
        }

        
        private void motherNameChb_CheckedChanged(object sender, EventArgs e)
        {
            all_off(motherNameChb);
        }

        private void departmentNameChB_CheckedChanged(object sender, EventArgs e)
        {
            all_off(departmentNameChB);
        }

        private void hallNameChB_CheckedChanged(object sender, EventArgs e)
        {
            all_off(hallNameChB);

        }

        private void qoutaChB_CheckedChanged(object sender, EventArgs e)
        {
            all_off(qoutaChB);
        }

        private void facultyChB_CheckedChanged(object sender, EventArgs e)
        {
            all_off(facultyChB);
        }

        private void addressChB_CheckedChanged(object sender, EventArgs e)
        {
            all_off(addressChB);
        }

        private void classRollChB_CheckedChanged(object sender, EventArgs e)
        {
            all_off(classRollChB);
        }

        private void registrationNoChB_CheckedChanged(object sender, EventArgs e)
        {
            all_off(registrationNoChB);
        }

        private void sexChB_CheckedChanged(object sender, EventArgs e)
        {
            all_off(sexChB);
        }

        private void religionChB_CheckedChanged(object sender, EventArgs e)
        {
            all_off(religionChB);
        }

        private void emailChB_CheckedChanged(object sender, EventArgs e)
        {
            all_off(emailChB);
        }

        private void mobileChb_CheckedChanged(object sender, EventArgs e)
        {
            all_off(mobileChb);
        }

        private void phoneChB_CheckedChanged(object sender, EventArgs e)
        {
            all_off(phoneChB);
        }

        private void bloodGroupChB_CheckedChanged(object sender, EventArgs e)
        {
            all_off(bloodGroupChB);

        }

        private void allotedRoomChB_CheckedChanged(object sender, EventArgs e)
        {
            all_off(allotedRoomChB);
        }

        private void added_byChB_CheckedChanged(object sender, EventArgs e)
        {
            all_off(added_byChB);
        }


        private void chbcheckornot(CheckBox chb,string column) {
            if (chb.Checked)
            {
                selected_column = selected_column + "," + column;
            }
        }
        private void rbcheckornot(RadioButton rb,string columnname,ComboBox cb) {

            if (rb.Checked)
            {
                columnName = columnname;
                value = cb.SelectedItem.ToString();

            }
        
        
        }

        private void savePDFB_Click(object sender, EventArgs e)
        {
            Basic.excel_load el = new Basic.excel_load();
            el.saveAsPDF(dataGridView1);
        }

        
        
        
    }
}
