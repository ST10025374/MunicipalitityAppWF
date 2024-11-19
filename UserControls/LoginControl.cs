using MunicipalitityProgPoePart1.Classes;
using System;
using System.Windows.Forms;

namespace MunicipalitityProgPoePart1.UserControls
{
    public partial class LoginControl : UserControl
    {
        /// <summary>
        /// Stores the User Manager
        /// </summary>
        private UserManager userManager;

        /// <summary>
        /// Event to notify a successful login, useful 
        /// for navigating to other parts of the application.
        /// </summary>
        public event EventHandler<UserClass> LoginSuccess;

        //---------------------------------------------------------------------//
        /// <summary>
        /// Default constructor
        /// </summary>
        public LoginControl()
        {
            InitializeComponent();
            userManager = new UserManager();
        }               

        //---------------------------------------------------------------------//
        /// <summary>
        /// Button click event to login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool loginSuccess = userManager.LoginUser(username, password);
            if (loginSuccess)
            {
                var user = new UserClass(username);
                LoginSuccess?.Invoke(this, user);  // Raise the event immediately upon success
                ClearFields();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //---------------------------------------------------------------------//
        /// <summary>
        /// Button click event to register
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool registerSuccess = userManager.RegisterUser(username, password);
            if (registerSuccess)
            {
                MessageBox.Show("Registration successful! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            else
            {
                MessageBox.Show("Username already exists. Please choose a different username.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //---------------------------------------------------------------------//
        /// <summary>
        /// Clears the input fields for better user experience.
        /// </summary>
        private void ClearFields()
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }
    }
}
//**------------------------------------------------------------< END >------------------------------------------------------------**// 