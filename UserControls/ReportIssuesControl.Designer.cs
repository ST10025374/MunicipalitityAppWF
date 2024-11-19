namespace MunicipalitityProgPoePart1
{
    partial class ReportIssuesControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCategorySelection = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbDescriptionBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSubmitIssue = new System.Windows.Forms.Button();
            this.btnUploadImg = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pbDisplay = new System.Windows.Forms.PictureBox();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.pgBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter location of issue";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(18, 33);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(328, 20);
            this.txtLocation.TabIndex = 1;
            this.txtLocation.TextChanged += new System.EventHandler(this.txtLocation_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select issue category";
            // 
            // cbCategorySelection
            // 
            this.cbCategorySelection.FormattingEnabled = true;
            this.cbCategorySelection.Items.AddRange(new object[] {
            "Public Safety",
            "Health and Sanitation",
            "Infrastructure and Roadway",
            "Waste Management",
            "Transportation and Traffic",
            "Noise and Nuisance",
            "Animal and Wildlife",
            "Parking and Vehicle-Related"});
            this.cbCategorySelection.Location = new System.Drawing.Point(18, 89);
            this.cbCategorySelection.Name = "cbCategorySelection";
            this.cbCategorySelection.Size = new System.Drawing.Size(328, 21);
            this.cbCategorySelection.TabIndex = 3;
            this.cbCategorySelection.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Describe the issue in less than 50 words";
            // 
            // rtbDescriptionBox
            // 
            this.rtbDescriptionBox.Location = new System.Drawing.Point(18, 149);
            this.rtbDescriptionBox.Name = "rtbDescriptionBox";
            this.rtbDescriptionBox.Size = new System.Drawing.Size(328, 67);
            this.rtbDescriptionBox.TabIndex = 5;
            this.rtbDescriptionBox.Text = "";
            this.rtbDescriptionBox.TextChanged += new System.EventHandler(this.rtbDescription_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Upload an image of issue or anyfile ";
            // 
            // btnSubmitIssue
            // 
            this.btnSubmitIssue.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSubmitIssue.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnSubmitIssue.FlatAppearance.BorderSize = 0;
            this.btnSubmitIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitIssue.ForeColor = System.Drawing.Color.Transparent;
            this.btnSubmitIssue.Location = new System.Drawing.Point(207, 474);
            this.btnSubmitIssue.Name = "btnSubmitIssue";
            this.btnSubmitIssue.Size = new System.Drawing.Size(139, 32);
            this.btnSubmitIssue.TabIndex = 7;
            this.btnSubmitIssue.Text = "Submit Issue";
            this.btnSubmitIssue.UseVisualStyleBackColor = false;
            this.btnSubmitIssue.Click += new System.EventHandler(this.btnSubmitIssue_Click);
            // 
            // btnUploadImg
            // 
            this.btnUploadImg.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnUploadImg.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnUploadImg.FlatAppearance.BorderSize = 0;
            this.btnUploadImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImg.ForeColor = System.Drawing.Color.Transparent;
            this.btnUploadImg.Location = new System.Drawing.Point(256, 291);
            this.btnUploadImg.Name = "btnUploadImg";
            this.btnUploadImg.Size = new System.Drawing.Size(69, 63);
            this.btnUploadImg.TabIndex = 8;
            this.btnUploadImg.Text = "Click to upload";
            this.btnUploadImg.UseVisualStyleBackColor = false;
            this.btnUploadImg.Click += new System.EventHandler(this.btnUploadImg_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(310, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Check if all info is correct before submitting";
            // 
            // pbDisplay
            // 
            this.pbDisplay.Location = new System.Drawing.Point(19, 258);
            this.pbDisplay.Name = "pbDisplay";
            this.pbDisplay.Size = new System.Drawing.Size(196, 137);
            this.pbDisplay.TabIndex = 10;
            this.pbDisplay.TabStop = false;
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.Gray;
            this.btnGoBack.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnGoBack.FlatAppearance.BorderSize = 0;
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.ForeColor = System.Drawing.Color.Transparent;
            this.btnGoBack.Location = new System.Drawing.Point(18, 474);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(139, 32);
            this.btnGoBack.TabIndex = 11;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // pgBar
            // 
            this.pgBar.Location = new System.Drawing.Point(18, 430);
            this.pgBar.Margin = new System.Windows.Forms.Padding(2);
            this.pgBar.Name = "pgBar";
            this.pgBar.Size = new System.Drawing.Size(328, 28);
            this.pgBar.TabIndex = 12;
            // 
            // ReportIssuesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pgBar);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.pbDisplay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnUploadImg);
            this.Controls.Add(this.btnSubmitIssue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtbDescriptionBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCategorySelection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.label1);
            this.Name = "ReportIssuesControl";
            this.Size = new System.Drawing.Size(361, 524);
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCategorySelection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbDescriptionBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSubmitIssue;
        private System.Windows.Forms.Button btnUploadImg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbDisplay;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.ProgressBar pgBar;
    }
}
