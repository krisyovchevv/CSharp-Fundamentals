using System;

namespace _02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string digits = number.ToString();
            int sum = 0;

            for (int i = 0; i < digits.Length; i++)
            {
                sum += number % 10;
                number /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
