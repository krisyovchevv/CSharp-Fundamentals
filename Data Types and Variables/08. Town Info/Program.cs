using System;

namespace _8._Town_Info
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfTown = Console.ReadLine();
            uint population = uint.Parse(Console.ReadLine());
            decimal squareArea = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Town {nameOfTown} has population of {population} and area {squareArea} square km.");
        }
    }
}
