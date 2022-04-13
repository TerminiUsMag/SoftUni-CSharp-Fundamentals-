using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Songs
{
    class Song
    {
        public Song(string type, string name, string time)
        {
            this.TypeList = type;
            this.Name = name;
            this.Time = time;
        }
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split('_');

                Song song = new Song(data[0], data[1], data[2]);

                songs.Add(song);
            }

            string typeList = Console.ReadLine();

            if (typeList == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                // If statement WAY : 

                //    foreach (Song song in songs)
                //    {
                //        if (song.TypeList == typeList)
                //        {
                //            Console.WriteLine(song.Name);
                //        }
                //    }

                // Filter collection WAY : 

                List<Song> filteredSongs = songs.Where(s => s.TypeList == typeList).ToList();
                foreach (Song song in filteredSongs)
                {
                    Console.WriteLine(song.Name);
                }
            }



        }
    }
}
