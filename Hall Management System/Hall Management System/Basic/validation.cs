using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hall_Management_System.Basic
{
    class validation
    {
       static information_load bi = new information_load();

       public static void check_date(DateTimePicker fromDTP, DateTimePicker toDTP, int status)
       {
           if (fromDTP.Value > toDTP.Value)
           {
               MessageBox.Show("From Date must be Less than To date.");

               if (status == 0)
               {
                   fromDTP.Value = toDTP.Value.AddDays(-1);
               }
               else
               {
                   toDTP.Value = fromDTP.Value.AddDays(1);
               }

           }
       }

        public static string check_empty(TextBox tf)
        {
            return check_empty(tf, "Please fill-up the information.");
            
        }
        public static string check_empty(TextBox tf, string msg)
        {
            if (tf.Text == "")
            {
                MessageBox.Show(msg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tf.Focus();
                return "no";
            }
            else {
                return "yes";
            }
            
        }
        public static string check_empty(String str)
        {
            return check_empty(str, "Please fill-up the information.");

        }
        public static string check_empty(String str, string msg)
        {
            if (str == "")
            {
                MessageBox.Show(msg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
                return "no";
            }
            else
            {
                return "yes";
            }

        }
        public static string check_admin(int uid)
        {
            return check_admin(uid, "Permission Denied. You can't do this action. Contact with your administrator.");

        }
        public static string check_admin(int uid,String msg)
        {

            String checkadmin = bi.get_value("SELECT type FROM `user` WHERE user_id =" + uid + "");
            if (checkadmin != "Admin")
            {
                MessageBox.Show(msg, "Warning", MessageBoxButtons.OK);
                return "no";
            }
            else
            {
                return "yes";
            }

        }
    }
}
