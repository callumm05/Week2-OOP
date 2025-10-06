using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Week2
{
    internal class Task5
    {
        public static void Week2_Task5()
        {
            bool upperCase = true;
            Console.WriteLine("Enter a String");
            String word = Console.ReadLine();


            Console.WriteLine($"The sentence you inputted is: {word}");

            word.Trim();
            string[] wordWords = word.Split(' ');
            foreach (string w in wordWords )
            {
                if (string.IsNullOrEmpty(w) || !char.IsUpper(w[0]))
                {
                    upperCase = false;
                    break;
                }
            }
            if (upperCase)
            {
                Console.WriteLine($"Number of words: {wordWords.Length}");
            }
            else
            {
                Console.WriteLine("Enter the each word with a uppercase letter at the start.");
            }
        }
    }
}
