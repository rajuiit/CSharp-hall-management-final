using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hall_Management_System.User
{
    public partial class deleteUserForm : Form
    {
        Basic.information_load bi = new Basic.information_load();
        Database.DBConnect db = new Database.DBConnect();
        List<string> infoString = new List<string>();
        public deleteUserForm()
        {
            InitializeComponent();
        }

        private void deleteUserForm_Load(object sender, EventArgs e)
        {
            bi.load(userNameCB, "SELECT `username` FROM `user`");
        }

        private void userNameCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            infoString = db.multi_select("SELECT `user_id`, `username`, `name`, `type` FROM `user` WHERE `username`= '"+userNameCB.SelectedItem+"'");
            infoTB.Text = "User ID: "+infoString[0]+"\nUsername: "+infoString[1]+"\n Name: "+infoString[2]+"\n Type: "+infoString[3];
        }

        private void deleteB_Click(object sender, EventArgs e)
        {
            db.Delete("DELETE FROM `user` WHERE `user`.`user_id` = "+infoString[0]+"");
        }

       

        
    }
}
