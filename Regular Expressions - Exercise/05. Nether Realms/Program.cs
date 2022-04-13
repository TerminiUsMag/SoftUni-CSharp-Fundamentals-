using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _05._Nether_Realms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<List<string>> listOfDemons = new List<List<string>>();

            SortedDictionary<string, List<double>> listOfDemonsDictionary = new SortedDictionary<string, List<double>>();


            string[] inputSplit = input
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .OrderBy(x => x)
                .ToArray();

            //string patternHealth = @"[A-za-z]";
            string patternHealth = @"[^\+\-\*\/\.\d\s]";
            string patternDamage = @"(\-|\+)?\d+(\.?\d*)?";
            string patternDamageMultiplyOrDivide = @"(\/|\*)";

            for (int i = 0; i < inputSplit.Length; i++)
            {
                //List<string> demon = new List<string>();
                //demon.Add(inputSplit[i]);
                //listOfDemons.Add(demon);

                List<double> demonList = new List<double>();
                listOfDemonsDictionary.Add(inputSplit[i], demonList);

                MatchCollection matchesForHealth = Regex.Matches(inputSplit[i], patternHealth);

                int calculatedHealth = 0;
                foreach (Match match in matchesForHealth)
                {
                    char currChar = char.Parse(match.Value);
                    calculatedHealth += currChar;
                }

                MatchCollection matchesForDamage = Regex.Matches(inputSplit[i], patternDamage);

                double calculatedDamage = 0;
                foreach (Match matchDamage in matchesForDamage)
                {
                    double currDigit = double.Parse(matchDamage.Value);
                    calculatedDamage += currDigit;
                }

                MatchCollection matchesForDamageMultiplyOrDivide = Regex.Matches(inputSplit[i], patternDamageMultiplyOrDivide);
                if (matchesForDamageMultiplyOrDivide.Count > 0 && calculatedDamage != 0)
                {

                    foreach (Match matchMultiplyOrDivide in matchesForDamageMultiplyOrDivide)
                    {
                        char currCh = char.Parse(matchMultiplyOrDivide.Value);
                        if (currCh == '/')
                        {
                            calculatedDamage /= 2;
                        }
                        else
                        {
                            calculatedDamage *= 2;
                        }
                    }
                }

                //listOfDemons[i].Add(calculatedHealth.ToString());
                //listOfDemons[i].Add(calculatedDamage.ToString());

                listOfDemonsDictionary[inputSplit[i]].Add(calculatedHealth);
                listOfDemonsDictionary[inputSplit[i]].Add(calculatedDamage);
            }
            foreach (var demon in listOfDemonsDictionary)
            {

                /*"{demon name} - {health points} health, {damage points} damage"*/

                Console.WriteLine($"{demon.Key} - {demon.Value[0]} health, {demon.Value[1]:f2} damage");
            }


        }
    }
}
