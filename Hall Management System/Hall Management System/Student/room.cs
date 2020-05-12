using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hall_Management_System.Student
{
    public partial class room : Form
    {
        
        Basic.information_load il = new Basic.information_load();
        private string roomNo;
        private string hallName;
        public room()
        {
            InitializeComponent();
        }

        private void room_Load(object sender, EventArgs e)
        {
            il.load(hallCB, "SELECT hall_name from hall_info");
            hallCB.SelectedItem = hallName;

            il.load(roomCB, "SELECT distinct(room) from seat");
            roomCB.SelectedItem = roomNo;

        }

        private void roomCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            show_result();
        }

        private void show_result()
        {
            int hallid = Convert.ToInt32( il.get_value("Select hall_id  from hall_info where hall_name = '" + hallCB.SelectedItem + "'"));

            String basic_query = "Select hall_std_id as 'Hall ID',session as Session,name as Name,degree as Degree,mobile as Mobile,religion as Religion from student_info where hall_id = " + hallid + "  and  alloted_room = '" + roomCB.SelectedItem + "' ";

            il.datagridview_load("select room,capacity from seat where room='" + roomCB.SelectedItem.ToString() + "' and hall_id="+hallid+"", capacityDGV);
            il.datagridview_load(basic_query + " and status = 0", dataGridView1);
            il.datagridview_load(basic_query + " and status = 1", dataGridView2);
        
        }

       

        private void hallCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            show_result();
        }


        internal void intial(string hall_name, string room_no)
        {
            hallName = hall_name;
            roomNo = room_no;
           
            
        }
    }
}
