﻿using System;

namespace _04._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                sum += ch;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
