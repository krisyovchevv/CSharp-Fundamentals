using System;

namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            double percantege50Power = pokePower * 0.5;
            int distancePokeTargets = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int targetsTracked = 0;

            while (pokePower >= distancePokeTargets)
            {
                pokePower -= distancePokeTargets;
                if (pokePower == percantege50Power && exhaustionFactor > 0)
                {
                    pokePower /= exhaustionFactor;
                }
                targetsTracked++;
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(targetsTracked);
        }
    }
}
