using System;

namespace _06._Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 97; i <= 99; i++)
            {
                for (int j = 97; j <= 99; j++)
                {
                    for (int l = 97; l <= 99; l++)
                    {
                        char ch1 = (char)i;
                        char ch2 = (char)j;
                        char ch3 = (char)l;
                        Console.WriteLine($"{ch1}{ch2}{ch3}");
                    }
                }
            }
        }
    }
}
