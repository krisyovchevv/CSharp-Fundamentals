using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstNum = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var secondNum = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            int counter = 0;
            for (int i = 0; i < firstNum.Length; i++)
            {
                if (firstNum[i] != secondNum[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    sum = 0;
                    break;
                }
                else
                {
                    sum += firstNum[i];
                }
            }
            if (sum > 0)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }  
        }
    }
}
