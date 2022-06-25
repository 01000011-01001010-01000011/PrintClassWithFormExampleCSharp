namespace ProjectManagementPro
{
    partial class PrintProjectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripPrintProject = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvResources = new System.Windows.Forms.DataGridView();
            this.lblProjectResources = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlProjectDetails = new System.Windows.Forms.Panel();
            this.txtBoxCompletionDate = new System.Windows.Forms.TextBox();
            this.lblActualCompletionDate = new System.Windows.Forms.Label();
            this.txtBoxEstCompletionDate = new System.Windows.Forms.TextBox();
            this.txtBoxStartDate = new System.Windows.Forms.TextBox();
            this.progBarProjectProgress = new System.Windows.Forms.ProgressBar();
            this.lblProjectProgess = new System.Windows.Forms.Label();
            this.txtBoxProjectStatus = new System.Windows.Forms.TextBox();
            this.lblProjectStatus = new System.Windows.Forms.Label();
            this.txtBoxAccountManager = new System.Windows.Forms.TextBox();
            this.lblAccountManager = new System.Windows.Forms.Label();
            this.txtBoxProjectPhase = new System.Windows.Forms.TextBox();
            this.lblProjectPhase = new System.Windows.Forms.Label();
            this.txtBoxProjectType = new System.Windows.Forms.TextBox();
            this.lblProjectType = new System.Windows.Forms.Label();
            this.lblEstCompletionDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.txtBoxCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtBoxCustomerNumber = new System.Windows.Forms.TextBox();
            this.lblCustomerNumber = new System.Windows.Forms.Label();
            this.txtBoxProjectDescription = new System.Windows.Forms.TextBox();
            this.lblProjectDescription = new System.Windows.Forms.Label();
            this.txtBoxProjectName = new System.Windows.Forms.TextBox();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.txtBoxProjectNumber = new System.Windows.Forms.TextBox();
            this.lblProjectNumber = new System.Windows.Forms.Label();
            this.btnViewTasksPage = new System.Windows.Forms.Button();
            this.menuStripPrintProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResources)).BeginInit();
            this.pnlProjectDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripPrintProject
            // 
            this.menuStripPrintProject.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStripPrintProject.Location = new System.Drawing.Point(0, 0);
            this.menuStripPrintProject.Name = "menuStripPrintProject";
            this.menuStripPrintProject.Size = new System.Drawing.Size(986, 24);
            this.menuStripPrintProject.TabIndex = 0;
            this.menuStripPrintProject.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // dgvResources
            // 
            this.dgvResources.AllowUserToAddRows = false;
            this.dgvResources.AllowUserToDeleteRows = false;
            this.dgvResources.AllowUserToOrderColumns = true;
            this.dgvResources.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvResources.BackgroundColor = System.Drawing.Color.White;
            this.dgvResources.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResources.Location = new System.Drawing.Point(11, 300);
            this.dgvResources.Name = "dgvResources";
            this.dgvResources.RowHeadersVisible = false;
            this.dgvResources.Size = new System.Drawing.Size(961, 505);
            this.dgvResources.TabIndex = 21;
            // 
            // lblProjectResources
            // 
            this.lblProjectResources.AutoSize = true;
            this.lblProjectResources.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectResources.ForeColor = System.Drawing.Color.Blue;
            this.lblProjectResources.Location = new System.Drawing.Point(12, 278);
            this.lblProjectResources.Name = "lblProjectResources";
            this.lblProjectResources.Size = new System.Drawing.Size(186, 19);
            this.lblProjectResources.TabIndex = 20;
            this.lblProjectResources.Text = "PROJECT RESOURCES:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(12, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(208, 24);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "PROJECT DETAILS:";
            // 
            // pnlProjectDetails
            // 
            this.pnlProjectDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlProjectDetails.Controls.Add(this.txtBoxCompletionDate);
            this.pnlProjectDetails.Controls.Add(this.lblActualCompletionDate);
            this.pnlProjectDetails.Controls.Add(this.txtBoxEstCompletionDate);
            this.pnlProjectDetails.Controls.Add(this.txtBoxStartDate);
            this.pnlProjectDetails.Controls.Add(this.progBarProjectProgress);
            this.pnlProjectDetails.Controls.Add(this.lblProjectProgess);
            this.pnlProjectDetails.Controls.Add(this.txtBoxProjectStatus);
            this.pnlProjectDetails.Controls.Add(this.lblProjectStatus);
            this.pnlProjectDetails.Controls.Add(this.txtBoxAccountManager);
            this.pnlProjectDetails.Controls.Add(this.lblAccountManager);
            this.pnlProjectDetails.Controls.Add(this.txtBoxProjectPhase);
            this.pnlProjectDetails.Controls.Add(this.lblProjectPhase);
            this.pnlProjectDetails.Controls.Add(this.txtBoxProjectType);
            this.pnlProjectDetails.Controls.Add(this.lblProjectType);
            this.pnlProjectDetails.Controls.Add(this.lblEstCompletionDate);
            this.pnlProjectDetails.Controls.Add(this.lblStartDate);
            this.pnlProjectDetails.Controls.Add(this.txtBoxCustomerName);
            this.pnlProjectDetails.Controls.Add(this.lblCustomerName);
            this.pnlProjectDetails.Controls.Add(this.txtBoxCustomerNumber);
            this.pnlProjectDetails.Controls.Add(this.lblCustomerNumber);
            this.pnlProjectDetails.Controls.Add(this.txtBoxProjectDescription);
            this.pnlProjectDetails.Controls.Add(this.lblProjectDescription);
            this.pnlProjectDetails.Controls.Add(this.txtBoxProjectName);
            this.pnlProjectDetails.Controls.Add(this.lblProjectName);
            this.pnlProjectDetails.Controls.Add(this.txtBoxProjectNumber);
            this.pnlProjectDetails.Controls.Add(this.lblProjectNumber);
            this.pnlProjectDetails.Location = new System.Drawing.Point(11, 71);
            this.pnlProjectDetails.Name = "pnlProjectDetails";
            this.pnlProjectDetails.Size = new System.Drawing.Size(961, 195);
            this.pnlProjectDetails.TabIndex = 18;
            // 
            // txtBoxCompletionDate
            // 
            this.txtBoxCompletionDate.Location = new System.Drawing.Point(753, 117);
            this.txtBoxCompletionDate.Name = "txtBoxCompletionDate";
            this.txtBoxCompletionDate.Size = new System.Drawing.Size(187, 20);
            this.txtBoxCompletionDate.TabIndex = 26;
            // 
            // lblActualCompletionDate
            // 
            this.lblActualCompletionDate.AutoSize = true;
            this.lblActualCompletionDate.Location = new System.Drawing.Point(656, 120);
            this.lblActualCompletionDate.Name = "lblActualCompletionDate";
            this.lblActualCompletionDate.Size = new System.Drawing.Size(88, 13);
            this.lblActualCompletionDate.TabIndex = 25;
            this.lblActualCompletionDate.Text = "Completion Date:";
            // 
            // txtBoxEstCompletionDate
            // 
            this.txtBoxEstCompletionDate.Location = new System.Drawing.Point(447, 117);
            this.txtBoxEstCompletionDate.Name = "txtBoxEstCompletionDate";
            this.txtBoxEstCompletionDate.Size = new System.Drawing.Size(192, 20);
            this.txtBoxEstCompletionDate.TabIndex = 24;
            // 
            // txtBoxStartDate
            // 
            this.txtBoxStartDate.Location = new System.Drawing.Point(129, 117);
            this.txtBoxStartDate.Name = "txtBoxStartDate";
            this.txtBoxStartDate.Size = new System.Drawing.Size(187, 20);
            this.txtBoxStartDate.TabIndex = 23;
            // 
            // progBarProjectProgress
            // 
            this.progBarProjectProgress.Location = new System.Drawing.Point(129, 151);
            this.progBarProjectProgress.Name = "progBarProjectProgress";
            this.progBarProjectProgress.Size = new System.Drawing.Size(811, 23);
            this.progBarProjectProgress.TabIndex = 22;
            // 
            // lblProjectProgess
            // 
            this.lblProjectProgess.AutoSize = true;
            this.lblProjectProgess.Location = new System.Drawing.Point(15, 151);
            this.lblProjectProgess.Name = "lblProjectProgess";
            this.lblProjectProgess.Size = new System.Drawing.Size(87, 13);
            this.lblProjectProgess.TabIndex = 21;
            this.lblProjectProgess.Text = "Project Progress:";
            // 
            // txtBoxProjectStatus
            // 
            this.txtBoxProjectStatus.Location = new System.Drawing.Point(753, 91);
            this.txtBoxProjectStatus.Name = "txtBoxProjectStatus";
            this.txtBoxProjectStatus.Size = new System.Drawing.Size(187, 20);
            this.txtBoxProjectStatus.TabIndex = 20;
            // 
            // lblProjectStatus
            // 
            this.lblProjectStatus.AutoSize = true;
            this.lblProjectStatus.Location = new System.Drawing.Point(656, 94);
            this.lblProjectStatus.Name = "lblProjectStatus";
            this.lblProjectStatus.Size = new System.Drawing.Size(76, 13);
            this.lblProjectStatus.TabIndex = 19;
            this.lblProjectStatus.Text = "Project Status:";
            // 
            // txtBoxAccountManager
            // 
            this.txtBoxAccountManager.Location = new System.Drawing.Point(129, 13);
            this.txtBoxAccountManager.Name = "txtBoxAccountManager";
            this.txtBoxAccountManager.Size = new System.Drawing.Size(187, 20);
            this.txtBoxAccountManager.TabIndex = 18;
            // 
            // lblAccountManager
            // 
            this.lblAccountManager.AutoSize = true;
            this.lblAccountManager.Location = new System.Drawing.Point(14, 16);
            this.lblAccountManager.Name = "lblAccountManager";
            this.lblAccountManager.Size = new System.Drawing.Size(95, 13);
            this.lblAccountManager.TabIndex = 17;
            this.lblAccountManager.Text = "Account Manager:";
            // 
            // txtBoxProjectPhase
            // 
            this.txtBoxProjectPhase.Location = new System.Drawing.Point(447, 91);
            this.txtBoxProjectPhase.Name = "txtBoxProjectPhase";
            this.txtBoxProjectPhase.Size = new System.Drawing.Size(192, 20);
            this.txtBoxProjectPhase.TabIndex = 16;
            // 
            // lblProjectPhase
            // 
            this.lblProjectPhase.AutoSize = true;
            this.lblProjectPhase.Location = new System.Drawing.Point(332, 94);
            this.lblProjectPhase.Name = "lblProjectPhase";
            this.lblProjectPhase.Size = new System.Drawing.Size(76, 13);
            this.lblProjectPhase.TabIndex = 15;
            this.lblProjectPhase.Text = "Project Phase:";
            // 
            // txtBoxProjectType
            // 
            this.txtBoxProjectType.Location = new System.Drawing.Point(129, 91);
            this.txtBoxProjectType.Name = "txtBoxProjectType";
            this.txtBoxProjectType.Size = new System.Drawing.Size(187, 20);
            this.txtBoxProjectType.TabIndex = 14;
            // 
            // lblProjectType
            // 
            this.lblProjectType.AutoSize = true;
            this.lblProjectType.Location = new System.Drawing.Point(15, 94);
            this.lblProjectType.Name = "lblProjectType";
            this.lblProjectType.Size = new System.Drawing.Size(70, 13);
            this.lblProjectType.TabIndex = 13;
            this.lblProjectType.Text = "Project Type:";
            // 
            // lblEstCompletionDate
            // 
            this.lblEstCompletionDate.AutoSize = true;
            this.lblEstCompletionDate.Location = new System.Drawing.Point(332, 120);
            this.lblEstCompletionDate.Name = "lblEstCompletionDate";
            this.lblEstCompletionDate.Size = new System.Drawing.Size(109, 13);
            this.lblEstCompletionDate.TabIndex = 11;
            this.lblEstCompletionDate.Text = "Est. Completion Date:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(15, 120);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(58, 13);
            this.lblStartDate.TabIndex = 10;
            this.lblStartDate.Text = "Start Date:";
            // 
            // txtBoxCustomerName
            // 
            this.txtBoxCustomerName.Location = new System.Drawing.Point(447, 65);
            this.txtBoxCustomerName.Name = "txtBoxCustomerName";
            this.txtBoxCustomerName.Size = new System.Drawing.Size(493, 20);
            this.txtBoxCustomerName.TabIndex = 9;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(332, 68);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(85, 13);
            this.lblCustomerName.TabIndex = 8;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // txtBoxCustomerNumber
            // 
            this.txtBoxCustomerNumber.Location = new System.Drawing.Point(129, 65);
            this.txtBoxCustomerNumber.Name = "txtBoxCustomerNumber";
            this.txtBoxCustomerNumber.Size = new System.Drawing.Size(187, 20);
            this.txtBoxCustomerNumber.TabIndex = 7;
            // 
            // lblCustomerNumber
            // 
            this.lblCustomerNumber.AutoSize = true;
            this.lblCustomerNumber.Location = new System.Drawing.Point(15, 68);
            this.lblCustomerNumber.Name = "lblCustomerNumber";
            this.lblCustomerNumber.Size = new System.Drawing.Size(94, 13);
            this.lblCustomerNumber.TabIndex = 6;
            this.lblCustomerNumber.Text = "Customer Number:";
            // 
            // txtBoxProjectDescription
            // 
            this.txtBoxProjectDescription.Location = new System.Drawing.Point(129, 39);
            this.txtBoxProjectDescription.Name = "txtBoxProjectDescription";
            this.txtBoxProjectDescription.Size = new System.Drawing.Size(811, 20);
            this.txtBoxProjectDescription.TabIndex = 5;
            // 
            // lblProjectDescription
            // 
            this.lblProjectDescription.AutoSize = true;
            this.lblProjectDescription.Location = new System.Drawing.Point(14, 43);
            this.lblProjectDescription.Name = "lblProjectDescription";
            this.lblProjectDescription.Size = new System.Drawing.Size(99, 13);
            this.lblProjectDescription.TabIndex = 4;
            this.lblProjectDescription.Text = "Project Description:";
            // 
            // txtBoxProjectName
            // 
            this.txtBoxProjectName.Location = new System.Drawing.Point(753, 13);
            this.txtBoxProjectName.Name = "txtBoxProjectName";
            this.txtBoxProjectName.Size = new System.Drawing.Size(187, 20);
            this.txtBoxProjectName.TabIndex = 3;
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(656, 16);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(74, 13);
            this.lblProjectName.TabIndex = 2;
            this.lblProjectName.Text = "Project Name:";
            // 
            // txtBoxProjectNumber
            // 
            this.txtBoxProjectNumber.Location = new System.Drawing.Point(447, 13);
            this.txtBoxProjectNumber.Name = "txtBoxProjectNumber";
            this.txtBoxProjectNumber.Size = new System.Drawing.Size(185, 20);
            this.txtBoxProjectNumber.TabIndex = 1;
            // 
            // lblProjectNumber
            // 
            this.lblProjectNumber.AutoSize = true;
            this.lblProjectNumber.Location = new System.Drawing.Point(332, 16);
            this.lblProjectNumber.Name = "lblProjectNumber";
            this.lblProjectNumber.Size = new System.Drawing.Size(83, 13);
            this.lblProjectNumber.TabIndex = 0;
            this.lblProjectNumber.Text = "Project Number:";
            // 
            // btnViewTasksPage
            // 
            this.btnViewTasksPage.Location = new System.Drawing.Point(897, 35);
            this.btnViewTasksPage.Name = "btnViewTasksPage";
            this.btnViewTasksPage.Size = new System.Drawing.Size(75, 23);
            this.btnViewTasksPage.TabIndex = 22;
            this.btnViewTasksPage.Text = "Page 2";
            this.btnViewTasksPage.UseVisualStyleBackColor = true;
            this.btnViewTasksPage.Click += new System.EventHandler(this.btnViewTasksPage_Click);
            // 
            // frmPrintProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(986, 817);
            this.Controls.Add(this.btnViewTasksPage);
            this.Controls.Add(this.dgvResources);
            this.Controls.Add(this.lblProjectResources);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlProjectDetails);
            this.Controls.Add(this.menuStripPrintProject);
            this.MainMenuStrip = this.menuStripPrintProject;
            this.Name = "frmPrintProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Project Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStripPrintProject.ResumeLayout(false);
            this.menuStripPrintProject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResources)).EndInit();
            this.pnlProjectDetails.ResumeLayout(false);
            this.pnlProjectDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripPrintProject;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvResources;
        private System.Windows.Forms.Label lblProjectResources;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlProjectDetails;
        private System.Windows.Forms.TextBox txtBoxCompletionDate;
        private System.Windows.Forms.Label lblActualCompletionDate;
        private System.Windows.Forms.TextBox txtBoxEstCompletionDate;
        private System.Windows.Forms.TextBox txtBoxStartDate;
        private System.Windows.Forms.ProgressBar progBarProjectProgress;
        private System.Windows.Forms.Label lblProjectProgess;
        private System.Windows.Forms.TextBox txtBoxProjectStatus;
        private System.Windows.Forms.Label lblProjectStatus;
        private System.Windows.Forms.TextBox txtBoxAccountManager;
        private System.Windows.Forms.Label lblAccountManager;
        private System.Windows.Forms.TextBox txtBoxProjectPhase;
        private System.Windows.Forms.Label lblProjectPhase;
        private System.Windows.Forms.TextBox txtBoxProjectType;
        private System.Windows.Forms.Label lblProjectType;
        private System.Windows.Forms.Label lblEstCompletionDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.TextBox txtBoxCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtBoxCustomerNumber;
        private System.Windows.Forms.Label lblCustomerNumber;
        private System.Windows.Forms.TextBox txtBoxProjectDescription;
        private System.Windows.Forms.Label lblProjectDescription;
        private System.Windows.Forms.TextBox txtBoxProjectName;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.TextBox txtBoxProjectNumber;
        private System.Windows.Forms.Label lblProjectNumber;
        private System.Windows.Forms.Button btnViewTasksPage;
    }
}