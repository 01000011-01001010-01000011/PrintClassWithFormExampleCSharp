using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Printing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace ProjectManagementPro
{

    public partial class PrintProjectForm : Form
    {

        int intPageIndex;

        int intSelectedPanel;

        Bitmap memoryImage;

        Image screenShot;

        CompleteProjectDetails completeProjectDetails;

        List<ProjectResources> resourcesList;
        List<ProjectTasks> tasksList;             

        DataTable resourcesTable;
        DataTable tasksTable;

        TableClass newTableClass = new TableClass();

        PrintDocument printDocument; //= new PrintDocument();

        PrintClass newPrintClass = new PrintClass();

        /*Font printFont;
               
        StreamReader reader;*/

        public PrintProjectForm(CompleteProjectDetails completeProject)
        {

            InitializeComponent();

            completeProjectDetails = completeProject;

            resourcesList = completeProject.ProjectResources;

            tasksList = completeProject.ProjectTasks;

            FillInProjectDetails();

            LoadTables();
                                  
           
        }

        private List<Image> imageList { get; set; }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Prints the screen          

            HideControls(); // Hide controls for printing                

            CaptureScreen();

            ShowControls(); // Show controls after printing                                                                             

        }

        private void FillInProjectDetails()
        {
            // Fills in the project details into the form

            txtBoxAccountManager.Text = completeProjectDetails.ManagedBy.ToString();
            txtBoxProjectNumber.Text = completeProjectDetails.ProjectNumber.ToString();
            txtBoxProjectName.Text = completeProjectDetails.ProjectName.ToString();
            txtBoxProjectDescription.Text = completeProjectDetails.ProjectDescription.ToString();
            txtBoxCustomerName.Text = completeProjectDetails.EndUserName.ToString();
            txtBoxCustomerNumber.Text = completeProjectDetails.EndUserIDNumber.ToString();
            txtBoxProjectType.Text = completeProjectDetails.ProjectType.ToString();
            txtBoxProjectPhase.Text = completeProjectDetails.ProjectPhase.ToString();
            txtBoxProjectStatus.Text = completeProjectDetails.ProjectStatus.ToString();
            txtBoxStartDate.Text = completeProjectDetails.StartDate.ToString();
            txtBoxEstCompletionDate.Text = completeProjectDetails.EstimatedCompletionDate.ToString();
            txtBoxCompletionDate.Text = completeProjectDetails.ActualCompletionDate.ToString();

            progBarProjectProgress.Value = completeProjectDetails.ProjectProgress;

        }

        private void LoadTables()
        {
            // Loads the resources and tasks tables

            resourcesTable = newTableClass.CreateResourcesTableFromProjectDetailsList(resourcesList);

            tasksTable = newTableClass.CreateTasksTableFromProjectDetailsList(tasksList);

            if (resourcesTable.Rows.Count > 0)
            {

                dgvResources.DataSource = resourcesTable;

            }

            if (tasksList.Count > 0)
            {
                                
                btnViewTasksPage.Enabled = true;

            }

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        // Print functions

        private void CaptureScreen()
        {
            // Captures a screen shot

            // imageList = new List<Image>();                                           

            Graphics screenGraphics = this.CreateGraphics();

            Size sizeToPrint = new Size();

            sizeToPrint.Width = this.Width;

            sizeToPrint.Height = this.Height;

           // Bitmap ScreenShot = new Bitmap(sizeToPrint.Width, sizeToPrint.Height, screenGraphics);

            memoryImage = new Bitmap(sizeToPrint.Width, sizeToPrint.Height, screenGraphics);  //(sizeToPrint.Width, sizeToPrint.Height, screenGraphics);

            memoryImage = newPrintClass.ResizeImage(memoryImage, this.Width, this.Height);

            this.DrawToBitmap(memoryImage, new Rectangle(0, 0, memoryImage.Width * 2, memoryImage.Height));

            Graphics printGraphics = Graphics.FromImage(memoryImage);
            printGraphics.DrawImage(memoryImage, 0, -50); //, 0, 0, new Rectangle(0, 0, Convert.ToInt32(this.Width), Convert.ToInt32(this.Height)), sizeToPrint);

            newPrintClass.PrintPage(memoryImage);

            /*Brush blackBursh = new SolidBrush(Color.Black);

            Pen pen = new Pen(blackBursh, 3);

            decimal xPos = memoryImage.Width; // 983m; // A4 Width
            decimal yPos = memoryImage.Height; // 945m; // A4 Height

            /*int xDiv = Convert.ToInt32(Math.Ceiling(xPos));
            int yDiv = Convert.ToInt32(Math.Ceiling(yPos));

            if (xDiv >= 1 && yDiv >= 1)
            {

                for (int i = 0; i < xDiv; i++)
                {

                    for (int j = 0; j < yDiv; j++)
                    {

                        Rectangle rectangle;

                        try
                        {

                            rectangle = new Rectangle(i * Convert.ToInt32(memoryImage.Width / xDiv), j * Convert.ToInt32(memoryImage.Height / yDiv), memoryImage.Width / xDiv, memoryImage.Height / yDiv);


                        }
                        catch (Exception ex)
                        {

                            rectangle = new Rectangle(i * Convert.ToInt32(memoryImage.Width / xDiv), j * Convert.ToInt32(memoryImage.Height / yDiv), memoryImage.Width / xDiv, memoryImage.Height);

                        }


                        printGraphics.DrawRectangle(pen, rectangle);

                        imageList.Add(CropImage(memoryImage, rectangle));

                    }


                }*/

            
        }
              
      

        private void HideControls()
        {
            // Hides controls for printing

            menuStripPrintProject.Visible = false;

           // dgvProjectTasks.ScrollBars = ScrollBars.None;

            dgvResources.ScrollBars = ScrollBars.None;

            btnViewTasksPage.Visible = false;

        }

        private void ShowControls()
        {
            // Shows the hidden controls after printing

            menuStripPrintProject.Visible = true;

            //dgvProjectTasks.ScrollBars = ScrollBars.Both;

            dgvResources.ScrollBars = ScrollBars.Both;

            btnViewTasksPage.Visible = true;

        }

        private void btnViewTasksPage_Click(object sender, EventArgs e)
        {
            // Opens the project tasks page

            ProjectTasksForm projectTasksForm = new ProjectTasksForm(tasksTable);

            projectTasksForm.Activate();
            projectTasksForm.Show();

            //dgvProjectTasks.DataSource = tasksTable;

        }


        /*private void printImage_Btn_Click(object sender, EventArgs e)
{
list = new List<Image>();
Graphics g = Graphics.FromImage(image_PctrBx.Image);
Brush redBrush = new SolidBrush(Color.Red);
Pen pen = new Pen(redBrush, 3);
decimal xdivider = image_PctrBx.Image.Width / 595m;
int xdiv = Convert.ToInt32(Math.Ceiling(xdivider));
decimal ydivider = image_PctrBx.Image.Height / 841m;
int ydiv = Convert.ToInt32(Math.Ceiling(ydivider));
/*int xdiv = image_PctrBx.Image.Width / 595; //This is the xsize in pt (A4)
int ydiv = image_PctrBx.Image.Height / 841; //This is the ysize in pt (A4)
// @ 72 dots-per-inch - taken from Adobe Illustrator

if (xdiv >= 1 && ydiv >= 1)
{
   for (int i = 0; i<xdiv; i++)
   {
       for (int y = 0; y<ydiv; y++)
       {
           Rectangle r;
           try
           {
               r = new Rectangle(i* Convert.ToInt32(image_PctrBx.Image.Width / xdiv),
                                           y* Convert.ToInt32(image_PctrBx.Image.Height / ydiv),
                                           image_PctrBx.Image.Width / xdiv,
                                           image_PctrBx.Image.Height / ydiv);
           }
           catch (Exception)
           {
               r = new Rectangle(i* Convert.ToInt32(image_PctrBx.Image.Width / xdiv),
                 y* Convert.ToInt32(image_PctrBx.Image.Height),
                 image_PctrBx.Image.Width / xdiv,
                 image_PctrBx.Image.Height);
           }


g.DrawRectangle(pen, r);
           list.Add(cropImage(image_PctrBx.Image, r));
       }
   }

g.Dispose();
image_PctrBx.Invalidate();
image_PctrBx.Image = list[0];

PrintDocument printDocument = new PrintDocument();
printDocument.PrintPage += PrintDocument_PrintPage;
PrintPreviewDialog previewDialog = new PrintPreviewDialog();
previewDialog.Document = printDocument;
pageIndex = 0;
previewDialog.ShowDialog();
// don't forget to detach the event handler when you are done
printDocument.PrintPage -= PrintDocument_PrintPage;
}

 private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
{
// Draw the image for the current page index
e.Graphics.DrawImageUnscaled(list[pageIndex],
                            e.PageBounds.X,
                            e.PageBounds.Y);
// increment page index
pageIndex++;
// indicate whether there are more pages or not
e.HasMorePages = (pageIndex < list.Count);
}

private static Image cropImage(Image img, Rectangle cropArea)
{
Bitmap bmpImage = new Bitmap(img);
Bitmap bmpCrop = bmpImage.Clone(cropArea, System.Drawing.Imaging.PixelFormat.DontCare);
return (Image)(bmpCrop);
}

internal string tempPath { get; set; }
private int pageIndex = 0;
internal List<Image> list { get; set; }


*/


    }

    }
