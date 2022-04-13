using System;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "", inputPassword = "";
            int n = 0;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            inputPassword = Console.ReadLine();
            while (inputPassword != password)
            {

                if (n != 3)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    n++;
                }
                else
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                inputPassword = Console.ReadLine();

            }
            if (password == inputPassword)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
