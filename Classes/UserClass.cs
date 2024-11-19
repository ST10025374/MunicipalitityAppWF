namespace MunicipalitityProgPoePart1.Classes
{
    public class UserClass
    {
        /// <summary>
        /// Store Username
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Store PasswordHash
        /// </summary>
        public string PasswordHash { get; set; }

        /// <summary>
        /// Store Salt
        /// </summary>
        public string Salt { get; set; }

        //---------------------------------------------------------------------//   
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="username"></param>
        /// <param name="passwordHash"></param>
        /// <param name="salt"></param>
        public UserClass(string username, string passwordHash, string salt)
        {
            Username = username;
            PasswordHash = passwordHash;
            Salt = salt;
        }

        /// <summary>
        /// Constructor for creating a new user
        /// </summary>
        /// <param name="username"></param>
        /// <param name="passwordHash"></param>
        /// <param name="salt"></param>
        public UserClass(string username)
        {
            Username = username;
        }
    }
}
//**------------------------------------------------------------< END >------------------------------------------------------------**// 