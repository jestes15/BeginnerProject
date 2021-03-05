using System;
using System.Security.Cryptography;
using System.Text;

namespace BeginnersProject
{
    public class UtilityFunctions
    {
        /// <summary>
        /// Method <c>Output</c> used for keeping all string that are used in the program
        /// Allows for multiple uses across the program and in different methods. 
        /// </summary>
        /// <param name="userChoice"></param>
        /// <param name="username"></param>
        /// <returns></returns>
        public static string Output(int userChoice, string username=null)
        {
            
            switch (userChoice)
            {
                case 1:
                    return "What is your username?";
                case 2:
                    return "What is your password?";
                case 3:
                    return $"Hello {username}";
                default:
                    return "INVALID";
            }
        }
        
        public static String sha256_hash(String value) {
            StringBuilder sb = new StringBuilder();

            using (SHA256 hash = SHA256Managed.Create()) {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(value));

                foreach (Byte b in result)
                    sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }
    }
}