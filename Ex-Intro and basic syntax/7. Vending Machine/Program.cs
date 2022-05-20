using System;

namespace _7._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double money = 0;
            double insertedCoins = 0;

            while (input != "Start")
            {
                double coin = double.Parse(input);
                bool suppCoins = coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin == 2;
                if (suppCoins == false)
                {
                    Console.WriteLine($"Cannot accept {coin}");
                    input = Console.ReadLine();
                    continue;
                }
                else
                {
                    money += coin;
                    input = Console.ReadLine();
                }
            }
            string input2 = Console.ReadLine();

            while (input2 != "End")
            {
                switch (input2)
                {
                    case "Nuts":
                        if (money < 2)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            money -= 2;
                            Console.WriteLine("Purchased nuts");
                        }
                        break;
                    case "Water":
                        if (money < 0.7)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            money -= 0.7;
                            Console.WriteLine("Purchased water");
                        }
                        break;
                    case "Crisps":
                        if (money < 1.5)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            money -= 1.5;
                            Console.WriteLine("Purchased crisps");
                        }
                        break;
                    case "Soda":
                        if (money < 0.8)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            money -= 0.8;
                            Console.WriteLine("Purchased soda");
                        }
                        break;
                    case "Coke":
                        if (money < 1)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            money -= 1;
                            Console.WriteLine("Purchased coke");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                input2 = Console.ReadLine();
            }
            Console.WriteLine($"Change: {Math.Abs(money):f2}");
        }
    }
}
