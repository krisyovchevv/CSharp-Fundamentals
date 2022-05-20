using System;

namespace _05._Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int symbols = int.Parse(Console.ReadLine());
            string word = null;

            for (int i = 1; i <= symbols; i++)
            {
                string letter = Console.ReadLine();
                int numOfDigits = letter.Length;
                int mainDigit = (int)Char.GetNumericValue(letter[0]);
                int offset = (mainDigit - 2) * 3;
                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset++;
                }
                int letterIndex = (offset + numOfDigits) - 1;

                switch (letterIndex)
                {
                    case 0:
                        word += "a";
                        break;
                    case 1:
                        word += "b";
                        break;
                    case 2:
                        word += "c";
                        break;
                    case 3:
                        word += "d";
                        break;
                    case 4:
                        word += "e";
                        break;
                    case 5:
                        word += "f";
                        break;
                    case 6:
                        word += "g";
                        break;
                    case 7:
                        word += "h";
                        break;
                    case 8:
                        word += "i";
                        break;
                    case 9:
                        word += "j";
                        break;
                    case 10:
                        word += "k";
                        break;
                    case 11:
                        word += "l";
                        break;
                    case 12:
                        word += "m";
                        break;
                    case 13:
                        word += "n";
                        break;
                    case 14:
                        word += "o";
                        break;
                    case 15:
                        word += "p";
                        break;
                    case 16:
                        word += "q";
                        break;
                    case 17:
                        word += "r";
                        break;
                    case 18:
                        word += "s";
                        break;
                    case 19:
                        word += "t";
                        break;
                    case 20:
                        word += "u";
                        break;
                    case 21:
                        word += "v";
                        break;
                    case 22:
                        word += "w";
                        break;
                    case 23:
                        word += "x";
                        break;
                    case 24:
                        word += "y";
                        break;
                    case 25:
                        word += "z";
                        break;
                    case -6:
                        word += " ";
                        break;
                }
            }
            Console.WriteLine(word);
        }
    }
}
