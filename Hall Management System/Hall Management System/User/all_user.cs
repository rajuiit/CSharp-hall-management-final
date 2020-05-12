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
    public partial class all_user : Form
    {
        Basic.information_load il = new Basic.information_load();
        Basic.excel_load el = new Basic.excel_load();
        public all_user()
        {
            InitializeComponent();
        }

       

        private void all_user_Load(object sender, EventArgs e)
        {

            il.datagridview_load("Select user_id as 'User ID', username as 'User Name', name as 'Name', added_by as 'Added By' from user", userInfoDGV);
        }

        private void saveExcelB_Click(object sender, EventArgs e)
        {
            el.saveAsExcel(userInfoDGV);
        }

        private void userInfoDGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

       
    }
}
