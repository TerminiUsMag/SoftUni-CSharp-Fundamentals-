using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> usernames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> notValidUsernames = new List<string>();

            foreach (string username in usernames)
            {
                if (username.Length < 3 || username.Length > 16)
                {
                    notValidUsernames.Add(username);
                }
                foreach (char c in username)
                {
                    if (!char.IsDigit(c) && !char.IsLetter(c) && !(c == '_') && !(c == '-'))
                    {
                        notValidUsernames.Add(username);
                        continue;
                    }
                }
            }
            for(int i = 0; i < notValidUsernames.Count; i++)
            {
                usernames.Remove(notValidUsernames[i]);
            }

            Console.WriteLine(String.Join("\n", usernames));

        }
    }
}
