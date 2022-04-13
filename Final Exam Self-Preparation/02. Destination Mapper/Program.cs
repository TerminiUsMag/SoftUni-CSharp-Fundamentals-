using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _02._Destination_Mapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([=|\/])[A-Z][A-Za-z]{2,}\1";
            string pattern2 = @"[A-Z][A-Za-z]{2,}";

            string input = Console.ReadLine();
            int points = 0;

            List<string> validDestinations = new List<string>();

            MatchCollection matches = Regex.Matches(input, pattern);
            matches = Regex.Matches(string.Join(' ',matches), pattern2);

            foreach (Match match in matches)
            {
                points += match.Value.Length;
            }

            Console.WriteLine($"Destinations: {string.Join(", ", matches)}");
            Console.WriteLine($"Travel Points: {points}");



        }
    }
}
