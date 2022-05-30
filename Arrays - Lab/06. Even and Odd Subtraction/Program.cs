using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int evenSum = 0;
            int oddSum = 0;
            foreach (var num in number)
            {
                int sum = num % 2 == 0 ? evenSum += num : oddSum += num;
            }
            Console.WriteLine(evenSum - oddSum);
        }
    }
}
