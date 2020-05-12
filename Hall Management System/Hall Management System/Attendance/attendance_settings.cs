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
    public partial class attendance_settings : Form
    {
        Database.DBConnect db = new Database.DBConnect();
        public attendance_settings()
        {
            InitializeComponent();
        }

        private void attendance_settings_Load(object sender, EventArgs e)
        {
            
        }

        private void saveB_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    XDocument doc =
            //              new XDocument(
            //                new XElement("attendance",
            //                  new XElement("settings", new XAttribute("id", "1"), new XAttribute("start",startDTP.Value.ToString()), new XAttribute("end", endDTP.Value.ToString()))
            //                  ));
            //    string installationPath = Environment.CurrentDirectory;
            //    var currentDirectory = Path.Combine(installationPath, "DataSource");
            //    bool IsExists = System.IO.Directory.Exists(currentDirectory);
            //    if (!IsExists) System.IO.Directory.CreateDirectory(currentDirectory);


            //    var fileName = Path.Combine(currentDirectory, "attendance.xml");
            //    doc.Save(fileName);
            //    MessageBox.Show("You have successfully set Attendance settings as administrator.");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error Occured:" + ex.Message);
            //}
            string start = Basic.time.todbTime(startDTP.Value);
            string end = Basic.time.todbTime(endDTP.Value);

            db.Insert("INSERT INTO `att_set` (`att_set_id`, `from_date`, `to_date`, `date_time`) VALUES (NULL, '"+start+"', '"+end+"', CURRENT_TIMESTAMP);");

        }
        private void start() {
            
        
        }

       

        private void endDTP_ValueChanged(object sender, EventArgs e)
        {
            Basic.validation.check_date(startDTP, endDTP, 1);
        }

        private void startDTP_ValueChanged(object sender, EventArgs e)
        {
            Basic.validation.check_date(startDTP, endDTP, 0);
        }
    }
}
