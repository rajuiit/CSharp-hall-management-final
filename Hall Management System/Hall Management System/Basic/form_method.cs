using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hall_Management_System.Basic
{
    class form_method
    {
        public void closeForm(FormClosingEventArgs e) {
            
            DialogResult d = MessageBox.Show("Are You sure to quit?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (d != DialogResult.Yes)
            {
                e.Cancel = true;

            }

            
        
        }


        
    }
}
