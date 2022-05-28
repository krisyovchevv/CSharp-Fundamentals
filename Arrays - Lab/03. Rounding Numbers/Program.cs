using System;
using System.Linq;

namespace _03._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            string[] inputToArray = input.Split(" ");
            double[] arr = inputToArray.Select(double.Parse).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                double rounding = (int)Math.Round(arr[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{arr[i]} => {rounding}");
            }
        }
    }
}
