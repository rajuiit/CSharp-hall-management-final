using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hall_Management_System.Remark
{
    public partial class remark_info : Form
    {
        Basic.information_load il = new Basic.information_load();

        object s = new object();
        Database.DBConnect db = new Database.DBConnect();
        public remark_info()
        {
            InitializeComponent();
        }

        private void searchB_Click(object sender, EventArgs e)
        {
            Student.search aa = new Student.search();
            aa.searchButtonWork(searchTB, anySearchRB, idSearchRB, nameSearchRB, rollSearchRB, registrationSearchRB, roomSearchRB, studentDGV);
        }

        private void studentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int column = 0;
            if (row > -1)
            {
                string sid = studentDGV[column, row].Value.ToString();
                hall_std_IDL.Text = sid;
                String query = "SELECT `remark_id`, `remarks`, `author`, `hall_std_id`, `date_time` FROM `remark` WHERE `hall_std_id` = " + sid;
                il.datagridview_load(query, remarkDGV);
            }
        }

        private void addStudentB_Click(object sender, EventArgs e)
        {
            if (Basic.validation.check_empty(hall_std_IDL.Text) == "no") return;
            if (Basic.validation.check_empty(remarkTB) == "no") return;
            if (Basic.validation.check_empty(authorTB) == "no") return;

            String add_query = "INSERT INTO `remark` (`remark_id`, `remarks`, `author`, `hall_std_id`, `date_time`) VALUES (NULL, '" + remarkTB.Text + "', '" + authorTB.Text + "', '" + hall_std_IDL.Text + "', CURRENT_TIMESTAMP)";
            db.Insert(add_query);
        }

        private void remarkDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int column = 0;
            if (row > -1)
            {
                string rid = remarkDGV[column, row].Value.ToString();
                string query = "SELECT `remark_id` , `remarks` , `author` , `hall_std_id` , `date_time` FROM `remark` WHERE `remark_id` =" + rid;
                List<string> r = new List<string>();
                r = db.multi_select(query);
                remarkIDL.Text = r[0];
                remarkTB.Text = r[1];
                authorTB.Text = r[2];
                hall_std_IDL.Text = r[3];

            }
        }

        private void updateStudentB_Click(object sender, EventArgs e)
        {
            if (Basic.validation.check_empty(remarkIDL.Text) == "no") return;

            if (Basic.validation.check_empty(hall_std_IDL.Text) == "no") return;
            if (Basic.validation.check_empty(remarkTB) == "no") return;
            if (Basic.validation.check_empty(authorTB) == "no") return;

            string update_query = "UPDATE `remark` SET `remarks` = '" + remarkTB.Text + "', `author` = '" + authorTB.Text + "', `hall_std_id` = '" + hall_std_IDL.Text + "' WHERE `remark`.`remark_id` =" + remarkIDL.Text;
            db.Update(update_query);
        }

        private void deleteStudentB_Click(object sender, EventArgs e)
        {
            if (Basic.validation.check_empty(remarkIDL.Text) == "no") return;

            db.Delete("DELETE FROM `remark` WHERE `remark`.`remark_id` = " + remarkIDL.Text);
        }

        private void addRemarkRB_CheckedChanged(object sender, EventArgs e)
        {
            if (addRemarkRB.Checked)
            {
                empty_all();
                remarkIDL.Text = "It will be generate automatically.";
                //which group box will show or not
                remarkDGV.Enabled = false;
                informationAnnexGB.Enabled = true;
                addRemarkB.Enabled = true;
                updateRemarkB.Enabled = false;
                deleteRemarkB.Enabled = false;

            }
        }

        private void empty_all()
        {
            searchTB.Text = "";
            anySearchRB.Checked = true;
            searchB_Click(s, EventArgs.Empty);
            //column null
            remarkIDL.Text = "";
            hall_std_IDL.Text = "";
            remarkTB.Text = "";
            authorTB.Text = "" ;

        }

        private void searchRemarkToUpdateRB_CheckedChanged(object sender, EventArgs e)
        {
            if (searchRemarkToUpdateRB.Checked)
            {
                empty_all();
                
                //which group box will show or not
                remarkDGV.Enabled = true;
                informationAnnexGB.Enabled = true;
                addRemarkB.Enabled = false;
                updateRemarkB.Enabled = true;
                deleteRemarkB.Enabled = false;

            }
        }

        private void searchRemarkToDeleteRB_CheckedChanged(object sender, EventArgs e)
        {
            if (searchRemarkToDeleteRB.Checked)
            {
                empty_all();

                //which group box will show or not
                remarkDGV.Enabled = true;
                informationAnnexGB.Enabled = true;
                addRemarkB.Enabled = false;
                updateRemarkB.Enabled = false;
                deleteRemarkB.Enabled = true;

            }
        }
    }
}
