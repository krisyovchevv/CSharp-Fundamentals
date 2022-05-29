using System;
using System.Numerics;

namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int snowballNum = int.Parse(Console.ReadLine());
            BigInteger snowballSnow = 0;
            BigInteger snowballTime = 0;
            int snowballQuality = 0;

            BigInteger bestValue = 0;
            string bestValueName = null;

            for (int i = 0; i < snowballNum; i++)
            {
                snowballSnow = BigInteger.Parse(Console.ReadLine());
                snowballTime = BigInteger.Parse(Console.ReadLine());
                snowballQuality = int.Parse(Console.ReadLine());
                BigInteger value = snowballSnow / snowballTime;
                value = BigInteger.Pow(value, snowballQuality);
                if (value > bestValue)
                {
                    bestValue = value;
                    bestValueName = $"{snowballSnow} : {snowballTime} = {value} ({snowballQuality})";
                }
            }
            Console.WriteLine(bestValueName);
        }
    }
}
