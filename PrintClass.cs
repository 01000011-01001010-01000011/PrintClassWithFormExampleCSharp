using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagementPro
{
    class PrintClass
    {

        Image memoryImage;
       
        public Image CropImage(Image image, Rectangle rectangle)
        {
            // Crops the image for printing

            Bitmap bmpImage = new Bitmap(image);
            Bitmap bmpCrop = bmpImage.Clone(rectangle, System.Drawing.Imaging.PixelFormat.DontCare);

            return (Image)(bmpCrop);

        }
                
        public Bitmap ResizeImage(Image image, int width, int height)
        {
            // Resizes a bitmap to the specified width and height

            Bitmap resizedBitmap; // = new Bitmap(width, height);

            var ratioX = (double)width / image.Width;
            var ratioY = (double)height / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            resizedBitmap = new Bitmap(newWidth, newHeight);

            using (Graphics gr = Graphics.FromImage(resizedBitmap))
            {
                gr.SmoothingMode = SmoothingMode.HighQuality;
                gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
                gr.DrawImage(image, new Rectangle(0, 0, width, height));
            }

            return resizedBitmap;
        }

        public void PrintPage(Image imageToPrint)
        {
            // Prints the selected image

            PrintPreviewDialog newPrintPreview = new PrintPreviewDialog();

            PrintDocument printDocument = new PrintDocument();

            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);

            printDocument.DefaultPageSettings.Landscape = true;

            newPrintPreview = new PrintPreviewDialog();

            memoryImage = imageToPrint;

            newPrintPreview.Document = printDocument;

            newPrintPreview.ShowDialog();

            printDocument.PrintPage -= printDocument_PrintPage;

        }


        public void printDocument_PrintPage(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Prints the page                                           

            // e.Graphics.DrawImage(memoryImage, 0, 0);
            // e.Graphics.DrawImageUnscaled(memoryImage, e.PageBounds.X, e.PageBounds.Y);

            e.Graphics.DrawImage(memoryImage, 0, 0);
            //  intPageIndex++;

            //   e.HasMorePages = (intPageIndex < imageList.Count);


        }

       

    }

}
