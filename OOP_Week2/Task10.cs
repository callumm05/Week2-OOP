using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Week2
{
    internal class Task10
    {
        public static double CircleArea(double radius)
        { 
            while (true)
            {
                Console.WriteLine("Enter the radius of the circle (0 to Exit):");
                string input = Console.ReadLine();

                if (!double.TryParse(input, out double r) || r < 0)
                {
                    Console.WriteLine("Please enter a valid positive number (or 0 to exit).");
                    continue;
                }

                if (r == 0)
                {
                    Console.WriteLine("Exiting Application. Goodbye!");
                    break;
                }

                double area = Math.PI * Math.Pow(r, 2);

                Console.WriteLine($"The area of the circle with radius {r} is: {area:F2}");
            }

            return 0;
        }
    }
}
