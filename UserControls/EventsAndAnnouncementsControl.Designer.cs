namespace MunicipalitityProgPoePart1.UserControls
{
    partial class EventsAndAnnouncementsControl
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
            this.lstEvents = new System.Windows.Forms.ListBox();
            this.lstAnnouncements = new System.Windows.Forms.ListBox();
            this.btnGoBack2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.dtpEventDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstEvents
            // 
            this.lstEvents.FormattingEnabled = true;
            this.lstEvents.Location = new System.Drawing.Point(14, 111);
            this.lstEvents.Name = "lstEvents";
            this.lstEvents.Size = new System.Drawing.Size(204, 95);
            this.lstEvents.TabIndex = 0;
            this.lstEvents.SelectedIndexChanged += new System.EventHandler(this.lstEvents_SelectedIndexChanged);
            // 
            // lstAnnouncements
            // 
            this.lstAnnouncements.FormattingEnabled = true;
            this.lstAnnouncements.Location = new System.Drawing.Point(14, 266);
            this.lstAnnouncements.Name = "lstAnnouncements";
            this.lstAnnouncements.Size = new System.Drawing.Size(204, 95);
            this.lstAnnouncements.TabIndex = 1;
            this.lstAnnouncements.SelectedIndexChanged += new System.EventHandler(this.lstAnnouncements_SelectedIndexChanged);
            // 
            // btnGoBack2
            // 
            this.btnGoBack2.BackColor = System.Drawing.Color.Gray;
            this.btnGoBack2.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnGoBack2.FlatAppearance.BorderSize = 0;
            this.btnGoBack2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack2.ForeColor = System.Drawing.Color.Transparent;
            this.btnGoBack2.Location = new System.Drawing.Point(14, 395);
            this.btnGoBack2.Name = "btnGoBack2";
            this.btnGoBack2.Size = new System.Drawing.Size(139, 32);
            this.btnGoBack2.TabIndex = 12;
            this.btnGoBack2.Text = "Go Back";
            this.btnGoBack2.UseVisualStyleBackColor = false;
            this.btnGoBack2.Click += new System.EventHandler(this.btnGoBack2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Upcoming Events";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Announcements";
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Location = new System.Drawing.Point(254, 163);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(204, 198);
            this.rtbDisplay.TabIndex = 15;
            this.rtbDisplay.Text = "";
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(14, 46);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(204, 21);
            this.cboCategory.TabIndex = 16;
            // 
            // dtpEventDate
            // 
            this.dtpEventDate.Location = new System.Drawing.Point(254, 47);
            this.dtpEventDate.Name = "dtpEventDate";
            this.dtpEventDate.Size = new System.Drawing.Size(204, 20);
            this.dtpEventDate.TabIndex = 17;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Transparent;
            this.btnSearch.Location = new System.Drawing.Point(319, 111);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(139, 32);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Filter Events";
            // 
            // EventsAndAnnouncementsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtpEventDate);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.rtbDisplay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGoBack2);
            this.Controls.Add(this.lstAnnouncements);
            this.Controls.Add(this.lstEvents);
            this.Name = "EventsAndAnnouncementsControl";
            this.Size = new System.Drawing.Size(474, 439);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstEvents;
        private System.Windows.Forms.ListBox lstAnnouncements;
        private System.Windows.Forms.Button btnGoBack2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.DateTimePicker dtpEventDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
    }
}
