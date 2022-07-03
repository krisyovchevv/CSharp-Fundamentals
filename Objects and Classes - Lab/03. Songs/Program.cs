using System;
using System.Collections.Generic;

namespace _03._Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numSongs = int.Parse(Console.ReadLine());
            List<Songs> songs = new List<Songs>();
            for (int i = 0; i < numSongs; i++)
            {
                string[] input = Console.ReadLine().Split("_");

                string typeList = input[0];
                string name = input[1];
                string time = input[2];

                Songs song = new Songs(typeList, name, time);

                songs.Add(song);
            }
            string operation = Console.ReadLine();
            if (operation == "all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (var song in songs)
                {
                    if (song.TypeList == operation)
                    {
                    Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
    class Songs
    {
        public Songs(string typeList, string name, string time)
        {
            this.TypeList = typeList;
            this.Name = name;
            this.Time = time;
        }
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
