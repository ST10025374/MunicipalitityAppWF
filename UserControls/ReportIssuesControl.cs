using MunicipalitityProgPoePart1.Classes;
using System;
using System.IO;
using System.Windows.Forms;

namespace MunicipalitityProgPoePart1
{
    public partial class ReportIssuesControl : UserControl
    {
        /// <summary>
        /// Event to send data to Form1
        /// </summary>
        public event EventHandler<IssueClass> SubmitIssue;

        /// <summary>
        /// Stores the file path of the issue
        /// </summary>
        private string filePath = string.Empty;

        /// <summary>
        /// Stores the file data of the issue
        /// </summary>
        private byte[] fileData = null;

        //---------------------------------------------------------------------//
        /// <summary>
        /// Default Constructor
        /// Initializes the progress bar value to 0
        /// </summary>
        public ReportIssuesControl()
        {
            InitializeComponent();
            pgBar.Value = 0;
        }

        //---------------------------------------------------------------------//
        /// <summary>
        /// Hid the ReportIssuesControl when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HideButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //---------------------------------------------------------------------//
        /// <summary>
        /// Button Click Event to Upload Image
        /// Allow any file type
        /// Read file content as byte array
        /// Create an IssueClass instance and store file details
        /// Store file data
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">The event arguments</param>
        private void btnUploadImg_Click(object sender, System.EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "All Files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    try
                    {
                        fileData = File.ReadAllBytes(filePath);

                        // For display purposes, update the PictureBox if the file is an image.
                        if (IsImageFile(filePath))
                        {
                            pbDisplay.SizeMode = PictureBoxSizeMode.StretchImage;
                            pbDisplay.Image = System.Drawing.Image.FromFile(filePath);
                        }

                        MessageBox.Show($"File '{Path.GetFileName(filePath)}' uploaded successfully.",
                                        "Upload Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UpdateProgress();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error uploading file: {ex.Message}",
                                        "Upload Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        filePath = string.Empty;
                        fileData = null;
                    }
                }
            }
        }

        //---------------------------------------------------------------------//
        /// <summary>
        /// Add the IsImageFile method to the ReportIssuesControl class
        /// </summary>
        /// <param name="filePath">The file path of the image</param>
        /// <returns>True if the file is an image, False otherwise</returns>
        private bool IsImageFile(string filePath)
        {
            string ext = Path.GetExtension(filePath).ToLower();
            return ext == ".jpg" || ext == ".jpeg" || ext == ".png" || ext == ".bmp";
        }

        //---------------------------------------------------------------------//
        /// <summary>
        /// Method to Validate Input
        /// </summary>
        /// <returns></returns>
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("Location field is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLocation.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cbCategorySelection.Text))
            {
                MessageBox.Show("Please select a category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbCategorySelection.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(rtbDescriptionBox.Text))
            {
                MessageBox.Show("Description field is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rtbDescriptionBox.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(filePath) || fileData == null)
            {
                MessageBox.Show("Please upload a file.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        //---------------------------------------------------------------------//
        /// <summary>
        /// Method to Get Issue Data
        /// Returns the data in a structured form
        /// Read the file content into a byte array
        /// Assuming imgPath now holds the selected file path
        /// </summary>
        /// <returns>IssueClass instance with all data fields populated</returns>
        /// <exception cref="Exception">Thrown if file reading fails</exception>
        public IssueClass GetIssueData()
        {
            if (!ValidateInput())
            {
                return null;
            }

            return new IssueClass
            {
                Location = txtLocation.Text,
                Category = cbCategorySelection.Text,
                Description = rtbDescriptionBox.Text,
                FilePath = filePath,
                FileName = Path.GetFileName(filePath),
                FileData = fileData
            };
        }

        //---------------------------------------------------------------------//
        /// <summary>
        /// Button Click Event to Submit Issue
        /// Raise the event with the captured data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmitIssue_Click(object sender, EventArgs e)
        {
            var data = GetIssueData();

            if (data == null)
            {
                return;
            }
            else
            {
                SubmitIssue?.Invoke(this, data);
                ClearInputFields();           
                MessageBox.Show("Issue Submitted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pgBar.Value = 0;
            }    
        }

        //---------------------------------------------------------------------//
        /// <summary>
        /// Clears the input fields.
        /// </summary>
        public void ClearInputFields()
        {
            txtLocation.Text = string.Empty;
            cbCategorySelection.Text = string.Empty;
            rtbDescriptionBox.Text = string.Empty;
            filePath = string.Empty;
            fileData = null;
            pbDisplay.Image = null;
        }

        //---------------------------------------------------------------------//
        /// <summary>
        /// Button to hide Usercontrol from Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //---------------------------------------------------------------------//
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLocation_TextChanged(object sender, EventArgs e)
        {
            UpdateProgress();
        }

        //---------------------------------------------------------------------//
        /// <summary>
        /// Progress bar logic for user category selection.
        /// </summary>
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProgress();
        }

        //---------------------------------------------------------------------//
        /// <summary>
        /// Progress bar logic for user description input.
        /// </summary>
        private void rtbDescription_TextChanged(object sender, EventArgs e)
        {
            UpdateProgress();
        }

        //---------------------------------------------------------------------//
        /// <summary>
        /// Validates the input and updates the progress bar
        /// </summary>
        private void UpdateProgress()
        {
            int progress = 0;
            if (!string.IsNullOrWhiteSpace(txtLocation.Text)) progress += 25;
            if (!string.IsNullOrWhiteSpace(cbCategorySelection.Text)) progress += 25;
            if (!string.IsNullOrWhiteSpace(rtbDescriptionBox.Text)) progress += 25;
            if (!string.IsNullOrEmpty(filePath)) progress += 25;

            pgBar.Value = progress;
        }
    }
}
//**------------------------------------------------------------< END >------------------------------------------------------------**// 