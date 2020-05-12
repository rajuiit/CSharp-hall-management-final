using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO; //For Directory class
using MySql.Data.MySqlClient;

namespace Hall_Management_System.Student
{
    public partial class search_student : Form
    {
        object s = new object();

        MySqlConnection con = Database.DBConnect.getconnectionstring();
        Basic.information_load il = new Basic.information_load();
        Database.DBConnect db = new Database.DBConnect();
      
        public search_student()
        {
            InitializeComponent();
        }

        private void searchB_Click(object sender, EventArgs e)
        {

            Student.search aa = new Student.search();
            aa.searchButtonWork(searchTB, anySearchRB, idSearchRB, nameSearchRB, rollSearchRB,registrationSearchRB,roomSearchRB, studentDGV);

        }

        private void search_student_Load(object sender, EventArgs e)
        {

        }

        private void studentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
