using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.Reporting.WinForms;

namespace Hall_Management_System.Student
{
    public partial class single_student_report : Form
    {
        MySqlConnection con = Database.DBConnect.getconnectionstring();
        
       string columnName;
       public string radio;
       public string text;
       public bool button = false;

        public single_student_report()
        {
            InitializeComponent();
        }

        private void search_student_Load(object sender, EventArgs e)
        {

        }

         

        private void createReportB_Click(object sender, EventArgs e)
        {



            String[] info_opt = check_info_opt();
            String start_date = Basic.time.todbTime(fromDTP.Value);
            String end_date = Basic.time.todbTime(toDTP.Value);
            int remark = check_remark();
            

            if (Basic.validation.check_empty(hallIDTB) == "no") return;

            Report.single_student_reportpdf sf = new Report.single_student_reportpdf();
            sf.single_PDF(int.Parse( hallIDTB.Text),info_opt,start_date,end_date,remark);

        }

        private int check_remark()
        {
            RadioButton[] radio = { last3remarkRB,last5remarkRB,last10remarkRB,allremarkRB};
            int[] value = {3,5,10,100 };
            int val= 3;
            for(int i=0;i<radio.Length;i++){
                if (radio[i].Checked) {
                    val = value[i];
                }
            
            }
            return val;
        }

        private string[] check_info_opt()
        {
            CheckBox[] checkbox = {basicChB,contactChB,academicChB,attendanceChB,remarkChB };
            List<string> opt = new List<string>();
            foreach (CheckBox value in checkbox)
            {
                if (value.Checked)
                {
                    opt.Add("yes");
                }
                else {
                    opt.Add("no");
                }


            }
            string[] opt_info = opt.ToArray();
            return opt_info;
        }

        private void searchB_Click(object sender, EventArgs e)
        {
            Student.search aa = new Student.search();
            aa.searchButtonWork(searchTB, anySearchRB, idSearchRB, nameSearchRB, rollSearchRB, registrationSearchRB, roomSearchRB, studentDGV);
        }

        private void studentDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
          int column = 0;
          if (row > -1)
          {
              string sid = studentDGV[column, row].Value.ToString();
              hallIDTB.Text = sid;
          }
        }

        private void attendanceChB_CheckedChanged(object sender, EventArgs e)
        {
            if (attendanceChB.Checked)
            {
                attendance_option_GB.Visible = true;
            }
            else {
                attendance_option_GB.Visible = false;
            }
        }

        private void remarkChB_CheckedChanged(object sender, EventArgs e)
        {
            if (remarkChB.Checked)
            {
                remark_option_GB.Visible = true;
            }
            else
            {
                remark_option_GB.Visible = false;
            }
        }

        private void CustomattendanceRB_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomattendanceRB.Checked)
            {
                
                customAttendaneP.Visible = true;
            }
        }

        private void lastMonthRB_CheckedChanged(object sender, EventArgs e)
        {
            if (lastMonthRB.Checked) {
                customAttendaneP.Visible = true;
                fromDTP.Value = DateTime.Now.AddMonths(-1); 
                toDTP.Value = DateTime.Now;
            }
        }

        private void last6MonthRB_CheckedChanged(object sender, EventArgs e)
        {
            if (last6MonthRB.Checked)
            {
                customAttendaneP.Visible = true;
                fromDTP.Value = DateTime.Now.AddMonths(-6); 
                toDTP.Value = DateTime.Now;
            }
        }

        private void last3MonthRB_CheckedChanged(object sender, EventArgs e)
        {
            if (last3MonthRB.Checked)
            {
                customAttendaneP.Visible = true;
                fromDTP.Value = DateTime.Now.AddMonths(-3);
                toDTP.Value = DateTime.Now;
            }
        }

        private void toDTP_ValueChanged(object sender, EventArgs e)
        {
            Basic.validation.check_date(fromDTP, toDTP,1);
        }

        

        private void fromDTP_ValueChanged(object sender, EventArgs e)
        {
            Basic.validation.check_date(fromDTP, toDTP,0);
        }

        private void defaultWatermarkRB_CheckedChanged(object sender, EventArgs e)
        {
            if (defaultWatermarkRB.Checked) {
                watermarkTB.Visible = false;
                watermarkTB.Text = "CONFIDENTIAL";
            }
        }

        private void noWatermarkRB_CheckedChanged(object sender, EventArgs e)
        {
            if (noWatermarkRB.Checked)
            {
                watermarkTB.Visible = false;
                watermarkTB.Text = "";
            }
        }

        private void customwatermarkRB_CheckedChanged(object sender, EventArgs e)
        {
            if (defaultWatermarkRB.Checked)
            {
                watermarkTB.Visible = true;
                watermarkTB.Text = "DO NOT COPY";
            }
        }
    }
}
