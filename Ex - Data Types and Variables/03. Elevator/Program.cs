using System;

namespace _03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            int capacityOfElevator = int.Parse(Console.ReadLine());
            int courses = (int)Math.Ceiling((double)numOfPeople / capacityOfElevator);
            
            Console.WriteLine(courses);
        }
    }
}
