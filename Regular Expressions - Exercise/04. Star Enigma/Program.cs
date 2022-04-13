using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _04._Star_Enigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patternForFirstStageDecryption = @"[sStTaArR]";

            string patternForEveryMessage = @"@(?<planetName>[A-Za-z]+)[^\@\-\!\:\>]*:(?<planetPopulation>\d+)[^\@\-\!\:\>]*\!(?<attackType>A|D)\![^\@\-\!\:\>]*->(?<soldierCount>\d+)";

            int numberOfMessages = int.Parse(Console.ReadLine());
            var destroyedList = new List<string>();
            var attackedList = new List<string>();

            for (int i = 0; i < numberOfMessages; i++)
            {
                string message = Console.ReadLine();

                MatchCollection matches = Regex.Matches(message, patternForFirstStageDecryption);
                int countOfSpecialChars = matches.Count;

                char[] messageToCharArray = message.ToCharArray();

                for (int j = 0; j < messageToCharArray.Length; j++)
                {
                    messageToCharArray[j] -= (char)countOfSpecialChars;
                }
                message = new string(messageToCharArray);

                Match match = Regex.Match(message, patternForEveryMessage);

                if (!match.Success)
                {
                    continue;
                }

                string planetName = match.Groups["planetName"].Value.Trim();
                string planetPopulation = match.Groups["planetPopulation"].Value.Trim();
                string attackType = match.Groups["attackType"].Value.Trim();
                string soldierCount = match.Groups["soldierCount"].Value.Trim();

                if (attackType == "A")
                {
                    attackedList.Add(planetName);
                }
                else if (attackType == "D")
                {
                    destroyedList.Add(planetName);
                }
            }

            attackedList.Sort();
            destroyedList.Sort();

            Console.WriteLine($@"Attacked planets: {attackedList.Count}");
            foreach (var attacked in attackedList)
            {
                Console.WriteLine($"-> {attacked}");
            }
            Console.WriteLine($@"Destroyed planets: {destroyedList.Count}");
            foreach (var destroyed in destroyedList)
            {
                Console.WriteLine($"-> {destroyed}");
            }

        }
    }
}
