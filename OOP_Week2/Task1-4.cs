using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Week2
{
    internal class Task1_4
    {
        public static void PrintMenu()
        {
            Console.WriteLine("Choose a valid option from below:");
            Console.WriteLine("1. Hello in French?\n2. Hello in Spanish?\n3. Hello in German?\n4. Hello in Italian?\n0. Exit Application.");
        }

        public static int InputOption()
        {
            int option = 0;

            try
            {
                Console.WriteLine("Enter a choice: ");
                option = Int32.Parse(Console.ReadLine());
                return option;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return option;
        }

        public static String GetMessage()
        {
            switch(InputOption())
            {
                case 0:
                    return "Goodbye";
                case 1:
                    return "Bonjour";
                case 2:
                    return "Hola";
                case 3:
                    return "Hallo";
                case 4:
                    return "Ciao";
                default:
                    return "Enter valid menu option";
                    
            }
        }
    }
}


//using System;

//namespace OOP_Week2
//{
//    internal class Task1_4
//    {
//        public static void PrintMenu()
//        {
//            Console.WriteLine("Choose a valid option from below:");
//            Console.WriteLine("1. Hello in French?");
//            Console.WriteLine("2. Hello in Spanish?");
//            Console.WriteLine("3. Hello in German?");
//            Console.WriteLine("4. Hello in Italian?");
//            Console.WriteLine("0. Exit Application.");
//        }

//        public static int InputOption()
//        {
//            int option;
//            bool isValid = false;

//            while (!isValid)
//            {
//                try
//                {
//                    Console.Write("Enter a choice (0-4): ");
//                    option = Int32.Parse(Console.ReadLine());

//                    if (option >= 0 && option <= 4)
//                    {
//                        isValid = true;
//                        return option;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Please enter a number between 0 and 4.");
//                    }
//                }
//                catch (FormatException)
//                {
//                    Console.WriteLine("Invalid input. Please enter a numeric value.");
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine("An unexpected error occurred: " + ex.Message);
//                }
//            }

//            // This line will never be reached but is required by the compiler
//            return -1;
//        }

//        public static string GetMessage(int option)
//        {
//            switch (option)
//            {
//                case 0:
//                    return "Goodbye";
//                case 1:
//                    return "Bonjour";
//                case 2:
//                    return "Hola";
//                case 3:
//                    return "Hallo";
//                case 4:
//                    return "Ciao";
//                default:
//                    return "Invalid menu option";
//            }
//        }

//        // Optional Main method to test everything
//        public static void Main(string[] args)
//        {
//            PrintMenu();
//            int selectedOption = InputOption();
//            string message = GetMessage(selectedOption);
//            Console.WriteLine("\n" + message);
//        }
//    }
//}