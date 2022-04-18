using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace _02._Easter_Eggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var eggsDict = new Dictionary<string, int>();

            //var sb = new StringBuilder();

            string input = Console.ReadLine();

            string wholeStringPattern = @"(@|#)+[a-z]{3,}(@|#)+[^A-Za-z0-9]*\/+\d+\/+";
            string colorPattern = @"[a-z]+";
            string amountPattern = @"\d+";

            MatchCollection matchesColorAndAmount = Regex.Matches(input, wholeStringPattern);

            foreach(Match match in matchesColorAndAmount)
            {
                Match color = Regex.Match(match.Value, colorPattern);
                Match amount = Regex.Match(match.Value, amountPattern);

                Console.WriteLine($"You found {amount} {color} eggs!");
            }

            //MatchCollection matchesColor = Regex.Matches(sb.ToString(), colorPattern);
            //MatchCollection matchesAmount = Regex.Matches(sb.ToString(), amountPattern);

        }
    }
}
