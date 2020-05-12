using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;//for Image class
using System.Drawing.Imaging;//for pixel format
using System.Drawing.Drawing2D;//for interpolation mode


namespace Hall_Management_System.Basic
{
    class image_processing
    {
        public Image ScaleByPercent(Image imgPhoto)
        {
            int sourceWidth = imgPhoto.Width; //store original width of source image.
            int sourceHeight = imgPhoto.Height; //store original height of source image.
            int sourceX = 0; //x-axis of source image.
            int sourceY = 0; //y-axis of source image.
            int destX = 0; //x-axis of destination image.
            int destY = 0; //y-axis of destination image.

            Bitmap bmPhoto;

            if (sourceWidth > sourceHeight)
            //for cheking whether slected image orizontally or vertically oriented
            {
                bmPhoto = new Bitmap(300, 200, PixelFormat.Format24bppRgb);
            }
            else
            {
                bmPhoto = new Bitmap(200, 300, PixelFormat.Format24bppRgb);
            }

            //Create a graphics object and set quality of graphics.
            Graphics grPhoto = Graphics.FromImage(bmPhoto);
            grPhoto.InterpolationMode = InterpolationMode.HighQualityBicubic;
            //Draw image by using DrawImage() method of graphics class.
            int bmPhotowidth = bmPhoto.Width;
            int bmPhotoHeight = bmPhoto.Height;
            if (bmPhotowidth > bmPhotoHeight)
            {
                grPhoto.DrawImage(imgPhoto, new Rectangle(destX, destY, 300, 200),
                                  new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight), GraphicsUnit.Pixel);

            }
            else
            {
                grPhoto.DrawImage(imgPhoto, new Rectangle(destX, destY, 200, 300),
                                  new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight), GraphicsUnit.Pixel);

            }
            grPhoto.Dispose(); //Dispose graphics object.
            return bmPhoto;
        }








        public Image ScaleByPercent(Image imgPhoto,int width, int height)
        {
            int sourceWidth = imgPhoto.Width; //store original width of source image.
            int sourceHeight = imgPhoto.Height; //store original height of source image.
            int sourceX = 0; //x-axis of source image.
            int sourceY = 0; //y-axis of source image.
            int destX = 0; //x-axis of destination image.
            int destY = 0; //y-axis of destination image.

            Bitmap bmPhoto;

            if (sourceWidth > sourceHeight)
            //for cheking whether slected image orizontally or vertically oriented
            {
                bmPhoto = new Bitmap(width, height, PixelFormat.Format24bppRgb);
            }
            else
            {
                bmPhoto = new Bitmap(height, width, PixelFormat.Format24bppRgb);
            }

            //Create a graphics object and set quality of graphics.
            Graphics grPhoto = Graphics.FromImage(bmPhoto);
            grPhoto.InterpolationMode = InterpolationMode.HighQualityBicubic;
            //Draw image by using DrawImage() method of graphics class.
            int bmPhotowidth = bmPhoto.Width;
            int bmPhotoHeight = bmPhoto.Height;
            if (bmPhotowidth > bmPhotoHeight)
            {
                grPhoto.DrawImage(imgPhoto, new Rectangle(destX, destY, width, height),
                                  new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight), GraphicsUnit.Pixel);

            }
            else
            {
                grPhoto.DrawImage(imgPhoto, new Rectangle(destX, destY, height, width),
                                  new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight), GraphicsUnit.Pixel);

            }
            grPhoto.Dispose(); //Dispose graphics object.
            return bmPhoto;
        }

    }
}
