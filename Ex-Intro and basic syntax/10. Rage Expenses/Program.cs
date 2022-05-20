using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            int headsetTrash = 0;
            int mouseTrash = 0;
            int keyboardTrash = 0;
            int displayTrash = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    headsetTrash++;
                    mouseTrash++;
                    keyboardTrash++;
                    if (keyboardTrash % 2 == 0 && keyboardTrash > 0)
                    {
                        displayTrash++;
                    }
                }
                else if (i % 2 == 0)
                {
                    headsetTrash++;
                }
                 else if (i % 3 == 0)
                {
                    mouseTrash++;
                }
            }
            double expenses = (headsetTrash * headsetPrice) + (mouseTrash * mousePrice) + (keyboardTrash * keyboardPrice) + (displayTrash * displayPrice);
            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}
