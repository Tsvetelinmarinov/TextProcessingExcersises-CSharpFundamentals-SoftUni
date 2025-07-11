///
/// 01.ValidUsernames
/// 

using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ValidUsernames
{
    class Program
    {
        static void Main()
        {         
            Validator.ValidateAndPrint(
                Console.ReadLine()!
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList()
            );
        }
    }

    /// <summary>
        ///  Provides static methods to check if given username is valid or not.
        /// </summary>
    internal class Validator
    {
        /// <summary>
            ///  Check if <param name="username"> is valid or not.
            /// </summary>
            /// <param name="username">The username as string</param>
            /// <returns>True if the username is valid otherwise False</returns>
            /// 
            ///  A valid username has length between 3 and 16 characters and contains only letters, numbers, hyphens and underscores
        private static bool IsValid(string username)
                => username.Length >= 3 && username.Length <= 16 &&
                    Array.TrueForAll(username.ToCharArray(), s => s.Equals('_') || s.Equals('-') || char.IsLetter(s) || char.IsDigit(s));

        /// <summary>
            ///  Validates and prints on the console the valid usernames from the list
            /// </summary>
            /// <param name="usernames">The list of usernames to validate</param>
        public static void ValidateAndPrint(List<string> usernames)
                => usernames.Where(IsValid)
                    .ToList()
                    .ForEach(Console.WriteLine);
    }
}
