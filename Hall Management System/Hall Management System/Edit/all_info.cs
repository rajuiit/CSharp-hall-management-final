using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hall_Management_System.Edit
{
    public partial class all_info : Form
    {
        Basic.information_load bs = new Basic.information_load();
        Basic.excel_load el = new Basic.excel_load();
        public all_info()
        {
            InitializeComponent();
        }

        private void all_info_Load(object sender, EventArgs e)
        {
            bs.datagridview_load("Select hall_id as 'Hall ID', hall_name as 'Hall Name',type as 'Type' From hall_info", hallDGV);

            bs.datagridview_load("Select faculty_id as 'Faculty ID', faculty_name as 'Faculty Name' from faculty_info", facultyDGV);

            bs.datagridview_load("Select dept_info.dept_id as 'Department ID', dept_info.dept_name as 'Department Name', faculty_info.faculty_name as 'Faculty Name' from dept_info,faculty_info where dept_info.faculty_id = faculty_info.faculty_id", deptDGV);

            bs.datagridview_load("Select qouta_id as 'Qouta ID', qouta_name as 'Qouta Name' from qouta", qoutaDGV);
            
        }

        private void saveExcelB_Click(object sender, EventArgs e)
        {
            if(infoTC.SelectedIndex==0)
              el.saveAsExcel(hallDGV);
            if (infoTC.SelectedIndex == 1)
                el.saveAsExcel(facultyDGV);
            if (infoTC.SelectedIndex == 2)
                el.saveAsExcel(deptDGV);
            if (infoTC.SelectedIndex == 3)
                el.saveAsExcel(qoutaDGV);
        }

        private void hallDGV_MouseDown(object sender, MouseEventArgs e)
        {
          
        }

        private void hallDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void hallDGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.ContextMenuStrip = popupmenu;
                popupmenu.Show(e.Location);
            }
        }
    }
}
