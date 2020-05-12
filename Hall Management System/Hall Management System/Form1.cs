using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Hall_Management_System.Properties;
using Hall_Management_System.Basic;
using System.IO;

namespace Hall_Management_System
{
    public partial class Form1 : Form
    {
        information_load il = new information_load();
        MySqlConnection con = Database.DBConnect.getconnectionstring();
        string path = Environment.CurrentDirectory;
        string[] images;
        int i=0;
        form_method fm = new form_method();

        public Form1()
        {
        
            InitializeComponent();
           
        }

        private void hallmanagementtray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        
        

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.Show();

        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            if (Basic.validation.check_empty(userNameTB) == "no") return;
            if (Basic.validation.check_empty(userNameTB) == "no") return;
            try
            {
                con.Open();
                String sql = "SELECT * FROM user where username ='" + userNameTB.Text + "' and password='" + passwordTB.Text + "' ";
                MySqlCommand command = new MySqlCommand(sql, con);
                MySqlDataReader reader = command.ExecuteReader();


                if (reader.Read())
                {
                    this.Visible = false;
                    mainui mm = new mainui();
                    // MDIMain mm = new MDIMain();
                    mm.intial(reader.GetInt32("user_id"));
                    mm.Show();
                }
                else
                {
                    MessageBox.Show("Username or password invalid");
                }
                reader.Close();  //close Data Reader
                //close Connection
                con.Close();
            }
            catch (Exception eee) {
                MessageBox.Show("Error occured:"+eee.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            fm.closeForm(e);
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
           
            path = Path.Combine(path, "animation");
            bool IsExists = System.IO.Directory.Exists(path);
            if (!IsExists) System.IO.Directory.CreateDirectory(path);
            images = System.IO.Directory.GetFiles(path);
            try
            {
                pictureBox1.ImageLocation = images[0];
                timer1.Enabled = true;
            }
            catch {
                pictureBox1.Image = pictureBox1.ErrorImage;
                timer1.Enabled = false;
            }
            Basic.information_load.app_info(tssl);
        }

        private void databaseSettingsToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    this.Visible = false;
                    Database.dbSettings ds = new Database.dbSettings();
                    ds.Visible = true;
                }

        private void timer1_Tick(object sender, EventArgs e)
        {

           // MessageBox.Show("adasd");
            try
            {
                pictureBox1.ImageLocation = images[i++];
                
            }
            catch {
                i = 0;
                pictureBox1.ImageLocation = images[0];
            }
        }
        
    }
}
