using System;
using System.Collections.Generic;

namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            List<Student> students = new List<Student>();
            while (inputs[0] != "end")
            {
                int age = int.Parse(inputs[2]);
                Student student = new Student(inputs[0], inputs[1], age, inputs[3]);
                students.Add(student);
                inputs = Console.ReadLine().Split(' ');
            }
            string city = Console.ReadLine();
            foreach (Student student in students)
            {
                if (city == student.HomeTown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

        class Student
        {
            public Student(string firstName, string lastName, int age, string homeTown)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.Age = age;
                this.HomeTown = homeTown;
            }
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public int Age { get; set; }

            public string HomeTown { get; set; }

        }
    }
}
