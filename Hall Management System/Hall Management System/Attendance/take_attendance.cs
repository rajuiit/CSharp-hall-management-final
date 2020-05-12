using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace Hall_Management_System.Attendance
{
    
    public partial class take_attendance : Form
    {
        private int status;

        private String prev_countdown = "Attendance Countdown is not started.";
        private String in_countdown = "Attendance Countdown is on going.";
        private String after_countdown = "Attendance Countdown was end.";
        Database.DBConnect db = new Database.DBConnect();
        Basic.information_load il = new Basic.information_load();
        public take_attendance()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            try
            {
                DateTime start = DateTime.Parse(start_countdown_L.Text);
                DateTime end = DateTime.Parse(end_countdown_L.Text);


                DateTime now = DateTime.Now;
                if (now <= start)
                {
                    status_countdown_L.Text = prev_countdown;
                    status = 0;
                    remaining_time_L.Text = secondsToTime(start - now);
                    elapsed_time_L.Text = "";
                }
                else if (now > start && now < end)
                {
                    status_countdown_L.Text = in_countdown;
                    status = 1;
                    remaining_time_L.Text = secondsToTime(end - now);
                    elapsed_time_L.Text = secondsToTime(now - start);
                }
                else
                {
                    status_countdown_L.Text = after_countdown;
                    status = 2;
                    remaining_time_L.Text = "";
                    elapsed_time_L.Text = secondsToTime(now - end);

                }
            }
            catch (Exception ex)
            {
                timer1.Enabled = false;
                MessageBox.Show("Error : " + ex.Message);

            }
        }

        private String secondsToTime(TimeSpan t) {
            int days = t.Days;
            int hours = t.Hours;
            int minutes = t.Minutes;
            int seconds = t.Seconds;
            String answer="";
            if (days != 0) {
                answer += days+"d ";
            }
            if (hours != 0)
            {
                answer += hours + "h ";
            }
            if (minutes != 0)
            {
                answer += minutes + "m ";
            }

            answer += seconds + "s.";
            return answer;
        
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void take_attendance_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    string path = Path.Combine(Environment.CurrentDirectory, "DataSource\\attendance.xml");
            //    XDocument xdoc = XDocument.Load(path);

            //    XElement attendanceResult = xdoc.Element("attendance");

            //    var settingsResult = (from result in attendanceResult.Elements("settings")
            //                          select new
            //                          {
            //                              id = Convert.ToInt32(result.Attribute("id").Value),
            //                              start = result.Attribute("start").Value,
            //                              end = result.Attribute("end").Value
            //                          }).ToList()[0];
            //    start_countdown_L.Text = settingsResult.start;
            //    end_countdown_L.Text = settingsResult.end;

            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show("Error : " + ex.Message);
            //}
            start_countdown_L.Text = il.get_value("SELECT  `from_date` FROM `att_set` ORDER BY `att_set`.`date_time` DESC LIMIT 0,1");
            end_countdown_L.Text = il.get_value("SELECT  `to_date` FROM `att_set` ORDER BY `att_set`.`date_time` DESC LIMIT 0,1");


        }

        private void searchB_Click(object sender, EventArgs e)
        {
            Student.search aa = new Student.search();
            aa.searchButtonWork(searchTB, anySearchRB, idSearchRB, nameSearchRB, rollSearchRB,registrationSearchRB,roomSearchRB, studentDGV);
        }

        private void presentB_Click(object sender, EventArgs e)
        {
            if (status != 1) {
                if (status == 0)
                {
                    MessageBox.Show(prev_countdown);
                }
                else {
                    MessageBox.Show(after_countdown);
                }
                return;
            }
            if (studentIdTB.Text == "") {
                MessageBox.Show("search and Select a student from the list.");
                return;
            }
            
            if (check_duplicate(studentIdTB) == "no") return;
           
            db.Insert("INSERT INTO `attendance` (`att_id`, `hall_std_id`, `date_time`) VALUES (NULL, '"+studentIdTB.Text+"', CURRENT_TIMESTAMP);");
        }
        
        private string check_duplicate(TextBox studentIdTB)
        {
            DateTime start = DateTime.Parse(start_countdown_L.Text);
            DateTime end = DateTime.Parse(end_countdown_L.Text);
            String startString = Basic.time.todbTime(start);
            String endString = Basic.time.todbTime(end);
            string query = "SELECT count(*) as count  FROM `attendance` WHERE `hall_std_id` = "+studentIdTB.Text+" AND `date_time` >= '"+startString+"' and `date_time` <= '"+endString+"'";
            
            int count = Convert.ToInt32( il.get_value(query));
           // MessageBox.Show(start.ToString() + query+count);
            if (count == 0) { return "yes"; }
            else 
            { 
                MessageBox.Show("You gave 1 time attendance. why are you trying to give another attendance? do not do this."); 
                return "no";
            }
        }

        private void studentDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
          int column = 0;
          if (row > -1)
          {
              string sid = studentDGV[column, row].Value.ToString();
              studentIdTB.Text = sid;
          }
        }
    }
}
