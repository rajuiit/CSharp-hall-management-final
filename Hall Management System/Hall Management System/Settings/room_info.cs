using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hall_Management_System.Settings
{
    public partial class room_info : Form
    {
        object s = new object();
        Database.DBConnect df = new Database.DBConnect();
        MySqlConnection con = Database.DBConnect.getconnectionstring();
        Basic.information_load bi = new Basic.information_load();
        public room_info()
        {
            InitializeComponent();
        }

       

        

        

        

        
        private void addRoomB_Click(object sender, EventArgs e)
        {
            if (Basic.validation.check_empty(roomNoTB) == "no") return;
            if (Basic.validation.check_empty(capacityTB) == "no") return;
            string hallid = bi.get_value("SELECT hall_id from hall_info where hall_name='"+hall_name_CB.SelectedItem+"'");
            string insertQuery = "INSERT INTO `seat` (`room_id`, `room`, `capacity`, `hall_id`) VALUES (NULL, '"+roomNoTB.Text+"', '"+capacityTB.Text+"', '"+hallid+"')";
            df.Insert(insertQuery);
            

        }

        private void deleteRoomB_Click(object sender, EventArgs e)
        {

            if (Basic.validation.check_empty(roomidL.Text) == "no") return;
            string deleteQuery = "DELETE FROM `seat` WHERE `seat`.`room_id` = "+roomidL.Text+"";
                df.Delete(deleteQuery);
            
        }

        private void updateRoomB_Click(object sender, EventArgs e)
        {
            if (Basic.validation.check_empty(roomidL.Text) == "no") return;
            if (Basic.validation.check_empty(roomNoTB) == "no") return;
            if (Basic.validation.check_empty(capacityTB) == "no") return;
            string hallid = bi.get_value("SELECT hall_id from hall_info where hall_name='" + hall_name_CB.SelectedItem + "'");
            
                string updateQuery = "UPDATE `seat` SET `room` = '"+roomNoTB.Text+"',`capacity` = '"+capacityTB.Text+"',`hall_id` = '"+hallid+"' WHERE `seat`.`room_id` ="+roomidL.Text+"";
                df.Update(updateQuery);
                //end of update command runn

            
            


        }

        

        private void searchRoomToUpdateRB_CheckedChanged_1(object sender, EventArgs e)
        {

            if (searchRoomToUpdateRB.Checked)
            {
                searchHallCB.Visible = true;
                searchRoomCB.Visible = true;
                groupBox2.Enabled = true;

                addRoomB.Enabled = false;
                updateRoomB.Enabled = true;
                deleteRoomB.Enabled = false;
                empty_all();
            }
        }

        private void searchRoomCB_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            search_room();
        }

        private void search_room()
        {
            
            try
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT `room_id`,`room`, `capacity`, `hall_name` FROM `seat`,hall_info WHERE seat.hall_id = hall_info.hall_id and  room='" + searchRoomCB.SelectedItem + "' and hall_name='"+searchHallCB.SelectedItem+"'", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    roomidL.Text = reader.GetString("room_id").ToString();
                    roomNoTB.Text = reader.GetString("room").ToString();
                    capacityTB.Text = reader.GetString("capacity").ToString();
                    hall_name_CB.SelectedItem = reader.GetString("hall_name");
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

        private void searchRoomToDeleteRB_CheckedChanged_1(object sender, EventArgs e)
        {
            if (searchRoomToDeleteRB.Checked)
            {
                searchHallCB.Visible = true;
                searchRoomCB.Visible = true;
                
                groupBox2.Enabled = false;
                addRoomB.Enabled = false;
                updateRoomB.Enabled = false;
                deleteRoomB.Enabled = true;
                empty_all();

            }
        }

        private void addRoomRB_CheckedChanged_1(object sender, EventArgs e)
        {
            if (addRoomRB.Checked)
            {
                searchHallCB.Visible = false;
                searchRoomCB.Visible = false;
                groupBox2.Enabled = true;
                addRoomB.Enabled = true;
                updateRoomB.Enabled = false;
                deleteRoomB.Enabled = false;


                empty_all();
                roomidL.Text = "It will be generate automatically.";
            }
        }
        private void empty_all() {
            String hall_query = "SELECT hall_name from hall_info";
            bi.load(searchHallCB, hall_query);
            String hallid = bi.get_value("SELECT hall_id from hall_info where hall_name='"+searchHallCB.SelectedItem+"' ");
            bi.load(searchRoomCB,"SELECT room from seat where hall_id="+hallid+"");

            roomidL.Text = "";
            roomNoTB.Text = "";
            capacityTB.Text = "";
            bi.load(hall_name_CB,hall_query);
        }

        private void searchHallCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            String hallid = bi.get_value("SELECT hall_id from hall_info where hall_name = '"+searchHallCB.SelectedItem+"'");
            bi.load(searchRoomCB, "SELECT room from seat where hall_id = "+hallid+"");
            search_room();
        }


        internal void intial(string action, string hall_name, string roomNo)
        {
            if (action == "update") {
                searchRoomToUpdateRB.Checked = true;
                searchRoomToUpdateRB_CheckedChanged_1(s, EventArgs.Empty);
                searchHallCB.SelectedItem = hall_name;
                searchRoomCB.SelectedItem = roomNo;
            }
            else if (action == "delete")
            {
                searchRoomToDeleteRB.Checked = true;
                searchRoomToDeleteRB_CheckedChanged_1(s, EventArgs.Empty);
                searchHallCB.SelectedItem = hall_name;
                searchRoomCB.SelectedItem = roomNo;
            }
            else {
                addRoomRB.Checked = true;
                addRoomRB_CheckedChanged_1(s, EventArgs.Empty);
            }
        }
    }
}
