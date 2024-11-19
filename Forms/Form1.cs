using MunicipalitityProgPoePart1.Classes;
using MunicipalitityProgPoePart1.UserControls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MunicipalitityProgPoePart1
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// List to store the issues data
        /// </summary>
        private List<IssueClass> issuesList = new List<IssueClass>();

        /// <summary>
        /// ReportIssuesControl variable
        /// </summary>
        private ReportIssuesControl reportIssuesControl;

        /// <summary>
        /// LoginControl variable
        /// </summary>
        private LoginControl loginControl;

        /// <summary>
        /// Control for displaying events and announcements.
        /// </summary>
        private EventsAndAnnouncementsControl eventsAndAnnouncementsControl;

        /// <summary>
        /// Track login status
        /// </summary>
        private bool isLoggedIn = false; 

        //---------------------------------------------------------------------//
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        //---------------------------------------------------------------------//
        /// <summary>
        /// Event handler for the IssueSubmitted event
        /// Add the submitted issue to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSubmitIssue(object sender, IssueClass issue)
        {
            this.issuesList.Add(issue);
        }

        //---------------------------------------------------------------------//
        /// <summary>
        /// Button takes user to Report Issues Form
        /// Subscribe to the SubmitIssue event from the UserControl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReportIssues_Click(object sender, System.EventArgs e)
        {
            if (this.isLoggedIn.Equals(true))
            {
                var reportIssuesControl = new ReportIssuesControl();
            
                reportIssuesControl.SubmitIssue += OnSubmitIssue; 
                reportIssuesControl.Visible = true;

                pnlMain.Controls.Clear();
                pnlMain.Dock = DockStyle.None;
                pnlMain.Controls.Add(reportIssuesControl);               
            }
            else
            {
                MessageBox.Show("Please log in to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }           
        }

        //---------------------------------------------------------------------//
        /// <summary>
        /// Event handler for the LoginSuccess event
        /// User is now logged in
        /// Remove LoginControl
        /// Initialize main application controls
        /// Changle label with message to welcome user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnLoginSuccess(object sender, UserClass user)
        {
            this.isLoggedIn = true; 
            this.Controls.Remove(this.loginControl);  
            
            lblUsernameDisplay.Text = "Welcome " + user.Username;

            MessageBox.Show("Login successful! Welcome to the Municipal " +
                            "Services Application.", "Login Success", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //---------------------------------------------------------------------//
        /// <summary>
        /// Button click event to Log In or Sign In 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogInSignIn_Click(object sender, EventArgs e)
        {
            var loginControl = new LoginControl();
            
            loginControl.LoginSuccess += OnLoginSuccess;
            loginControl.Visible = true;

            pnlMain.Controls.Clear();
            pnlMain.Dock = DockStyle.None;
            pnlMain.Controls.Add(loginControl);
        }

        //---------------------------------------------------------------------//
        /// <summary>
        /// Button click event to Log Out
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if(this.isLoggedIn.Equals(false))
            {   
                return;
            }
            else
            {
                this.isLoggedIn = false;

                lblUsernameDisplay.Text = string.Empty;

                pnlMain.Controls.Clear();

                MessageBox.Show("Logout successful!", "You Logged Out",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }   
        }

        //---------------------------------------------------------------------//
        /// <summary>
        /// Button click event to view Local Events and Announcements
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLocalEventsAnnoucmts_Click(object sender, EventArgs e)
        {
            if (this.isLoggedIn.Equals(true))
            {
                var eventsAndAnnouncementsControl = new EventsAndAnnouncementsControl();

                pnlMain.Controls.Clear();
                pnlMain.Dock = DockStyle.None;
                pnlMain.Controls.Add(eventsAndAnnouncementsControl);
            }
            else
            {
                MessageBox.Show("Please log in to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //---------------------------------------------------------------------//
        /// <summary>
        /// Button click event to view Service Request Status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnServiceRequestStatus_Click(object sender, EventArgs e)
        {
            if (this.isLoggedIn.Equals(true))
            {
                var serviceRequestStatusControl = new ServiceRequestStatusControl();

                pnlMain.Controls.Clear();
                pnlMain.Dock = DockStyle.None;
                pnlMain.Controls.Add(serviceRequestStatusControl);
            }
            else
            {
                MessageBox.Show("Please log in to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
//**------------------------------------------------------------< END >------------------------------------------------------------**// 