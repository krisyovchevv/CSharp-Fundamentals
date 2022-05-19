using System;

namespace _5._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = null;
            int counter = 0;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }
            
            string trying = Console.ReadLine();
            
            while (trying != password)
            {
                Console.WriteLine("Incorrect password. Try again.");
                counter++;
                trying = Console.ReadLine();
                if (counter == 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
            }
            if (trying == password)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
