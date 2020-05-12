using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hall_Management_System.Settings
{
    public partial class basic_settings : Form
    {
        string path = Environment.CurrentDirectory;
        string[] images;
        MySqlConnection con = Database.DBConnect.getconnectionstring();
        Basic.information_load bi = new Basic.information_load();
        Database.DBConnect df = new Database.DBConnect();
        Object obj = new Object();
        public basic_settings()
        {
            InitializeComponent();
        }

        private void loginpageBrowseB_Click(object sender, EventArgs e)
        {
            bi.upload_imagetoPB(loginPagePB);

            try
            {
                System.IO.File.Copy(loginPagePB.ImageLocation, path + loginPagePB.ImageLocation.Substring(loginPagePB.ImageLocation.LastIndexOf("\\")), true);

            }
            catch (Exception ex) {
                MessageBox.Show("Error in File Copy. Error is" + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            basic_settings_Load(obj, EventArgs.Empty);


        }

       

        private void basic_settings_Load(object sender, EventArgs e)
        {
            animation_folder_load();
            report_header_image_load();

        }

        private void report_header_image_load()
        {
            try
            {
                string report_header_path;
                report_header_path = Path.Combine(path, "need");
                bool IsExists = System.IO.Directory.Exists(report_header_path);
                if (!IsExists) System.IO.Directory.CreateDirectory(report_header_path);

                report_header_path = Path.Combine(report_header_path, "header.jpg");
                
                    reportHeaderPB.ImageLocation =report_header_path ;
                    MessageBox.Show(report_header_path);
                
            }
            catch (Exception ew)
            {
                MessageBox.Show("Error in image loading. Error is " + ew.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void animation_folder_load()
        {
            
           string animation_folder_path = Path.Combine(path, "animation");
            bool IsExists = System.IO.Directory.Exists(animation_folder_path);
            if (!IsExists) System.IO.Directory.CreateDirectory(animation_folder_path);
            images = System.IO.Directory.GetFiles(animation_folder_path);
           int i=0;
         while(i < images.Length){
             anim_pictureLB.Items.Add(i.ToString() + " " + images[i].Substring(images[i].LastIndexOf("\\")));
             //anim_pictureLB.Items.Add(images[i]);
             
               i++;
           }
            
        }

        private void anim_pictureLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (anim_pictureLB.SelectedIndex > -1)
                {
                    loginPagePB.ImageLocation = images[anim_pictureLB.SelectedIndex];
                }
                else
                {
                    MessageBox.Show("Please Select A picture from list.");
                }
            }
            catch (Exception ew) {
                MessageBox.Show("Error in image loading. Error is " + ew.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteTSSM_Click(object sender, EventArgs e)
        {
            try
            {
                if (anim_pictureLB.SelectedIndex > -1)
                {

                    System.IO.File.Delete(images[anim_pictureLB.SelectedIndex]);

                }
            }
            catch (Exception ew) {
                MessageBox.Show("Error in file deletion. Error is " + ew.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            basic_settings_Load(obj, EventArgs.Empty);
        }

        private void reportheaderimageBrowseB_Click(object sender, EventArgs e)
        {

        }

       
    }
}
