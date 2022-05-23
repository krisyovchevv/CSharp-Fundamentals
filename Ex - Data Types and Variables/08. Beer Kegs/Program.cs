using System;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            string biggestVolumeName = null;
            double biggestVolume = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                string typeKeg = Console.ReadLine();
                double radiusOfKeg = double.Parse(Console.ReadLine());
                double heightOfKeg = int.Parse(Console.ReadLine());
                double volume = Math.PI * (radiusOfKeg * radiusOfKeg) * heightOfKeg;
                if (biggestVolume < volume)
                {
                    biggestVolumeName = typeKeg;
                    biggestVolume = volume;
                }
            }
            Console.WriteLine(biggestVolumeName);
        }
    }
}
