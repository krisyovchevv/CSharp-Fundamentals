using System;

namespace _9._Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int numbers = 1 + (i * 2);
                sum += numbers;
                Console.WriteLine(numbers);
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
