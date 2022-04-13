using System;

namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] path = Console.ReadLine().Split('\\', StringSplitOptions.RemoveEmptyEntries);

            string file = string.Empty;

            foreach(string s in path)
            {
                if (s.Contains("."))
                {
                    file = s;
                }
            }

            string[] fileNameAndExt = file.Split('.');
            string fileName = fileNameAndExt[0];
            string ext = fileNameAndExt[1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {ext}");
            
        }
    }
}
