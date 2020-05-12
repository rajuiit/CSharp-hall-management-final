using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;


namespace Hall_Management_System.Special
{
    public partial class coupon : Form
    {
        MySqlConnection con = Database.DBConnect.getconnectionstring();
        public coupon()
        {
            InitializeComponent();
        }

        private void coupon_Load(object sender, EventArgs e)
        {
            Basic.information_load il = new Basic.information_load();
            il.load(hallNameCB, "hall_info", "hall_name");
            //SELECT DISTINCT (`session`)FROM `student_info`ORDER BY `student_info`.`session` ASC
            il.load(sessionCB, "student_info", "session");


            
        }

        private void createCouponB_Click(object sender, EventArgs e)
        {
            if (titleTB.Text == "")
            {
                MessageBox.Show("Please fill up the  information.","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            String title = titleTB.Text;
            String session = sessionCB.SelectedItem.ToString();
            String hallName = hallNameCB.SelectedItem.ToString();


            couponpdf co = new couponpdf();
            co.pdf_c(hallName,session,title);
            
            
        }
    }
}
