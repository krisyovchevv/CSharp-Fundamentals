using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countNumbers = int.Parse(Console.ReadLine());
            int[] num = new int[countNumbers];
            int[] secondNum = new int[countNumbers];
            int counter = 0;
            for (int i = 0; i < countNumbers; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (counter % 2 == 0)
                {
                    num[i] = input[0];
                    secondNum[i] = input[1];
                }
                else
                {
                    num[i] = input[1];
                    secondNum[i] = input[0];
                }
                counter++;
            }
            Console.WriteLine(string.Join(' ', num));
            Console.WriteLine(string.Join(' ', secondNum));
        }
    }
}
