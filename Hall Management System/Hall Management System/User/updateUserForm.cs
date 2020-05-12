using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hall_Management_System.User
{
    public partial class updateUserForm : Form
    {
        Database.DBConnect dbo = new Database.DBConnect();
        MySqlConnection con = Database.DBConnect.getconnectionstring();
        private int uid;
        public updateUserForm()
        {
            InitializeComponent();
        }

        private void cancelB_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void updateUserForm_Load(object sender, EventArgs e)
        {
            List<string> li = new List<string>();

            li = dbo.multi_select("SELECT `username`, `password`, `name`, `type` from user where user_id=" + uid);
            usernameTB.Text = li[0];
            usernameL.Text = li[0];
            passwordL.Text = li[1];
            nameL.Text = li[2];
            typeL.Text = li[3];

        }

        private void updateB_Click(object sender, EventArgs e)
        {
            string error = " ";
            if (newUsernameTB.Text == "" || newPasswordTB.Text == "" || newNameTB.Text == "" )
            {
                if (newUsernameTB.Text == "")
                    error = error + "\n* New User Name";
                if (newPasswordTB.Text == "")
                    error = error + "\n* New Password";
                if (newNameTB.Text == "")
                    error = error + "\n* New Name";
                
                MessageBox.Show("Please input your" + error, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {


                try
                {
                    

                        //UPDATE `hallmanagement`.`user` SET `username` = 'raju', `password` = 'raju', `name` = 'Md. Mahfujur Rahman', `type` = 'Staff' WHERE `user`.`user_id` = 24;
                        String sql = "UPDATE `user` SET `username` = '" + newUsernameTB.Text + "', `password` = '" + newPasswordTB.Text + "', `name` = '" + newNameTB.Text + "', `type` = '" + typeCB.SelectedItem + "' WHERE `user`.`user_id` = " + uid + "";
                        dbo.Update(sql);
                        this.Close();

                     
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Message: " + ee.Message);
                    return;
                }




            }
        }



        internal void intial(int u_id)
        {
            uid = u_id;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
