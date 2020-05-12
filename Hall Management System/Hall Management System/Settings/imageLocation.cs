using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Hall_Management_System.Settings
{
    public partial class imageLocation : Form
    {
        Database.DBConnect df = new Database.DBConnect();
        public imageLocation()
        {
            InitializeComponent();
           // textBox1.Text = Application.StartupPath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = this.folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                // start of update command run
                //UPDATE `hallmanagement`.`settings` SET `value` = 'D:\\' WHERE `settings`.`name` = 'imagelocation'
                string updateQuery = "update settings set value= '"+textBox1.Text+"' where name = imagelocation";
                df.Update(updateQuery);
                //end of update command runn

                

            }
            catch (Exception ee)
            {
                MessageBox.Show("Error Occured. Message - " + ee.Message, "Error: Please Select a Folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
    }
}
