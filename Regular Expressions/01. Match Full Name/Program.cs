﻿using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b([A-Z][a-z]+) ([A-Z][a-z]+)\b";

            string names = Console.ReadLine();

            MatchCollection matchedNames = Regex.Matches(names, regex);

            foreach (Match m in matchedNames)
            {
                Console.Write(m.Value + " ");
            }

            Console.WriteLine();
        }
    }
}
