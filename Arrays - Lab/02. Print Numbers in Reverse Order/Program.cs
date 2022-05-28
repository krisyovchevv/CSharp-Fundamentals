using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] numbers = new int[number];
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
