using System;

namespace _03._Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            double money = currentBalance;
            double totalSpend = 0;
            string game = Console.ReadLine();
            while (game != "Game Time")
            {
                switch (game)
                {
                    case "OutFall 4":
                        if (money >= 39.99)
                        {
                            money -= 39.99;
                            totalSpend += 39.99;
                            Console.WriteLine($"Bought {game}");
                        }
                        else if (money < 39.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "CS: OG":
                        if (money >= 15.99)
                        {
                            money -= 15.99;
                            totalSpend += 15.99;
                            Console.WriteLine($"Bought {game}");
                        }
                        else if (money < 15.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Zplinter Zell":
                        if (money >= 19.99)
                        {
                            money -= 19.99;
                            totalSpend += 19.99;
                            Console.WriteLine($"Bought {game}");
                        }
                        else if (money < 19.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Honored 2":
                        if (money >= 59.99)
                        {
                            money -= 59.99;
                            totalSpend += 59.99;
                            Console.WriteLine($"Bought {game}");
                        }
                        else if (money < 59.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch":
                        if (money >= 29.99)
                        {
                            money -= 29.99;
                            totalSpend += 29.99;
                            Console.WriteLine($"Bought {game}");
                        }
                        else if (money < 29.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch Origins Edition":
                        if (money >= 39.99)
                        {
                            money -= 39.99;
                            totalSpend += 39.99;
                            Console.WriteLine($"Bought {game}");
                        }
                        else if (money < 39.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }
                if (totalSpend == currentBalance)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
                game = Console.ReadLine();
            }
            if (currentBalance > totalSpend)
            {
                double remaining = Math.Abs(totalSpend - currentBalance);
                Console.Write($"Total spent: ${totalSpend:f2}. ");
                Console.WriteLine($"Remaining: ${remaining:f2}");
            }
        }
    }
}
