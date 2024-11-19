namespace MunicipalitityProgPoePart1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblUsernameDisplay = new System.Windows.Forms.Label();
            this.btnLogInSignIn = new System.Windows.Forms.Button();
            this.btnLocalEventsAnnoucmts = new System.Windows.Forms.Button();
            this.btnServiceRequestStatus = new System.Windows.Forms.Button();
            this.btnReportIssues = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnlMenu.Controls.Add(this.btnLogOut);
            this.pnlMenu.Controls.Add(this.lblUsernameDisplay);
            this.pnlMenu.Controls.Add(this.btnLogInSignIn);
            this.pnlMenu.Controls.Add(this.btnLocalEventsAnnoucmts);
            this.pnlMenu.Controls.Add(this.btnServiceRequestStatus);
            this.pnlMenu.Controls.Add(this.btnReportIssues);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(366, 762);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogOut.Location = new System.Drawing.Point(132, 597);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(89, 32);
            this.btnLogOut.TabIndex = 23;
            this.btnLogOut.Text = "LOGOUT";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblUsernameDisplay
            // 
            this.lblUsernameDisplay.AutoSize = true;
            this.lblUsernameDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameDisplay.ForeColor = System.Drawing.Color.White;
            this.lblUsernameDisplay.Location = new System.Drawing.Point(12, 18);
            this.lblUsernameDisplay.Name = "lblUsernameDisplay";
            this.lblUsernameDisplay.Size = new System.Drawing.Size(0, 29);
            this.lblUsernameDisplay.TabIndex = 22;
            // 
            // btnLogInSignIn
            // 
            this.btnLogInSignIn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogInSignIn.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnLogInSignIn.FlatAppearance.BorderSize = 0;
            this.btnLogInSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogInSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogInSignIn.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogInSignIn.Location = new System.Drawing.Point(96, 559);
            this.btnLogInSignIn.Name = "btnLogInSignIn";
            this.btnLogInSignIn.Size = new System.Drawing.Size(164, 32);
            this.btnLogInSignIn.TabIndex = 21;
            this.btnLogInSignIn.Text = "LOGIN  or SIGN IN";
            this.btnLogInSignIn.UseVisualStyleBackColor = false;
            this.btnLogInSignIn.Click += new System.EventHandler(this.btnLogInSignIn_Click);
            // 
            // btnLocalEventsAnnoucmts
            // 
            this.btnLocalEventsAnnoucmts.BackColor = System.Drawing.Color.Transparent;
            this.btnLocalEventsAnnoucmts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLocalEventsAnnoucmts.FlatAppearance.BorderSize = 0;
            this.btnLocalEventsAnnoucmts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalEventsAnnoucmts.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalEventsAnnoucmts.ForeColor = System.Drawing.Color.White;
            this.btnLocalEventsAnnoucmts.Image = ((System.Drawing.Image)(resources.GetObject("btnLocalEventsAnnoucmts.Image")));
            this.btnLocalEventsAnnoucmts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocalEventsAnnoucmts.Location = new System.Drawing.Point(3, 261);
            this.btnLocalEventsAnnoucmts.Name = "btnLocalEventsAnnoucmts";
            this.btnLocalEventsAnnoucmts.Size = new System.Drawing.Size(333, 60);
            this.btnLocalEventsAnnoucmts.TabIndex = 7;
            this.btnLocalEventsAnnoucmts.Text = "Local Events and Announcements";
            this.btnLocalEventsAnnoucmts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLocalEventsAnnoucmts.UseVisualStyleBackColor = false;
            this.btnLocalEventsAnnoucmts.Click += new System.EventHandler(this.btnLocalEventsAnnoucmts_Click);
            // 
            // btnServiceRequestStatus
            // 
            this.btnServiceRequestStatus.BackColor = System.Drawing.Color.Transparent;
            this.btnServiceRequestStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnServiceRequestStatus.FlatAppearance.BorderSize = 0;
            this.btnServiceRequestStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceRequestStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceRequestStatus.ForeColor = System.Drawing.Color.White;
            this.btnServiceRequestStatus.Image = ((System.Drawing.Image)(resources.GetObject("btnServiceRequestStatus.Image")));
            this.btnServiceRequestStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServiceRequestStatus.Location = new System.Drawing.Point(3, 180);
            this.btnServiceRequestStatus.Name = "btnServiceRequestStatus";
            this.btnServiceRequestStatus.Size = new System.Drawing.Size(333, 75);
            this.btnServiceRequestStatus.TabIndex = 6;
            this.btnServiceRequestStatus.Text = "Service Request Status";
            this.btnServiceRequestStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnServiceRequestStatus.UseVisualStyleBackColor = false;
            this.btnServiceRequestStatus.Click += new System.EventHandler(this.btnServiceRequestStatus_Click);
            // 
            // btnReportIssues
            // 
            this.btnReportIssues.BackColor = System.Drawing.Color.Transparent;
            this.btnReportIssues.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReportIssues.FlatAppearance.BorderSize = 0;
            this.btnReportIssues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportIssues.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportIssues.ForeColor = System.Drawing.Color.White;
            this.btnReportIssues.Image = ((System.Drawing.Image)(resources.GetObject("btnReportIssues.Image")));
            this.btnReportIssues.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportIssues.Location = new System.Drawing.Point(3, 113);
            this.btnReportIssues.Name = "btnReportIssues";
            this.btnReportIssues.Size = new System.Drawing.Size(333, 61);
            this.btnReportIssues.TabIndex = 5;
            this.btnReportIssues.Text = "Report Issues";
            this.btnReportIssues.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReportIssues.UseVisualStyleBackColor = false;
            this.btnReportIssues.Click += new System.EventHandler(this.btnReportIssues_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLogo.BackgroundImage")));
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(366, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(653, 134);
            this.pnlLogo.TabIndex = 4;
            // 
            // pnlMain
            // 
            this.pnlMain.BackgroundImage = global::MunicipalitityProgPoePart1.Properties.Resources.MainMenu;
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlMain.Location = new System.Drawing.Point(372, 145);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(635, 605);
            this.pnlMain.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1019, 762);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlMenu);
            this.MinimumSize = new System.Drawing.Size(866, 726);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnReportIssues;
        private System.Windows.Forms.Button btnServiceRequestStatus;
        private System.Windows.Forms.Button btnLocalEventsAnnoucmts;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Button btnLogInSignIn;
        private System.Windows.Forms.Label lblUsernameDisplay;
        private System.Windows.Forms.Button btnLogOut;
    }
}

