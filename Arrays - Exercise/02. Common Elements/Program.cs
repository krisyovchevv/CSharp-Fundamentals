using System;
using System.Linq;

namespace _02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split();
            string[] secondInput = Console.ReadLine().Split();
            var intersect = secondInput.Intersect(firstInput);
            foreach (var commonElements in intersect)
            {
                Console.Write($"{commonElements} ");
            }
        }
    }
}
