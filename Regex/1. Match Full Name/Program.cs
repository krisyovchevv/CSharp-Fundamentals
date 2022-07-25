using System;
using System.Text.RegularExpressions;

namespace _1._Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<firstName>[A-Z][a-z]+) (?<secondName>[A-Z][a-z]+)\b";
            string input = Console.ReadLine();
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            foreach (Match matchedNames in matches)
            {
                Console.Write(matchedNames.Value + " ");   
            }

            Console.WriteLine();
        }
    }
}
