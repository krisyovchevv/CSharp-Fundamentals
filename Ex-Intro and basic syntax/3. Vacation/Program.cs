using System;

namespace _3._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numPeoples = int.Parse(Console.ReadLine());
            string typeGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double price = 0;
            double discount = 0;

            switch (dayOfWeek)
            {
                case "Friday":
                    if (typeGroup == "Students")
                    {
                        price = numPeoples * 8.45;
                        if (numPeoples >= 30)
                        {
                            discount = price * 0.15;
                            price -= discount;
                        }
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    else if (typeGroup == "Business")
                    {
                        if (numPeoples >= 100)
                        {
                            numPeoples -= 10;
                        }
                        price = numPeoples * 10.9;
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    else if (typeGroup == "Regular")
                    {
                        price = numPeoples * 15;
                        if (numPeoples >= 10 && numPeoples <= 20)
                        {
                            discount = price * 0.05;
                            price -= discount;
                        }
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    break;
                case "Saturday":
                    if (typeGroup == "Students")
                    {
                        price = numPeoples * 9.8;
                        if (numPeoples >= 30)
                        {
                            discount = price * 0.15;
                            price -= discount;
                        }
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    else if (typeGroup == "Business")
                    {
                        if (numPeoples >= 100)
                        {
                            numPeoples -= 10;
                        }
                        price = numPeoples * 15.6;
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    else if (typeGroup == "Regular")
                    {
                        price = numPeoples * 20;
                        if (numPeoples >= 10 && numPeoples <= 20)
                        {
                            discount = price * 0.05;
                            price -= discount;
                        }
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    break;
                case "Sunday":
                    if (typeGroup == "Students")
                    {
                        price = numPeoples * 10.46;
                        if (numPeoples >= 30)
                        {
                            discount = price * 0.15;
                            price -= discount;
                        }
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    else if (typeGroup == "Business")
                    {
                        if (numPeoples >= 100)
                        {
                            numPeoples -= 10;
                        }
                        price = numPeoples * 16;
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    else if (typeGroup == "Regular")
                    {
                        price = numPeoples * 22.5;
                        if (numPeoples >= 10 && numPeoples <= 20)
                        {
                            discount = price * 0.05;
                            price -= discount;
                        }
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    break;
            }
        }
    }
}
