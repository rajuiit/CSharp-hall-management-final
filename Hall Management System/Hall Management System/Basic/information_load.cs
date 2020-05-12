using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data;
using System.IO;
using System.Drawing;

namespace Hall_Management_System.Basic
{
    class information_load
    {
        MySqlConnection con = Database.DBConnect.getconnectionstring();
        int returnid;
        string returnvalue;


        public static void app_info(ToolStripStatusLabel tssl) {

            info ii = new info();
            tssl.Text = "Project Name: " + ii.AssemblyTitle + ". Developed By: " + ii.AssemblyCompany + ". Copyright: " + ii.AssemblyCopyright+ ". Version: "+ii.AssemblyVersion;
        }
        public void tool_load(string toolName)
        {
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = toolName;
            p.Start();
            p.Close();



        }
        public void log(string logText)
        {
            try
            {
                string fileName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "hall.log";
                using (System.IO.StreamWriter writer = new System.IO.StreamWriter(fileName, true))
                {

                    writer.Write(logText);

                }

            }

            catch (Exception exp)
            {

                MessageBox.Show("Error:" + exp.Message);

            }

        }
        public void load(ComboBox s, string tableName, string sortColumn)
        {
            String query = "SELECT distinct(" + sortColumn + ") FROM " + tableName + " order by " + sortColumn + " ASC ";
            load(s, query, "Error occured .Message -", MessageBoxButtons.OKCancel);
            
        }

        public void load(ComboBox s, string query)
        {
            load(s, query, "Error occured .Message - ", MessageBoxButtons.OK);

        }
        public void load(ComboBox s, string query, string error_message, MessageBoxButtons mbb)
        {


            try
            {
                s.Items.Clear();
                con.Open();
                //SELECT DISTINCT (`session`)FROM `student_info`ORDER BY `student_info`.`session` ASC
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                int i = 0;
                while (reader.Read())
                {
                    s.Items.Add(reader.GetString(0));
                    i++;
                }
                if (i == 0) {
                    s.Items.Add("Empty");
                }
                reader.Close();
                con.Close();
                s.SelectedIndex = 0;

            }
            catch (Exception ew)
            {
                MessageBox.Show(error_message + ew.Message, "Error", mbb, MessageBoxIcon.Error);
            }
        }

        public void datagridview_load(String query, DataGridView dgv)
        {

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                DataTable dataTable = new DataTable();
                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dataTable);
                }
                dgv.MultiSelect = false;
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv.DataSource = dataTable;
                dgv.DataMember = dataTable.TableName;
                dgv.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("An error occured {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                    con.Close();

            }
        }

        public int get_id(string query)
        {


            try
            {

                con.Open();
                //SELECT DISTINCT (`session`)FROM `student_info`ORDER BY `student_info`.`session` ASC
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    returnid = Convert.ToInt32(reader.GetString(0));
                }
                reader.Close();
                con.Close();
                return returnid;

                
            }
            catch (Exception ew)
            {

                MessageBox.Show("Error occured .Message - " + ew.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return returnid;
            }
        }
        public string get_value(string query)
        {
            

            try
            {

                con.Open();
                //SELECT DISTINCT (`session`)FROM `student_info`ORDER BY `student_info`.`session` ASC
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    returnvalue = reader.GetString(0);
                }
                reader.Close();

                con.Close();
                return returnvalue;

                
            }
            catch (Exception ew)
            {

                MessageBox.Show("Error occured .Message - " + ew.Message, "This is an Error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return returnvalue;
            }
        }

        internal void upload_imagetoPB(PictureBox PB) {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            
            openFileDialog1.Filter = "*.jpg|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PB.ImageLocation = openFileDialog1.FileName;
                int picwidth = PB.Width;
                int picheight = PB.Height;
                      
            }



        }
        internal void image_save(String location, PictureBox PB)
        {
            string path = Environment.CurrentDirectory;
            path = Path.Combine(path, "need");
            bool IsExists = System.IO.Directory.Exists(path);
            if (!IsExists) System.IO.Directory.CreateDirectory(path);



            string imagepath = PB.ImageLocation;
            string oldpicname = imagepath.Substring(imagepath.LastIndexOf('\\'));
            
            string picname = "header." + oldpicname.Substring(oldpicname.LastIndexOf("."));

            Bitmap imgImage = new Bitmap(PB.Image); //Create an object of Bitmap class/
            string type = imgImage.GetPropertyItem(1).ToString();
            
            //MessageBox.Show(type);
            imgImage.Save(path  + picname);
        }
        internal void image_load(string mobile, PictureBox studentPB)
        {
            //string path = Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("bin"));
            try
            {
             
                string path = Application.StartupPath;
                //studentPB.ImageLocation = path+ "\\"  + mobileTB.Text + ".jpg";

                studentPB.ImageLocation = path + "\\images\\" + mobile + ".jpg";
                // roomTB.Text = path + mobileTB.Text;
            }
            catch (Exception es)
            {
                MessageBox.Show("No Image Found. Error: " + es.Message, "Error: No Image.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
