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
    public partial class faculty_info : Form
    {

       Database.DBConnect df = new Database.DBConnect();
        MySqlConnection con = Database.DBConnect.getconnectionstring();
        Basic.information_load bi = new Basic.information_load();
        public faculty_info()
        {
            InitializeComponent();
        }


        private void addFacultyRB_CheckedChanged(object sender, EventArgs e)
        {
            if (addFacultyRB.Checked)
            {

                searchFacultyCB.Visible = false;
                groupBox2.Enabled = true;
                addFacultyB.Enabled = true;
                updateFacultyB.Enabled = false;
                deleteFacultyB.Enabled = false;

                facultyIdL.Text = "ID will be automatically generated";
                facultyNameTB.Text = "";
                

            }
        }

        private void searchFacultyToDeleteRB_CheckedChanged(object sender, EventArgs e)
        {
            if (searchFacultyToDeleteRB.Checked)
            {
                searchFacultyCB.Visible = true;
                bi.load(searchFacultyCB, "faculty_info", "faculty_name");
                groupBox2.Enabled = false;
                addFacultyB.Enabled = false;
                updateFacultyB.Enabled = false;
                deleteFacultyB.Enabled = false;

            }
            if (searchFacultyCB.Items.Count != 0)
            {
                groupBox2.Enabled = false;
                addFacultyB.Enabled = false;
                updateFacultyB.Enabled = false;
                deleteFacultyB.Enabled = true;

            }
        }

        private void searchFacultyToUpdateRB_CheckedChanged(object sender, EventArgs e)
        {
            if (searchFacultyToUpdateRB.Checked)
            {
                searchFacultyCB.Visible = true;
                bi.load(searchFacultyCB, "faculty_info", "faculty_name");
                groupBox2.Enabled = false;
                addFacultyB.Enabled = false;
                updateFacultyB.Enabled = false;
                deleteFacultyB.Enabled = false;
            }


            if (searchFacultyCB.Items.Count != 0)
            {
                groupBox2.Enabled = true;
                addFacultyB.Enabled = false;
                updateFacultyB.Enabled = true;
                deleteFacultyB.Enabled = false;
            }
        }

        private void searchFacultyCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM faculty_info where faculty_name='" + searchFacultyCB.SelectedItem.ToString() + "'", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    facultyIdL.Text = reader.GetString(0).ToString();
                    facultyNameTB.Text = reader.GetString(1).ToString();
                 }
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured. Message - " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addFacultyB_Click(object sender, EventArgs e)
        {
            if (facultyNameTB.Text == "")
            {
                MessageBox.Show("Please fill up the faculty Name. ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            try
            {
                //add query string and insert command run
                string insertQuery = "insert into faculty_info values (null,'" + facultyNameTB.Text.ToString() + "')";

                df.Insert(insertQuery);
                // end add query string and insert command run

                facultyNameTB.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured. Message - " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void deleteFacultyB_Click(object sender, EventArgs e)
        {
            try
            {
                //add delete query string and delete command run

                string deleteQuery = "delete from faculty_info where faculty_id='" + facultyIdL.Text.ToString() + "' ";
                df.Delete(deleteQuery);
                // end of add delete query string and delete command run
                Basic.information_load bn = new Basic.information_load();
                bn.load(searchFacultyCB, "faculty_info", "faculty_name");
            }
            catch (Exception ee)
            {
                MessageBox.Show("Error Occured. Message - " + ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateFacultyB_Click(object sender, EventArgs e)
        {
            if (facultyNameTB.Text == "")
            {
                MessageBox.Show("Please fill up the faculty Name. ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                facultyNameTB.Focus();
                return;
            }
            try
            {
                // start of update command run
                string updateQuery = "update faculty_info set faculty_name='" + facultyNameTB.Text.ToString() + "' where faculty_id='" + facultyIdL.Text.ToString() + "'";
                df.Update(updateQuery);
                //end of update command runn

                Basic.information_load bn = new Basic.information_load();
                bn.load(searchFacultyCB, "faculty_info", "faculty_name");
                
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





        internal void intial(string action, string faculty_name)
        {
            if (action == "update")
            {
                searchFacultyToUpdateRB.Checked = true;
                searchFacultyCB.SelectedItem = faculty_name;
            }
            else if (action == "delete")
            {
                searchFacultyToDeleteRB.Checked = true;
                searchFacultyCB.SelectedItem = faculty_name;
            }
            else
            {
                addFacultyRB.Checked = true;
            }
        }
    }
}
