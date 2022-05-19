using System;

namespace _6._Strong_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sum = 0;
            int fact = 1;
            for (int i = 0; i <= input.Length - 1; i++)
            {
                char c = input[i];
                int n = (int)Char.GetNumericValue(c);
                if (n == 0)
                {
                    n = 1;
                }

                for (int j = 1; j <= n; j++)
                {
                    fact = fact * j;
                }
                sum += fact;
                fact = 1;
            }
            int number = int.Parse(input);
            if (sum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
