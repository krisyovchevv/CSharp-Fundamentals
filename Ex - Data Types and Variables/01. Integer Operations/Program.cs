using System;

namespace _01._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());

            n2 += n1;
            n2 /= n3;
            n2 *= n4;
            Console.WriteLine(n2);
        }
    }
}
