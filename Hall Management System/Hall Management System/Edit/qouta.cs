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
    public partial class qouta : Form
    {
        Database.DBConnect df = new Database.DBConnect();
        MySqlConnection con = Database.DBConnect.getconnectionstring();
        Basic.information_load bi = new Basic.information_load();
        public qouta()
        {
            InitializeComponent();
        }


        private void addQoutaRB_CheckedChanged(object sender, EventArgs e)
        {
            if (addQoutaRB.Checked)
            {

                searchQoutaCB.Visible = false;
                groupBox2.Enabled = true;
                addQoutaB.Enabled = true;
                updateQoutaB.Enabled = false;
                deleteQoutaB.Enabled = false;

                qoutaIdL.Text = "ID will be automatically generated";
                qoutaNameTB.Text = "";


            }
        }

        private void searchQoutaToDeleteRB_CheckedChanged(object sender, EventArgs e)
        {
            if (searchQoutaToDeleteRB.Checked)
            {

                searchQoutaCB.Visible = true;
                bi.load(searchQoutaCB, "qouta", "qouta_name");

                groupBox2.Enabled = false;
                addQoutaB.Enabled = false;
                updateQoutaB.Enabled = false;
                deleteQoutaB.Enabled = false;

            }
            if (searchQoutaCB.Items.Count != 0) {
                groupBox2.Enabled = false;
                addQoutaB.Enabled = false;
                updateQoutaB.Enabled = false;
                deleteQoutaB.Enabled = true;

            }
        }

        private void searchQoutaToUpdateRB_CheckedChanged(object sender, EventArgs e)
        {
            if (searchQoutaToUpdateRB.Checked)
            {
                searchQoutaCB.Visible = true;
                bi.load(searchQoutaCB, "qouta", "qouta_name");
                groupBox2.Enabled = false;
                addQoutaB.Enabled = false;
                updateQoutaB.Enabled = true;
                deleteQoutaB.Enabled = false;
            }
            if (searchQoutaCB.Items.Count != 0) {
                groupBox2.Enabled = true;
                addQoutaB.Enabled = false;
                updateQoutaB.Enabled = true;
                deleteQoutaB.Enabled = false;
            }
        }

        private void searchQoutaCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM qouta where qouta_name='" + searchQoutaCB.SelectedItem.ToString() + "'", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    qoutaIdL.Text = reader.GetString(0).ToString();
                    qoutaNameTB.Text = reader.GetString(1).ToString();
                }
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured. Message - " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addQoutaB_Click(object sender, EventArgs e)
        {
            if (qoutaNameTB.Text == "")
            {
                MessageBox.Show("Please fill up the qouta Name. ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            try
            {
                //add query string and insert command run
                string insertQuery = "insert into qouta values (null,'" + qoutaNameTB.Text.ToString() + "')";

                df.Insert(insertQuery);
                // end add query string and insert command run

                qoutaNameTB.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured. Message - " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void deleteQoutaB_Click(object sender, EventArgs e)
        {
            try
            {
                //add delete query string and delete command run

                string deleteQuery = "delete from qouta where qouta_id='" + qoutaIdL.Text.ToString() + "' ";
                df.Delete(deleteQuery);
                // end of add delete query string and delete command run
                Basic.information_load bn = new Basic.information_load();
                bn.load(searchQoutaCB, "qouta", "qouta_name");
            }
            catch (Exception ee)
            {
                MessageBox.Show("Error Occured. Message - " + ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateQoutaB_Click(object sender, EventArgs e)
        {
            if (qoutaNameTB.Text == "")
            {
                MessageBox.Show("Please fill up the qouta Name. ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                qoutaNameTB.Focus();
                return;
            }
            try
            {
                // start of update command run
                string updateQuery = "update qouta set qouta_name='" + qoutaNameTB.Text.ToString() + "' where qouta_id='" + qoutaIdL.Text.ToString() + "'";
                df.Update(updateQuery);
                //end of update command runn

                Basic.information_load bn = new Basic.information_load();
                bn.load(searchQoutaCB, "qouta", "qouta_name");

            }
            catch (Exception ee)
            {
                MessageBox.Show("Error Occured. Message - " + ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void cancelB_Click(object sender, EventArgs e)
        {

        }





        internal void intial(string action, string qouta)
        {
            if (action == "update")
            {
                searchQoutaToUpdateRB.Checked = true;
                searchQoutaCB.SelectedItem = qouta;
            }
            else if (action == "delete")
            {
                searchQoutaToDeleteRB.Checked = true;
                searchQoutaCB.SelectedItem = qouta;
            }
            else
            {
                addQoutaRB.Checked = true;
            }
        }
    }
}
