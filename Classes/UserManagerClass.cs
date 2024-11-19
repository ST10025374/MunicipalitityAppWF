using MunicipalitityProgPoePart1.Classes;
using System;
using System.Collections.Generic;
using System.IO;

public class UserManager
{
    /// <summary>
    /// Stores the list of users
    /// </summary>
    private Dictionary<string, UserClass> usersList = new Dictionary<string, UserClass>();

    /// <summary>
    /// Stores the file path
    /// </summary>
    private readonly string filePath = "users.txt";

    //---------------------------------------------------------------------//
    /// <summary>
    /// Default constructor
    /// </summary>
    public UserManager()
    {
        LoadUsersFromFile();
    }

    //---------------------------------------------------------------------//
    /// <summary>
    /// Method to register a user
    /// </summary>
    /// <param name="username"></param>
    /// <param name="password"></param>
    /// <returns></returns>
    public bool RegisterUser(string username, string password)
    {
        if (usersList.ContainsKey(username))
        {
            Console.WriteLine("Username already exists.");
            return false;
        }

        string salt = PasswordHasher.GenerateSalt();
        string passwordHash = PasswordHasher.HashPassword(password, salt);

        UserClass newUser = new UserClass(username, passwordHash, salt);
        usersList[username] = newUser;

        SaveUsersToFile();
        Console.WriteLine("User registered successfully.");
        return true;
    }

    //---------------------------------------------------------------------//
    /// <summary>
    /// Method to login a user
    /// </summary>
    /// <param name="username"></param>
    /// <param name="password"></param>
    /// <returns></returns>
    public bool LoginUser(string username, string password)
    {
        if (usersList.TryGetValue(username, out UserClass user))
        {
            string hashedPassword = PasswordHasher.HashPassword(password, user.Salt);
            if (hashedPassword == user.PasswordHash)
            {
                Console.WriteLine("Login successful.");
                return true;
            }
        }

        Console.WriteLine("Invalid username or password.");
        return false;
    }

    //---------------------------------------------------------------------//
    /// <summary>
    /// Method to save users to file
    /// </summary>
    private void SaveUsersToFile()
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var user in usersList.Values)
            {
                writer.WriteLine($"{user.Username}:{user.PasswordHash}:{user.Salt}");
            }
        }
    }

    //---------------------------------------------------------------------//
    /// <summary>
    /// Method to load users from file
    /// </summary>
    private void LoadUsersFromFile()
    {
        if (!File.Exists(filePath)) return;

        foreach (string line in File.ReadAllLines(filePath))
        {
            var parts = line.Split(':');
            if (parts.Length == 3)
            {
                string username = parts[0];
                string passwordHash = parts[1];
                string salt = parts[2];
                usersList[username] = new UserClass(username, passwordHash, salt);
            }
        }
    }
}
//**------------------------------------------------------------< END >------------------------------------------------------------**// 