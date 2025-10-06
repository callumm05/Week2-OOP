using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Week2
{
    internal class Task6_9
    {
        public static void Encrypt()
        {
            Console.WriteLine("Enter a string.");
            String original = Console.ReadLine();

            Console.WriteLine("Enter number of rotations.");
            int k = Int32.Parse(Console.ReadLine());

            char[] input = original.ToCharArray();
            k = k % 26;

            for (int i = 0; i < input.Length; i++)
            {
                char letter = input[i];

                if (char.IsLetter(letter))
                {
                    char offset = char.IsUpper(letter) ? 'A' : 'a';
                    input[i] = (char)(((letter - offset + k) % 26) + offset);
                }
            }

            string encrypted = new string(input);

            Console.WriteLine($"Original String: {original}\n");
            Console.WriteLine($"Encrypted String: {encrypted}\n");
        }

        public static void Decrypt()
        {
            Console.WriteLine("Enter a string.");
            String encrypted = Console.ReadLine();

            Console.WriteLine("Enter number of rotations.");
            int k = Int32.Parse(Console.ReadLine());

            char[] input = encrypted.ToCharArray();
            k = k % 26;

            for (int i = 0; i < input.Length; i ++)
            {
                char letter = input[i];

                if (char.IsLetter(letter))
                {
                    char offset = char.IsUpper(letter) ? 'A' : 'a';
                    input[i] = (char)(((letter - offset - k + 26) % 26) + offset);
                }
            }

            string decrypted = new string(input);

            Console.WriteLine($"Encrypted String: {encrypted}\n");
            Console.WriteLine($"Decrypted String: {decrypted}\n");
        }

        public static void Menu()
        {
            Console.WriteLine("1. Encrypt a message\n2. Decrypt a message\n0. Exit Application.");

            int option = 0;

            try
            {
                Console.WriteLine("Enter a choice: ");
                option = Int32.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            switch(option)
            {
                case 0: 
                    Encrypt();
                    break;
                case 1:
                    Decrypt();
                    break;
                case 2: 
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
