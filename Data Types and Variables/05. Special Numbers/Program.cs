using System;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int num = (number + 1) - number;
            

            for (int i = 1; i <= number; i++)
            {
                int digts = num;
                int sum = 0;
                while (digts > 0)
                {
                    sum += digts % 10;
                    digts /= 10;
                }
                num += 1;
                Console.WriteLine($"{i} -> {sum == 5 || sum == 7 || sum == 11}");
            }
        }
    }
}
