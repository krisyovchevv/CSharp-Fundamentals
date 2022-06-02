using System;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countVagons = int.Parse(Console.ReadLine());
            var passengers = new int[countVagons];
            int sum = 0;
            for (int i = 0; i < countVagons; i++)
            {
                passengers[i] = int.Parse(Console.ReadLine());
                sum += passengers[i];
            }
            Console.WriteLine(string.Join(' ', passengers));
            Console.WriteLine(sum);
        }
    }
}
