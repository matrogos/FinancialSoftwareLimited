using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSLCodeExercise.Start
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            /*
             * Lack of input validation (Typing letter will cause unhandled error)
             * Negative number can be passed to width
             * Shape object needs initialization every time
             * Bad naming, for example Area sounds like filed or property. It is hard to recognize what it does without analizing code inside
             */

            //Exercise 3
            /*
             * Imporove thread safety
             * Separate input validation for further use
             * Add validation tests
             * Add InvalidProgramException handling
             */

            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("FSL Code Exercise v1.0");
            Console.WriteLine();
            Console.WriteLine("Calculates and prints information for a user-supplied shape and width");
            Console.WriteLine("---------------------------------------------------------------------");
            
            int type = 0;

            //Validation of type
            while (type == 0)
            {
                Console.WriteLine("Do you want a square (1), circle (2), or equilateral triangle (3): ");
                if (!Int32.TryParse(Console.ReadLine(),out type))
                    Console.WriteLine("Invalid input parameter");
            }

            double width = 0;

            //Validation of width
            while (width <= 0)
            {
                Console.WriteLine("Enter the shape's primary dimension (width, radius, or base): ");
                if (!Double.TryParse(Console.ReadLine(), out width) || width < 0)
                    Console.WriteLine("Invalid input parameter");
                else
                    break; //Added to handle width = 0
            }

            double area = ShapeSingleton.Instance.CalculateArea(type, width);

            Console.WriteLine();
            Console.WriteLine("Shape properties:");
            Console.WriteLine("\tWidth: " + width);
            Console.WriteLine("\tArea: " + area);
            Console.ReadLine();
        }
    }
}
