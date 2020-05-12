using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Hall_Management_System.Student
{
    public partial class image_upload : Form
    {
        public string id,name, mobileNo;
        Basic.information_load il = new Basic.information_load();
        object s = new object();
        public image_upload()
        {
            InitializeComponent();
           
        }

        private void takePhotoB_Click(object sender, EventArgs e)
        {
            if (mobileNoL.Text == "mobile" || s_idL.Text == "s_id")
            {
                MessageBox.Show("Please Close the form. Try again. There is No Student ID or Mobile No", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            WebCamera.webcamera ww = new WebCamera.webcamera();
            ww.name = s_name.Text;
            ww.mobileNo = mobileNoL.Text;
           // ww.MdiParent = MDIMain.ActiveForm;
            ww.Show();
        }

        private void browseB_Click(object sender, EventArgs e)
        {
            if (mobileNoL.Text == "mobile")
            {
                MessageBox.Show("Please Close the form. Try again. There is No Student ID or Mobile No", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Filter = "*.jpg|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                studentPB.ImageLocation = openFileDialog1.FileName;
                int picwidth = studentPB.Width;
                int picheight = studentPB.Height;
                // string imgsize = "Original Image Width = " +picwidth + " And Height = " + picheight;
                Size OriginalImageSize = new Size(picwidth, picheight);
                imageUpload();
                }

        }
        private String imageUpload()
        {
            

            string imagepath = studentPB.ImageLocation.ToString();
            //string picname = imagepath.Substring(imagepath.LastIndexOf('\\'));
            string extension = System.IO.Path.GetExtension(openFileDialog1.FileName);
            //MessageBox.Show(extension);
            //string picname = pictureBox2.;
            //string picname = "\\".ToString() + mobileTB.Text + extension;
            string picname = mobileNoL.Text + extension;

            MessageBox.Show("The photo has been uploaded. Now the picture will be resized. Image name:" + picname, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Basic.image_processing aa = new Basic.image_processing();

            Image scaledImage = aa.ScaleByPercent(studentPB.Image);
            studentPB.Image = scaledImage;

            // string path = Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("bin"));
            string path = Application.StartupPath;
            Bitmap imgImage = new Bitmap(studentPB.Image); //Create an object of Bitmap class/
            //string type = imgImage.GetPropertyItem(1).ToString();
            //MessageBox.Show(type);



            imgImage.Save(path + "\\images\\" + picname);


            return picname; //this file name can be accesible to your save button click event.
        }

        private void image_upload_Load(object sender, EventArgs e)
        {
            s_idL.Text = id;
            s_name.Text = name;
            mobileNoL.Text = mobileNo;
            reloadB_Click(s, EventArgs.Empty);
        }

        private void reloadB_Click(object sender, EventArgs e)
        {
            il.image_load(mobileNoL.Text, studentPB);
        }
    }
}
