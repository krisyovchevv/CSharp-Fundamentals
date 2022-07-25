using System;
using System.Text.RegularExpressions;

namespace _2._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359([ \-])2\1\d{3}\1\d{4}\b";
            string inputPhone = Console.ReadLine();
            MatchCollection phoneMatches = Regex.Matches(inputPhone, pattern);

            Console.WriteLine(string.Join(", ", phoneMatches));
        }
    }
}
