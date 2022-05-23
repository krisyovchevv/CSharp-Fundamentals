using System;

namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int yield = startingYield;
            int totalSpices = 0;
            int workingDays = 0;

            while (yield >= 100) 
            {
                int spices = yield;
                yield -= 10;
                spices -= 26;
                totalSpices += spices;
                workingDays++;                
            } 
            if (totalSpices >= 26)
            {
                totalSpices -= 26;
            }
            else
            {
                totalSpices = 0;
            }
            Console.WriteLine(workingDays);
            Console.WriteLine(totalSpices);
        }
    }
}
