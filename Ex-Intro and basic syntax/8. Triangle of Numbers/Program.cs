using System;

namespace _8._Triangle_of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int c = 1; c <= n; c++)
            {
                for (int r = 1; r <= c; r++)
                {
                    Console.Write(c + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
