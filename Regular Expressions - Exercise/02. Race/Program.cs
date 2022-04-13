using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] participantNames = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries);
            string command;

            var info = new Dictionary<string, double>();
            foreach (string participant in participantNames)
            {
                info.Add(participant.Trim(), 0);
            }

            while ((command = Console.ReadLine()) != "end of race")
            {
                char[] currCh = command.ToCharArray();

                double d = 0;
                string n = string.Empty;
                foreach (char ch in currCh)
                {
                    if (char.IsDigit(ch))
                    {
                        d += char.GetNumericValue(ch);
                    }
                    if (char.IsLetter(ch))
                    {
                        n += ch;
                    }
                }
                if (info.ContainsKey(n))
                {
                    info[n] += d;
                }
            }
            int counter = 0;
            info = info.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in info)
            {
                counter++;
                if (counter > 3)
                {
                    break;
                }
                else if (counter == 1)
                {
                    Console.WriteLine($"1st place: {item.Key}");
                }
                else if (counter == 2)
                {
                    Console.WriteLine($"2nd place: {item.Key}");
                }
                else if (counter == 3)
                {
                    Console.WriteLine($"3rd place: {item.Key}");
                }
                //Console.WriteLine(item.Key + " ran: " + item.Value);
            }
        }
    }
}
