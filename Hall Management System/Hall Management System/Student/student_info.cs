using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO; //For Directory class
using MySql.Data.MySqlClient;

namespace Hall_Management_System.Student
{
    public partial class student_info : Form
    {

        object s = new object();
        
        MySqlConnection con = Database.DBConnect.getconnectionstring();
        Basic.information_load il = new Basic.information_load();
        Database.DBConnect db = new Database.DBConnect();
        private int uid;
            
        public student_info()
        {
            InitializeComponent();
            
        }

        private void addStudentRB_CheckedChanged(object sender, EventArgs e)
        {
            if(addStudentRB.Checked){


                empty_all();
                studentIdL.Text = "It will be generate automatically.";
                addedByL.Text = "It will be generate automatically";

            //which group box will show or not
            searchCriteriaGB.Visible = false;
            studentDGV.Enabled = false;
            informationAnnexGB.Enabled = true;
            addStudentB.Enabled = true;
            updateStudentB.Enabled = false;
            deleteStudentB.Enabled = false;

            

        }
            

        }

        private void empty_all()
        {
            searchTB.Text = "";
            anySearchRB.Checked = true;
            searchB_Click(s, EventArgs.Empty);
            //column null
            studentIdL.Text = "";
            classRollTB.Text = "";
            registrationTB.Text = "";
            studentNameTB.Text = "";
            fatherNameTB.Text = "";
            motherNameTB.Text = "";
            addressTB.Text = "";
            sexCB.SelectedIndex = 0;
            religionTB.Text = "";
            degreeCB.SelectedIndex = 0;
            mobileTB.Text = "";
            phoneTB.Text = "";
            emailTB.Text = "";
            bloodGroupCB.SelectedIndex = 0;
            roomTB.Text = "";
            //for form load part
            il.load(hallNameCB, "hall_info", "hall_name");
            il.load(deptNameCB, "dept_info", "dept_name");
            il.load(facultyNameCB, "faculty_info", "faculty_name");
            il.load(qoutaCB, "qouta", "qouta_name");
            addedByL.Text = "";
            currentStudentRB.Checked = true;
            studentPB.ImageLocation = "";
            

        }

        private void searchStudentToUpdateRB_CheckedChanged(object sender, EventArgs e)
        {
            if (searchStudentToUpdateRB.Checked)
            {
                empty_all();            


                //end of column null
                searchCriteriaGB.Visible = true;
                studentDGV.Enabled = true;
                informationAnnexGB.Enabled = true;
                addStudentB.Enabled = false;
                updateStudentB.Enabled = true;
                deleteStudentB.Enabled = false;

            }
            
        }

        private void searchStudentToDeleteRB_CheckedChanged(object sender, EventArgs e)
        {
            if (searchStudentToDeleteRB.Checked)
            {
                empty_all();

                //end of column null
                searchCriteriaGB.Visible = true;
                studentDGV.Enabled = true;
                informationAnnexGB.Enabled = false;
                addStudentB.Enabled = false;
                updateStudentB.Enabled = false;
                deleteStudentB.Enabled = true;
            }
        }

       

        

       

        private void addStudentB_Click(object sender, EventArgs e)
        {
            if (Basic.validation.check_empty(classRollTB) == "no") return;
            if (Basic.validation.check_empty(registrationTB) == "no") return;
            if (Basic.validation.check_empty(studentNameTB) == "no") return;
            

            String hall_id = il.get_value("select hall_id from hall_info where hall_name='" + hallNameCB.SelectedItem + "'");
            String dept_id = il.get_value("select dept_id from dept_info where dept_name='" + deptNameCB.SelectedItem + "'");
            String faculty_id = il.get_value("select faculty_id from faculty_info where faculty_name='" + facultyNameCB.SelectedItem + "'");
            String qouta_id = il.get_value("select qouta_id from qouta where qouta_name='" + qoutaCB.SelectedItem+ "'");
            String status="0";
            
            if (currentStudentRB.Checked)
            {
                status = "0";
            }
            if(oldStudentRB.Checked) {
                status = "1";
            }

            String sql = "INSERT INTO `student_info` (`hall_std_id`, `session`, `class_roll`, `registration_no`, `name`, `f_name`, `m_name`, `address`, `sex`, `religion`, `degree`, `mobile`, `phone`, `email`, `blood_group`, `alloted_room`, `hall_id`, `dept_id`, `faculty_id`, `qouta_id`, `added_by`, `status`) VALUES (NULL, '"+sessionCB.Text+"', '"+classRollTB.Text+"', '"+registrationTB.Text+"', '"+studentNameTB.Text+"', '"+fatherNameTB.Text+"', '"+motherNameTB.Text+"', '"+addressTB.Text+"', '"+sexCB.SelectedItem+"', '"+religionTB.Text+"', '"+degreeCB.SelectedItem+"', '"+mobileTB.Text+"', '"+phoneTB.Text+"', '"+emailTB.Text+"', '"+bloodGroupCB.SelectedItem+"', '"+roomTB.Text+"', '"+hall_id+"', '"+dept_id+"', '"+faculty_id+"', '"+qouta_id+"', '"+uid+"', '"+status+"');";
            
            db.Insert(sql);
            
            addStudentRB_CheckedChanged(s, EventArgs.Empty);

        }

        private void updateStudentB_Click(object sender, EventArgs e)
        {
            if (Basic.validation.check_empty(studentIdL.Text) == "no") return;
            if (Basic.validation.check_empty(classRollTB) == "no") return;
            if (Basic.validation.check_empty(registrationTB) == "no") return;
            if (Basic.validation.check_empty(studentNameTB) == "no") return;


            String hall_id = il.get_value("select hall_id from hall_info where hall_name='" + hallNameCB.SelectedItem + "'");
            String dept_id = il.get_value("select dept_id from dept_info where dept_name='" + deptNameCB.SelectedItem + "'");
            String faculty_id = il.get_value("select faculty_id from faculty_info where faculty_name='" + facultyNameCB.SelectedItem + "'");
            String qouta_id = il.get_value("select qouta_id from qouta where qouta_name='" + qoutaCB.SelectedItem + "'");
            String status = "0";

            if (currentStudentRB.Checked)
            {
                status = "0";
            }
            if (oldStudentRB.Checked)
            {
                status = "1";
            }
            string updatequery = "UPDATE `student_info` SET `session` = '" + sessionCB.SelectedItem + "',`class_roll` = '" + classRollTB.Text + "',`registration_no` = '" + registrationTB.Text + "',`name` = '" + studentNameTB.Text + "',`f_name` = '" + fatherNameTB.Text + "',`m_name` = '" + motherNameTB.Text + "',`address` = '" + addressTB.Text + "',`sex` = '" + sexCB.SelectedItem + "',`religion` = '" + religionTB.Text + "',`degree` = '" + degreeCB.SelectedItem + "',`mobile` = '" + mobileTB.Text + "',`phone` = '" + phoneTB.Text + "',`email` = '" + emailTB.Text + "',`blood_group` ='" + bloodGroupCB.SelectedItem + "', `alloted_room` = '"+roomTB.Text+"',`hall_id` = '" + hall_id + "',`dept_id` = '" + dept_id + "',`faculty_id` = '" + faculty_id + "',`qouta_id` = '" + qouta_id + "',`added_by` = '" + uid + "',`status` = '" + status + "' WHERE `hall_std_id` =" + studentIdL.Text + "";

            db.Update(updatequery);
            searchStudentToUpdateRB_CheckedChanged(s, EventArgs.Empty);
            
            

                   }

       
        private void deleteStudentB_Click(object sender, EventArgs e)
        {
            if (Basic.validation.check_empty(studentIdL.Text,"Please select a student.") == "no") return;

            string deletequery = "DELETE FROM `student_info` WHERE `student_info`.`hall_std_id` = '" + studentIdL.Text + "'";
            db.Delete(deletequery);
            searchStudentToDeleteRB_CheckedChanged(s, EventArgs.Empty);
        }

        private void take_photoLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (mobileTB.Text == "" || studentIdL.Text == "" || studentNameTB.Text=="")
            {
                MessageBox.Show("Please fill up Student ID , Student Name and Mobile No", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Student.image_upload iu = new Student.image_upload();
             iu.id = studentIdL.Text;
            iu.name = studentNameTB.Text;
            iu.mobileNo = mobileTB.Text;
           //iu.MdiParent = MDIMain.ActiveForm;
            iu.Show();
        }

        private void show_roomLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            room rr = new room();
            rr.intial(hallNameCB.SelectedItem.ToString(), roomTB.Text.ToString());
            //rr.MdiParent = MDIMain.ActiveForm;
            rr.Show();
        }

        private void student_info_Load(object sender, EventArgs e)
        {
            



            
           
        }

        private void studentDGV_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            int row = e.Row.Index;
            int column = 0;
            if (row > -1) {

                String hall_std_id= studentDGV[column, row].Value.ToString();


            


            }

        }



        internal void intial(int u_id,string action, string searchText, string searchCondition) {
            uid = u_id;
            if (action == "update") {
                searchStudentToUpdateRB.Checked = true;
                
                search(searchText,searchCondition);
                searchStudentToUpdateRB_CheckedChanged(s, EventArgs.Empty);
                
            }
            else if (action == "delete")
            {
                searchStudentToDeleteRB.Checked = true;

                search(searchText,searchCondition);
                searchStudentToDeleteRB_CheckedChanged(s, EventArgs.Empty);
            }
            else {
                addStudentRB.Checked = true;
                
                addStudentRB_CheckedChanged(s, EventArgs.Empty);
            }
        
        }

      internal void search(string text, string condition){
          searchTB.Text = text;
          if (condition == "id") {
              idSearchRB.Checked = true;

          }
          else if (condition == "name") {
              nameSearchRB.Checked = true;
          }
          else if (condition == "roll")
          {
              rollSearchRB.Checked = true;
          }
          else {
              anySearchRB.Checked = true;
          }
          object s = new object();
          searchB_Click(s, EventArgs.Empty);

      }

      private void studentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
      {
          int row = e.RowIndex;
          int column = 0;
          if (row > -1)
          {
              string sid = studentDGV[column, row].Value.ToString();
              try
              {
                  con.Open();

                  MySqlCommand cmd = new MySqlCommand("SELECT s.hall_std_id, s.session, s.class_roll, s.registration_no, s.name, s.f_name, s.m_name, s.address, s.sex, s.religion,s.degree, s.mobile, s.phone, s.email, s.blood_group, s.alloted_room, h.hall_name, d.dept_name,f.faculty_name ,q.qouta_name, u.name AS Added_By,s.status FROM student_info as s,dept_info as d,faculty_info as f,hall_info as h,qouta as q ,user as u where s.dept_id = d.dept_id and s.faculty_id = f.faculty_id and s.hall_id = h.hall_id and s.qouta_id = q.qouta_id and s.added_by = u.user_id and s.hall_std_id =" + sid , con);

                  MySqlDataReader reader = cmd.ExecuteReader();

                  if (reader.Read())
                  {
                      studentIdL.Text = reader.GetString("hall_std_id").ToString();
                      sessionCB.SelectedItem = reader.GetString("session").ToString();
                      classRollTB.Text = reader.GetString("class_roll").ToString();
                      registrationTB.Text = reader.GetString("registration_no").ToString();
                      studentNameTB.Text = reader.GetString("name").ToString();
                      fatherNameTB.Text = reader.GetString("f_name").ToString();
                      motherNameTB.Text = reader.GetString("m_name").ToString();
                      addressTB.Text = reader.GetString("address").ToString();
                      sexCB.SelectedItem = reader.GetString("sex").ToString();
                      religionTB.Text = reader.GetString("religion").ToString();
                      degreeCB.SelectedItem = reader.GetString("degree").ToString();
                      mobileTB.Text = reader.GetString("mobile").ToString();
                      phoneTB.Text = reader.GetString("phone").ToString();
                      emailTB.Text = reader.GetString("email").ToString();
                      bloodGroupCB.SelectedItem = reader.GetString("blood_group").ToString();
                      roomTB.Text = reader.GetString("alloted_room").ToString();

                      hallNameCB.SelectedItem = reader.GetString("hall_name").ToString();
                      deptNameCB.SelectedItem = reader.GetString("dept_name").ToString();
                      facultyNameCB.SelectedItem = reader.GetString("faculty_name").ToString();
                      qoutaCB.SelectedItem = reader.GetString("qouta_name").ToString();
                      addedByL.Text = reader.GetString("Added_By").ToString();
                      int status = reader.GetInt32("status");
                      if (status == 0)
                      {
                          currentStudentRB.Checked = true;
                      }
                      else {
                          oldStudentRB.Checked = true;
                      }


                      il.image_load(reader.GetString("mobile"), studentPB);


                  }
                  reader.Close();


                  con.Close();
              }
              catch (Exception ex)
              {
                  MessageBox.Show("Error occured. Message - " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  con.Close();
              }
          }


      }

      private void reloadLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
      {
          il.image_load(mobileTB.Text, studentPB);
      }

      private void student_info_Activated(object sender, EventArgs e)
      {
          il.image_load(mobileTB.Text, studentPB);

      }

      private void searchB_Click(object sender, EventArgs e)
      {
          Student.search aa = new Student.search();
          aa.searchButtonWork(searchTB, anySearchRB, idSearchRB, nameSearchRB, rollSearchRB, registrationSearchRB, roomSearchRB, studentDGV);
      }

      


        

       
    }
}
