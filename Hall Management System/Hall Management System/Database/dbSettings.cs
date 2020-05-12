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



namespace Hall_Management_System.Database
{
    public partial class dbSettings : Form
    {
        public dbSettings()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void submitB_Click(object sender, EventArgs e)
        {
            if (Basic.validation.check_empty(masterPasswordTF) == "no")return;
            if (masterPasswordTF.Text == "proshanti")
            {
                groupBox2.Enabled = true;
                updateB.Enabled = true;
            }
            else {
                MessageBox.Show("Permission Denied. Master Password is wrong. Contact your Administrator.");
                return;
            }
        }

        private void dbSettings_Load(object sender, EventArgs e)
        {
            
            //param : title,server,user,database,password
            dbServerTitleTF.Text = Database.DBConnect.load_DB_info("title");
            dbServerAddressTF.Text = Database.DBConnect.load_DB_info("server");
            dbUsernameTF.Text = Database.DBConnect.load_DB_info("user"); ;
            dbNameTF.Text= Database.DBConnect.load_DB_info("database");
            dbPasswordTF.Text = Database.DBConnect.load_DB_info("password");
           
        }

        private void updateB_Click(object sender, EventArgs e)
        {
            try
            {
                XDocument doc =
                          new XDocument(
                            new XElement("DataBaseServers",
                              new XElement("DataBaseServer", new XAttribute("id", "1"), new XAttribute("title", dbServerTitleTF.Text), new XAttribute("address", dbServerAddressTF.Text)),
                              new XElement("DataBases",
                                  new XElement("Database", new XAttribute("id", "1"), new XAttribute("name", dbNameTF.Text), new XAttribute("userid", dbUsernameTF.Text), new XAttribute("password", dbPasswordTF.Text))
                              )));
                string installationPath = Environment.CurrentDirectory;
                var currentDirectory = Path.Combine(installationPath, "DataSource");
                bool IsExists = System.IO.Directory.Exists(currentDirectory);
                if (!IsExists) System.IO.Directory.CreateDirectory(currentDirectory);


                var fileName = Path.Combine(currentDirectory, "DatabaseServers.xml");
                doc.Save(fileName);
                MessageBox.Show("You have successfully set database settings as administrator.");
            }
            catch (Exception ex) {
                MessageBox.Show("Error Occured:"+ex.Message);
            }
        }

        private void cancelB_Click(object sender, EventArgs e)
        {
            this.Visible=false;
            Form1 ff = new Form1();
            ff.Visible = true;
        }

        private void loginB_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 ff = new Form1();
            ff.Visible = true;
        }
    }
}
