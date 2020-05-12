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
    public partial class addUserForm : Form
    {
        Database.DBConnect dbo = new Database.DBConnect();
        
        public addUserForm()
        {
            InitializeComponent();
            typeCB.SelectedIndex = 0;
        }

        private void cancelB_Click(object sender, EventArgs e)
        {
            this.Visible = false;

        }

        private void createB_Click(object sender, EventArgs e)
        {
            if (Basic.validation.check_empty(userNameTB) == "no") return;
            if (Basic.validation.check_empty(passwordTB) == "no") return;
            if (Basic.validation.check_empty(nameTB) == "no") return;
            
            
            String sql = "INSERT INTO `user` (`user_id`, `username`, `password`, `name`, `type`) VALUES (NULL, '"+userNameTB.Text+"', '"+passwordTB.Text+"', '"+nameTB.Text+"', '"+typeCB.SelectedItem+"');";

            dbo.inupdel(sql, "New User has been created");

            
        }

        private void addUserForm_Load(object sender, EventArgs e)
        {

        }

        
    }
}
