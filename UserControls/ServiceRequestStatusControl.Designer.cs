namespace MunicipalitityProgPoePart1.UserControls
{
    partial class ServiceRequestStatusControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnSearch;
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lstDependencies = new System.Windows.Forms.ListBox();
            this.lstServiceRequests = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlGraph = new System.Windows.Forms.Panel();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnDrawGraph = new System.Windows.Forms.Button();
            this.btnGoBack2 = new System.Windows.Forms.Button();
            btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(27, 38);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(84, 20);
            this.txtSearch.TabIndex = 3;
            // 
            // lstDependencies
            // 
            this.lstDependencies.Location = new System.Drawing.Point(440, 227);
            this.lstDependencies.Margin = new System.Windows.Forms.Padding(2);
            this.lstDependencies.Name = "lstDependencies";
            this.lstDependencies.Size = new System.Drawing.Size(117, 147);
            this.lstDependencies.TabIndex = 7;
            // 
            // lstServiceRequests
            // 
            this.lstServiceRequests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colDate,
            this.colStatus,
            this.colDescription});
            this.lstServiceRequests.FullRowSelect = true;
            this.lstServiceRequests.GridLines = true;
            this.lstServiceRequests.HideSelection = false;
            this.lstServiceRequests.Location = new System.Drawing.Point(27, 79);
            this.lstServiceRequests.Margin = new System.Windows.Forms.Padding(2);
            this.lstServiceRequests.Name = "lstServiceRequests";
            this.lstServiceRequests.Size = new System.Drawing.Size(530, 129);
            this.lstServiceRequests.TabIndex = 8;
            this.lstServiceRequests.UseCompatibleStateImageBehavior = false;
            this.lstServiceRequests.View = System.Windows.Forms.View.Details;
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 100;
            // 
            // colDate
            // 
            this.colDate.Text = "Date Submitted";
            this.colDate.Width = 150;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            this.colStatus.Width = 100;
            // 
            // colDescription
            // 
            this.colDescription.Text = "Description";
            this.colDescription.Width = 350;
            // 
            // pnlGraph
            // 
            this.pnlGraph.BackColor = System.Drawing.Color.LightGray;
            this.pnlGraph.Location = new System.Drawing.Point(116, 227);
            this.pnlGraph.Margin = new System.Windows.Forms.Padding(2);
            this.pnlGraph.Name = "pnlGraph";
            this.pnlGraph.Size = new System.Drawing.Size(304, 247);
            this.pnlGraph.TabIndex = 11;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = System.Drawing.SystemColors.HotTrack;
            btnSearch.Cursor = System.Windows.Forms.Cursors.AppStarting;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnSearch.ForeColor = System.Drawing.Color.Transparent;
            btnSearch.Location = new System.Drawing.Point(131, 30);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(117, 32);
            btnSearch.TabIndex = 21;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Gray;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnShow.FlatAppearance.BorderSize = 0;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.Transparent;
            this.btnShow.Location = new System.Drawing.Point(440, 392);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(117, 32);
            this.btnShow.TabIndex = 22;
            this.btnShow.Text = "Show ";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnDrawGraph
            // 
            this.btnDrawGraph.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnDrawGraph.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnDrawGraph.FlatAppearance.BorderSize = 0;
            this.btnDrawGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrawGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrawGraph.ForeColor = System.Drawing.Color.Transparent;
            this.btnDrawGraph.Location = new System.Drawing.Point(27, 227);
            this.btnDrawGraph.Name = "btnDrawGraph";
            this.btnDrawGraph.Size = new System.Drawing.Size(70, 56);
            this.btnDrawGraph.TabIndex = 23;
            this.btnDrawGraph.Text = "Draw Graph";
            this.btnDrawGraph.UseVisualStyleBackColor = false;
            this.btnDrawGraph.Click += new System.EventHandler(this.btnDrawGraph_Click);
            // 
            // btnGoBack2
            // 
            this.btnGoBack2.BackColor = System.Drawing.Color.Gray;
            this.btnGoBack2.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnGoBack2.FlatAppearance.BorderSize = 0;
            this.btnGoBack2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack2.ForeColor = System.Drawing.Color.Transparent;
            this.btnGoBack2.Location = new System.Drawing.Point(27, 425);
            this.btnGoBack2.Name = "btnGoBack2";
            this.btnGoBack2.Size = new System.Drawing.Size(62, 49);
            this.btnGoBack2.TabIndex = 24;
            this.btnGoBack2.Text = "Go Back";
            this.btnGoBack2.UseVisualStyleBackColor = false;
            this.btnGoBack2.Click += new System.EventHandler(this.btnGoBack2_Click);
            // 
            // ServiceRequestStatusControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGoBack2);
            this.Controls.Add(this.btnDrawGraph);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(btnSearch);
            this.Controls.Add(this.pnlGraph);
            this.Controls.Add(this.lstServiceRequests);
            this.Controls.Add(this.lstDependencies);
            this.Controls.Add(this.txtSearch);
            this.Name = "ServiceRequestStatusControl";
            this.Size = new System.Drawing.Size(578, 494);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox lstDependencies;
        private System.Windows.Forms.ListView lstServiceRequests;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.ColumnHeader colDescription;
        private System.Windows.Forms.Panel pnlGraph;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnDrawGraph;
        private System.Windows.Forms.Button btnGoBack2;
    }
}
