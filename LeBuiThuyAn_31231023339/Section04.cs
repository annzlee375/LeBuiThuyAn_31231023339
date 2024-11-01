using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace LeBuiThuyAn_31231023339
{
    internal class Section04
    {
        public static void Main()
        {
        //Operators Exercises
            //Question_02();
            //Question_03();
            //Question_05();

        //Control Flow Exercises   
            //Exercise_01();
            //Exercise_02();
            //Exercise_03();

            Console.WriteLine("Press any key to stop");
            Console.ReadKey();
        }

        //Start of Operators Exercises 
        /// <summary>
        ///Display certain values of the function x = y2 + 2y + 1 (using integer numbers for y, ranging from -5 to +5).
        /// </summary>
        public static void Question_02()
        {
            
                Console.Write("Enter an integer value for y (from -5 to 5): ");
                int y;

                while (!int.TryParse(Console.ReadLine(), out y) || y < -5 || y > 5) // Validate input
                {
                    Console.WriteLine("Invalid input. Please enter an integer from -5 to 5.");
                    Console.Write("Enter an integer value for y: ");
                }

                int x = (y * y) + (2 * y) + 1; // Calculate the function

                Console.WriteLine($"For y = {y}, x = {x}"); // Display the result
            
        }

        /// <summary>
        ///Takes distance and time (hours, minutes, seconds) as input and displays speed in kilometers per hour(km/h) and miles per hour(miles/h).
        /// </summary>
        public static void Question_03()
        {
            Console.Write("Enter distance in kilometers: ");// Input distance in kilometers
            double distance;
            while (!double.TryParse(Console.ReadLine(), out distance) || distance < 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number for distance.");
                Console.Write("Enter distance in kilometers: ");
            }

            // Input time
            Console.Write("Enter time in hours: "); 
            int hours = int.Parse(Console.ReadLine());

            Console.Write("Enter time in minutes: ");
            int minutes = int.Parse(Console.ReadLine());

            Console.Write("Enter time in seconds: ");
            int seconds = int.Parse(Console.ReadLine());

            double totalTimeInHours = hours + (minutes / 60.0) + (seconds / 3600.0); // Convert time to total hours

            double speedKmh = distance / totalTimeInHours; // Calculate speed in km/h

            double speedMph = speedKmh * 0.621371; // Convert speed to miles per hour (1 km = 0.621371 miles)

            Console.WriteLine($"The speed in km/h is: {speedKmh} km/h"); 
            Console.WriteLine($"The speed in miles/h is: {speedMph} miles/h");
        }

        /// <summary>
        /// Write a C# Sharp program that takes a character as input and checks if it is a vowel, a digit, or any other symbol.
        /// </summary>
        public static void Question_05()
        {
            Console.Write("Enter a character: ");
            char inputChar = Console.ReadKey().KeyChar; // Read a single character input
            Console.WriteLine(); // Move to the next line

            // Check if the character is a vowel
            if ("AEIOUaeiou".IndexOf(inputChar) >= 0)
            {
                Console.WriteLine($"{inputChar} is a vowel.");
            }
            // Check if the character is a digit
            else if (char.IsDigit(inputChar))
            {
                Console.WriteLine($"{inputChar} is a digit.");
            }
            // If it's neither a vowel nor a digit, it's a symbol
            else
            {
                Console.WriteLine($"{inputChar} is a symbol.");

            }
        }
        //End of Operators Exercises

        //Start of Control Flow Exercises
        /// <summary>
        /// check whether a given number is even or odd.
        /// </summary>
        public static void Exercise_01()
        {
            Console.Write("Enter a number: ");

        }

        public static void Exercise_02()
        {

        }

        public static void Exercise_03()
        {

        }
        //End of Control Flow Exercises
    }
}
