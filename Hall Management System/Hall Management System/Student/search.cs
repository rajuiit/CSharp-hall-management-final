using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hall_Management_System.Student
{
    class search
    {
        Basic.information_load il = new Basic.information_load();
        internal void searchButtonWork(TextBox searchTB, RadioButton anySearchRB, RadioButton idSearchRB, RadioButton nameSearchRB, RadioButton rollSearchRB,RadioButton registrationSearchRB,RadioButton roomSearchRB,  DataGridView studentDGV)
        {

            //SELECT *  FROM `student_info` WHERE  `class_roll` LIKE '%12%' or  `registration_no` LIKE '%1%' or `name` LIKE '%re%' Or `f_name` LIKE '%re%' or `m_name` LIKE '%re%' or `address` LIKE '%re%'
            string cond = searchTB.Text;
            String column = "";

            if (anySearchRB.Checked)
            {
                column = " `name` ";
            }
            if (idSearchRB.Checked == true)
            {
                column = " `hall_std_id` ";
            }
            if (nameSearchRB.Checked == true)
            {
                column = " `name` ";
            }
            if (rollSearchRB.Checked == true)
            {
                column = " `class_roll` ";
            }
            if (registrationSearchRB.Checked == true)
            {
                column = " `registration_no` ";
            }
            if (roomSearchRB.Checked == true)
            {
                column = " `alloted_room` ";
            }
            String sql = "SELECT s.hall_std_id, s.session, s.class_roll, s.registration_no, s.name, s.f_name, s.m_name, s.address, s.sex, s.religion,s.degree, s.mobile, s.phone, s.email, s.blood_group, s.alloted_room, h.hall_name , d.dept_name,f.faculty_name ,q.qouta_name, u.name AS Added_By  FROM student_info as s,dept_info as d,faculty_info as f,hall_info as h,qouta as q ,user as u where s.dept_id = d.dept_id and s.faculty_id = f.faculty_id and s.hall_id = h.hall_id and s.qouta_id = q.qouta_id and s.added_by = u.user_id and  s." + column + "  LIKE '%" + cond + "%' ";


            il.datagridview_load(sql, studentDGV);
        }
    }
}
