using System;

namespace _01._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                Random random = new Random();
                int randomNum = random.Next(0, words.Length);

                string oldWord = words[i];
                words[i] = words[randomNum];
                words[randomNum] = oldWord;
            }
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
