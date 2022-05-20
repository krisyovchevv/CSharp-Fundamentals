using System;

namespace _9._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amaountOfMoney = double.Parse(Console.ReadLine());
            int numStudents = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());
            double sum = 0;
            double percentageLight = Math.Ceiling(numStudents * 0.1);
            percentageLight += numStudents;
            sum +=  lightsaberPrice * percentageLight;
            sum += robePrice * numStudents;
            sum += beltPrice * numStudents;

            for (int i = 1; i <= numStudents; i++)
            {
                if (i % 6 == 0)
                {
                    sum -= beltPrice;
                }
            }
            double diff = Math.Abs(sum - amaountOfMoney);
            if (amaountOfMoney < sum)
            {
                Console.WriteLine($"John will need {diff:f2}lv more.");
            }
            else if (amaountOfMoney >= sum)
            {
                Console.WriteLine($"The money is enough - it would cost {sum:f2}lv.");
            }
        }
    }
}
