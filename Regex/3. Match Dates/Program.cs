using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _3._Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<day>\d{2})(?<separator>[/\.\-])(?<month>[A-Z][a-z]{2})\k<separator>(?<year>\d{4})\b";
            Regex regex = new Regex(pattern);
            string inputDates = Console.ReadLine();
            var datesMatches = regex.Matches(inputDates);


            foreach (Match match in datesMatches)
            {
                var day = match.Groups["day"];
                var month = match.Groups["month"];
                var year = match.Groups["year"];
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
