using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hall_Management_System.Hall
{
    public partial class Hall_info : Form
    {
        Database.DBConnect df = new Database.DBConnect();
        MySqlConnection con = Database.DBConnect.getconnectionstring();
        Basic.information_load bi = new Basic.information_load();
        public Hall_info()
        {
            InitializeComponent();
            
        }

       

       

        private void addHallRB_CheckedChanged(object sender, EventArgs e)
        {
            if (addHallRB.Checked) {

                searchHallCB.Visible = false;
                groupBox2.Enabled = true;
                addHallB.Enabled = true;
                updateHallB.Enabled = false;
                deleteHallB.Enabled = false;

                hallIdL.Text = "ID will be automatically generated";
                hallNameTB.Text = "";
                hallTypeCB.SelectedItem = "Male";
                
                

            }
        }

        private void searchHallToDeleteRB_CheckedChanged(object sender, EventArgs e)
        {
            if (searchHallToDeleteRB.Checked)
            {
                searchHallCB.Visible = true;
                bi.load(searchHallCB, "hall_info", "hall_name");
                groupBox2.Enabled = false;
                addHallB.Enabled = false;
                updateHallB.Enabled = false;
                deleteHallB.Enabled = false;

            }

            if (searchHallCB.Items.Count != 0)
            {
                groupBox2.Enabled = false;
                addHallB.Enabled = false;
                updateHallB.Enabled = false;
                deleteHallB.Enabled = true;
            }
        }

        private void searchHallToUpdateRB_CheckedChanged(object sender, EventArgs e)
        {
            if (searchHallToUpdateRB.Checked)
            {
                searchHallCB.Visible = true;
                bi.load(searchHallCB, "hall_info", "hall_name");
                groupBox2.Enabled = false;
                addHallB.Enabled = false;
                updateHallB.Enabled = false;
                deleteHallB.Enabled = false;
            }
            if (searchHallCB.Items.Count != 0) {
                groupBox2.Enabled = true;
                addHallB.Enabled = false;
                updateHallB.Enabled = true;
                deleteHallB.Enabled = false;
            }
        }

        private void searchHallCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM hall_info where hall_name='" + searchHallCB.SelectedItem.ToString() + "'", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    hallIdL.Text = reader.GetString(0).ToString();
                    hallNameTB.Text = reader.GetString(1).ToString();
                    hallTypeCB.SelectedItem = reader.GetString(2).ToString();
                }
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured. Message - " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addHallB_Click(object sender, EventArgs e)
        {
            if (hallNameTB.Text == "")
            {
                MessageBox.Show("Please fill up the Hall Name. ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            try
            {
                //add query string and insert command run
                string insertQuery = "insert into hall_info values (null,'" + hallNameTB.Text.ToString() + "','" + hallTypeCB.SelectedItem.ToString() + "')";
               
                df.Insert(insertQuery);
                // end add query string and insert command run
                
                hallNameTB.Text = "";
            }
            catch (Exception ex){
                MessageBox.Show("Error occured. Message - "+ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           
        }

        private void deleteHallB_Click(object sender, EventArgs e)
        {
            try{
                //add delete query string and delete command run
           
            string deleteQuery = "delete from hall_info where hall_id='" + hallIdL.Text.ToString() + "' ";
            df.Delete(deleteQuery);
            // end of add delete query string and delete command run
            
            bi.load(searchHallCB, "hall_info","hall_name");
            }
            catch (Exception ee)
            {
                MessageBox.Show("Error Occured. Message - " + ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateHallB_Click(object sender, EventArgs e)
        {
            if (hallNameTB.Text == "")
            {
                MessageBox.Show("Please fill up the Hall Name. ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                hallNameTB.Focus();
                return;
            }
            try
            {
                // start of update command run
                string updateQuery = "update hall_info set hall_name='" + hallNameTB.Text.ToString() + "', type='" + hallTypeCB.SelectedItem.ToString() + "' where hall_id='" + hallIdL.Text.ToString() + "'";
                df.Update(updateQuery);
                //end of update command runn
                
                
                bi.load(searchHallCB, "hall_info","hall_name");

            }
            catch (Exception ee) {
                MessageBox.Show("Error Occured. Message - "+ee.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        
            
        }

        private void cancelB_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        internal void intial(string action, string hall_name)
        {
            if (action == "update") {
                searchHallToUpdateRB.Checked = true;
                searchHallCB.SelectedItem = hall_name;
            }
            else if (action == "delete")
            {
                searchHallToDeleteRB.Checked = true;
                searchHallCB.SelectedItem = hall_name;
            }
            else {
                addHallRB.Checked = true;
            }
        }
    }
}
