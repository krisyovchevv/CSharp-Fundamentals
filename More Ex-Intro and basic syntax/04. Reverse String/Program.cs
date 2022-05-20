using System;

namespace _04._Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int numLetters = text.Length;
            for (int i = numLetters - 1; i >= 0; i--)
            {
                Console.Write(text[i]);
            }
        }
    }
}
