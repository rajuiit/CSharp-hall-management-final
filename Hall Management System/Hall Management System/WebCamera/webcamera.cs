using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Touchless.Vision.Camera;
using System.IO;
using MySql.Data.MySqlClient;


namespace Hall_Management_System.WebCamera
{
    public partial class webcamera : Form
    {

        MySqlConnection con = Database.DBConnect.getconnectionstring();
        public string name,mobileNo;
       
            
        private CameraFrameSource _frameSource;
        private static Bitmap _latestFrame;
        public webcamera()
        {
            InitializeComponent();
        }

        private void webcamera_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                // Refresh the list of available cameras
                comboBoxCameras.Items.Clear();
                foreach (Camera cam in CameraService.AvailableCameras)
                    comboBoxCameras.Items.Add(cam);

                if (comboBoxCameras.Items.Count > 0)
                    comboBoxCameras.SelectedIndex = 0;
            }

            nameL.Text = name;
            mobileNoL.Text = mobileNo;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Early return if we've selected the current camera
            if (_frameSource != null && _frameSource.Camera == comboBoxCameras.SelectedItem)
                return;

            thrashOldCamera();
            startCapturing();
        }
        private void startCapturing()
        {
            try
            {
                Camera c = (Camera)comboBoxCameras.SelectedItem;
                setFrameSource(new CameraFrameSource(c));
                _frameSource.Camera.CaptureWidth = 320;
                _frameSource.Camera.CaptureHeight = 240;
                _frameSource.Camera.Fps = 20;
                _frameSource.NewFrame += OnImageCaptured;

                pictureBoxDisplay.Paint += new PaintEventHandler(drawLatestImage);
                _frameSource.StartFrameCapture();
            }
            catch (Exception ex)
            {
                comboBoxCameras.Text = "Select A Camera";
                MessageBox.Show(ex.Message);
            }
        }
        private void drawLatestImage(object sender, PaintEventArgs e)
        {
            if (_latestFrame != null)
            {
                // Draw the latest image from the active camera
               e.Graphics.DrawImage(_latestFrame, 0, 0, _latestFrame.Width, _latestFrame.Height);
               
            }
        }

        public void OnImageCaptured(Touchless.Vision.Contracts.IFrameSource frameSource, Touchless.Vision.Contracts.Frame frame, double fps)
        {
            _latestFrame = frame.Image;
            pictureBoxDisplay.Invalidate();
        }

        private void setFrameSource(CameraFrameSource cameraFrameSource)
        {
            if (_frameSource == cameraFrameSource)
                return;

            _frameSource = cameraFrameSource;
        }

        //

        private void thrashOldCamera()
        {
            // Trash the old camera
            if (_frameSource != null)
            {
                _frameSource.NewFrame -= OnImageCaptured;
                _frameSource.Camera.Dispose();
                setFrameSource(null);
                pictureBoxDisplay.Paint -= new PaintEventHandler(drawLatestImage);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            thrashOldCamera();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_frameSource == null)
                return;
            //string path = Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("images"));
            //string path = Application.StartupPath;
            string path = Environment.CurrentDirectory;
            path = Path.Combine(path, "images");
            bool IsExists = System.IO.Directory.Exists(path);
            if (!IsExists) System.IO.Directory.CreateDirectory(path);
            
            Bitmap current = (Bitmap)_latestFrame.Clone();
            var fileName = Path.Combine(path, mobileNo + ".jpg");
            
            current.Save(fileName);
            //MessageBox.Show(fileName);
            //using (SaveFileDialog sfd = new SaveFileDialog())
            //{


            //    sfd.InitialDirectory = path;
            //    sfd.FileName = mobileNo;
            //    sfd.Filter = "*.jpg|*.jpg";
            //    if (sfd.ShowDialog() == DialogResult.OK)
            //    {
                    
            //        current.Save(sfd.FileName);
            //        MessageBox.Show("Image upload is complete. Now the image will be resized. image name:" + mobileNoL.Text + ".jpg");
            //    }
            //}

            current.Dispose();
            MessageBox.Show("Image upload is complete. Now the image will be resized. image name:" + mobileNoL.Text + ".jpg");

           // MessageBox.Show(path);
            //for size small
            
            pictureBoxDisplay.ImageLocation = fileName;

            MessageBox.Show(pictureBoxDisplay.ImageLocation);
            //nameL.Text = pictureBoxDisplay.ImageLocation;
            Basic.image_processing aa = new Basic.image_processing();
            
            Image scaledImage = aa.ScaleByPercent(pictureBoxDisplay.Image);
            pictureBoxDisplay.Image = scaledImage;

            Bitmap imgImage = new Bitmap(pictureBoxDisplay.Image); //Create an object of Bitmap class/
            //string type = imgImage.GetPropertyItem(1).ToString();
            //MessageBox.Show(type);
            imgImage.Save(fileName);
           

           
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            // snap camera
            if (_frameSource != null)
                _frameSource.Camera.ShowPropertiesDialog();

        }

        private void webcamera_FormClosing(object sender, FormClosingEventArgs e)
        {
            thrashOldCamera();
        }

    }
}
