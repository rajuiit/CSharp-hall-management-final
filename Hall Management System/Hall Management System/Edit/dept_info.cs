using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Hall_Management_System.Edit
{
    public partial class dept_info : Form
    {
        Database.DBConnect df = new Database.DBConnect();
        MySqlConnection con = Database.DBConnect.getconnectionstring();
        Basic.information_load bi = new Basic.information_load();
        
        public dept_info()
        {
            InitializeComponent();
        }



        private void addDeptRB_CheckedChanged(object sender, EventArgs e)
        {
            if (addDeptRB.Checked)
            {

                searchDeptCB.Visible = false;
                groupBox2.Enabled = true;
                addDeptB.Enabled = true;
                updateDeptB.Enabled = false;
                deleteDeptB.Enabled = false;

                deptIdL.Text = "ID will be automatically generated";
                deptNameTB.Text = "";
                bi.load(facultyNameCB, "faculty_info", "faculty_name");


            }
        }

        private void searchDeptToDeleteRB_CheckedChanged(object sender, EventArgs e)
        {
            if (searchDeptToDeleteRB.Checked)
            {
                searchDeptCB.Visible = true;
                bi.load(searchDeptCB, "dept_info", "dept_name");
                bi.load(facultyNameCB, "faculty_info", "faculty_name");
                groupBox2.Enabled = false;
                addDeptB.Enabled = false;
                updateDeptB.Enabled = false;
                deleteDeptB.Enabled = false;

            }
            if (searchDeptCB.Items.Count != 0) {
                groupBox2.Enabled = false;
                addDeptB.Enabled = false;
                updateDeptB.Enabled = false;
                deleteDeptB.Enabled = true;

            
            }
        }

        private void searchDeptToUpdateRB_CheckedChanged(object sender, EventArgs e)
        {
            if (searchDeptToUpdateRB.Checked)
            {
                searchDeptCB.Visible = true;
                bi.load(searchDeptCB, "dept_info", "dept_name");
                bi.load(facultyNameCB, "faculty_info", "faculty_name");
                groupBox2.Enabled = false;
                addDeptB.Enabled = false;
                updateDeptB.Enabled = false;
                deleteDeptB.Enabled = false;
            }
            if (searchDeptCB.Items.Count != 0) {
                groupBox2.Enabled = true;
                addDeptB.Enabled = false;
                updateDeptB.Enabled = true;
                deleteDeptB.Enabled = false;
            }
        }

        private void searchDeptCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT dept_id,dept_name,faculty_info.faculty_name FROM dept_info,faculty_info where dept_info.faculty_id=faculty_info.faculty_id and dept_name='" + searchDeptCB.SelectedItem.ToString() + "' ", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    deptIdL.Text = reader.GetString(0).ToString();
                    deptNameTB.Text = reader.GetString(1).ToString();
                    facultyNameCB.SelectedItem = reader.GetString(2).ToString();
                }
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured. Message - " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addDeptB_Click(object sender, EventArgs e)
        {
            if (deptNameTB.Text == "")
            {
                MessageBox.Show("Please fill up the dept Name. ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            try
            {
                //add query string and insert command run
                string insertQuery = "insert into dept_info values (null,'" + deptNameTB.Text.ToString() + "',( SELECT faculty_id FROM faculty_info where faculty_name= '"+facultyNameCB.SelectedItem.ToString()+"'))";

                df.Insert(insertQuery);
                // end add query string and insert command run

                deptNameTB.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured. Message - " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void deleteDeptB_Click(object sender, EventArgs e)
        {
            try
            {
                //add delete query string and delete command run

                string deleteQuery = "delete from dept_info where dept_id='" + deptIdL.Text.ToString() + "' ";
                df.Delete(deleteQuery);
                // end of add delete query string and delete command run
                Basic.information_load bn = new Basic.information_load();
                bn.load(searchDeptCB, "dept_info", "dept_name");
            }
            catch (Exception ee)
            {
                MessageBox.Show("Error Occured. Message - " + ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateDeptB_Click(object sender, EventArgs e)
        {
            if (deptNameTB.Text == "")
            {
                MessageBox.Show("Please fill up the dept Name. ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                deptNameTB.Focus();
                return;
            }
            try
            {
                // start of update command run
                string updateQuery = "update dept_info set dept_name='" + deptNameTB.Text.ToString() + "', faculty_id='" + facultyNameCB.SelectedItem.ToString() + "' where dept_id='" + deptIdL.Text.ToString() + "'";
                df.Update(updateQuery);
                //end of update command runn

                Basic.information_load bn = new Basic.information_load();
                bn.load(searchDeptCB, "dept_info", "dept_name");
                bn.load(facultyNameCB, "faculty_info", "faculty_name");

            }
            catch (Exception ee)
            {
                MessageBox.Show("Error Occured. Message - " + ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void cancelB_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }







        internal void intial(string action, string dept_name)
        {
            if (action == "update")
            {
                searchDeptToUpdateRB.Checked = true;
                searchDeptCB.SelectedItem = dept_name;
            }
            else if (action == "delete")
            {
                searchDeptToDeleteRB.Checked = true;
                searchDeptCB.SelectedItem = dept_name;
            }
            else
            {
                addDeptRB.Checked = true;
            }
        }
    }
}
