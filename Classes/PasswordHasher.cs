using System;
using System.Security.Cryptography;
using System.Text;

namespace MunicipalitityProgPoePart1.Classes
{
    public class PasswordHasher
    {
        //---------------------------------------------------------------------//
        /// <summary>
        /// Method to generate a salt
        /// </summary>
        /// <returns></returns>
        public static string GenerateSalt()
        {
            byte[] saltBytes = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(saltBytes);
            }
            return Convert.ToBase64String(saltBytes);
        }
        
        //---------------------------------------------------------------------//
        /// <summary>
        /// Method to hash a password
        /// </summary>
        /// <param name="password"></param>
        /// <param name="salt"></param>
        /// <returns></returns>
        public static string HashPassword(string password, string salt)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] saltedPasswordBytes = Encoding.UTF8.GetBytes(password + salt);
                byte[] hashBytes = sha256.ComputeHash(saltedPasswordBytes);
                return Convert.ToBase64String(hashBytes);
            }
        }
    }
}
//**------------------------------------------------------------< END >------------------------------------------------------------**// 