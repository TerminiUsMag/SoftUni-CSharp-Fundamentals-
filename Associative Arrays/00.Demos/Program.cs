using System;
using System.Collections.Generic;

namespace _00.Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            phoneBook.Add("Nikolai", "0888001882");
            phoneBook["Ivan"] = "345678987654";
            phoneBook["Maria"] = "7539514";
            Console.WriteLine(phoneBook.Keys);
            foreach(var item in phoneBook)
            {
                Console.WriteLine($"\nName : {item.Key} \n Phone Number : {item.Value}\n\n");
            }

        }
    }
}
