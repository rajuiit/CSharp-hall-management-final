using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace Hall_Management_System.Database
{
    class DBConnect
    {
        List<string> a = new List<string>();
        MySqlConnection connection = getconnectionstring();
        
        public static MySqlConnection getconnectionstring() {
            //param : title,server,user,database,password
            String server = load_DB_info("server");
            String user = load_DB_info("user"); ;
            String database = load_DB_info("database");
            String password = load_DB_info("password");
            //server=localhost;User Id=root;database=hallmanagement;password=123
            String connectionString = "server=" + server + ";User Id=" + user + ";database=" + database + ";password=" + password + ""; 
        
        //public MySqlConnection connection = new MySqlConnection(Properties.Settings.Default.hallmanagementConnectionString);
        MySqlConnection con = new MySqlConnection(connectionString);
        
        return con;
        
        }
        public static String load_DB_info(String param){
        try{
            string path = Path.Combine(Environment.CurrentDirectory, "DataSource\\DatabaseServers.xml");
            XDocument xdoc = XDocument.Load(path);

            XElement dbServers = xdoc.Element("DataBaseServers");

            var dbServerDetailResult = (from dbServer in dbServers.Elements("DataBaseServer")
                                        select new
                                        {
                                            ServerId = Convert.ToInt32(dbServer.Attribute("id").Value),
                                            Name = dbServer.Attribute("title").Value,
                                            Address = dbServer.Attribute("address").Value
                                        }).ToList()[0];

            var dbDetailResult = (from dbDetail in dbServers.Elements("DataBases")
                                  from x in dbDetail.Elements("Database")
                                  select new
                                  {
                                      DbId = Convert.ToInt32(x.Attribute("id").Value),
                                      DbName = x.Attribute("name").Value,
                                      UserName = x.Attribute("userid").Value,
                                      PassWord = x.Attribute("password").Value
                                  }).ToList()[0];
           // MessageBox.Show(dbServerDetailResult.Name + dbServerDetailResult.Address + dbDetailResult.DbName + dbDetailResult.UserName + dbDetailResult.PassWord);
            //txtTitle.Text = dbServerDetailResult.Name;
            //txtAddress.Text = dbServerDetailResult.Address;
            //txtDBName.Text = dbDetailResult.DbName;
            //txtUserName.Text = dbDetailResult.UserName;
            //txtPassword.Text = dbDetailResult.PassWord;
            if (param.Equals("title")) { return dbServerDetailResult.Name; }
            if (param.Equals("server")) { return dbServerDetailResult.Address; }
            if (param.Equals("user")) { return dbDetailResult.UserName; }
            if (param.Equals("database")) { return dbDetailResult.DbName; }
            if (param.Equals("password")) { return dbDetailResult.PassWord; }
            return null;
        }
        catch (Exception ex)
        {

            MessageBox.Show("No DB Information."+ex.Message);
            return null;
        }
        
        }
        
        
        
        
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server. Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                    default:
                        MessageBox.Show("default:"+ex.ToString());
                        break;

                }
                return false;
            }
        }

        //Close connection
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public List<string>[] Select(string query_run, string columns)
        {
            string query = query_run;
            string[] cols = new string[10];
            int[] blank = new int[10];
            int b = 0;
            //Create a list to store the result
            List<string>[] list = new List<string>[10];
            for (int i = 0; i < 10; i++)
            {
                list[i] = new List<string>();
            }
            if (columns != "")
            {
                if (columns[columns.Length - 1] != ' ')
                {
                    columns = columns + " ";
                }


                for (int i = 0; i < columns.Length; i++)
                {
                    if (columns[i] == ' ')
                    {
                        blank[b] = i;
                        b++;
                    }
                }
                cols[0] = columns.Substring(0, blank[0]);
                if ((b - 1) > 0)
                {
                    for (int i = 0; i < b; i++)
                    {
                        if ((i + 1) != b)
                        {
                            cols[i + 1] = columns.Substring(blank[i] + 1, blank[i + 1] - blank[i] - 1);
                        }
                    }
                }
            }

            //otvori konekciju
            if (this.OpenConnection() == true)
            {
                //kreirati komandu
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //kreirati čitač podataka
                MySqlDataReader dataReader = cmd.ExecuteReader();
                if (columns != "") //ukoliko su unijete kolone uraditi sljedeći kod
                {
                    //čitati podatke i pohranjivati ih u listu
                    while (dataReader.Read())
                    {
                        for (int i = 0; i < b; i++)
                        {
                            list[i].Add(dataReader[cols[i]] + "");

                        }
                    }
                }
                else //ukoliko nisu unijete kolone uraditi sljedeći kod
                {
                    dataReader.Read();
                    list[0].Add(dataReader.GetString(0));
                }

                //czatvoriti čitač podataka
                dataReader.Close();

                //zatvoriti konekciju
                this.CloseConnection();

                //vratiti listu u program
                return list;
            }
            else
            {
                return list;
            }
        }

        public void inupdel(string query, string  success_message, string failed_Message){
            connection.Open();

            try
            {
                DialogResult d = MessageBox.Show("Are you sure to do this action?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(success_message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message:" + ex.Message+failed_Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                connection.Close();

            }
        
        }
        public void inupdel(String query,String message){

            inupdel(query, message, "");
           
        
        }

        public List<string> multi_select(String query)
        {
            
            a.Clear();

            connection.Open();

            try
            {

                MySqlCommand cmd = new MySqlCommand(query, connection);
                //kreirati čitač podataka
                MySqlDataReader dataReader = cmd.ExecuteReader();
                int col = dataReader.FieldCount;

                if (dataReader.Read()) {
                    int i=0;
                    while (i < col)
                    {

                        a.Add(dataReader.GetString(i));
                        i++;
                    }
                }
                dataReader.Close();
                
                connection.Close();
                return a;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message:" + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                connection.Close();
                return a;
            }


        }

        public List<String> select_multi(String query)
        {

            a.Clear();

            connection.Open();

            try
            {

                MySqlCommand cmd = new MySqlCommand(query, connection);
                //kreirati čitač podataka
                MySqlDataReader dataReader = cmd.ExecuteReader();
                int col = dataReader.FieldCount;

                while (dataReader.Read())
                {
                    int i = 0;
                    while (i < col)
                    {

                        a.Add(dataReader.GetString(i));
                        
                        i++;
                    }
                }
                dataReader.Close();

                connection.Close();
                return a;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message:" + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                connection.Close();
                return a ;
            }


        }
        public String[] multi_select_array(String query)
        {
            
            
           String[] result= multi_select(query).ToArray(); 
               
            return result;
       

        }

        public String[] select_multi_array(String query)
        {


            String[] result = select_multi(query).ToArray();

            return result;


        }

        //Insert statement
        public void Insert(string query)
        {

            inupdel(query, "Insertion is Complete.");
        }
        public void Insert(string query, string msg)
        {

            inupdel(query, msg);
            
        }

        //Update statement
        public void Update(string query)
        {
            inupdel(query, "Update is Successful.");
        }

        //Delete statement
        public void Delete(string query)
        {
            inupdel(query, "Deletion is complete.");
        }

        //Backup
        public void Backup()
        {
        }

        //Restore
        public void Restore()
        {
        }
        public List<List<String>> multiple_array_select(String query)
        {
            
            List<String> single_data = new List<String>();
            List<List<String>> multiple_data = new List<List<String>>();
            

            connection.Open();

            try
            {

                MySqlCommand cmd = new MySqlCommand(query, connection);
                //kreirati čitač podataka
                MySqlDataReader dataReader = cmd.ExecuteReader();
                int col = dataReader.FieldCount;

                while (dataReader.Read())
                {
                    int i = 0;
                    while (i < col)
                    {

                        single_data.Add(dataReader.GetString(i));
                        i++;
                    }
                    multiple_data.Add(single_data);
                }
                dataReader.Close();

                connection.Close();
                return multiple_data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message:" + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                connection.Close();
                return multiple_data;
            }


        }
    }
}
