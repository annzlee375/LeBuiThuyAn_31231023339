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
            //Operators Exercise
            //Question_02();
            //Question_03();
            //Question_05();

            //Control Flow Exercises   
            //Exercise_01();
            //Exercise_02();
            //Exercise_03();

            //Exercise01();
            //Exercise02();
            //Exercise03();
            //Exercise04();
            //Exercise05();
            //Exercise06();
            //Exercise07();

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
        ///Check whether a given number is even or odd.
        /// </summary>
        public static void Exercise_01()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is even.");
            }
            else
            {
                Console.WriteLine($"{number} is odd.");
            }
        }

        /// <summary>
        /// Find the largest of three numbers.
        /// </summary>
        public static void Exercise_02()
        {
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int largest = num1;

            if (num2 > largest)
            {
                largest = num2;
            }

            if (num3 > largest)
            {
                largest = num3;
            }

            Console.WriteLine($"The largest number is: {largest}");
        }

        /// <summary>
        ///Accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinat point lies.
        /// </summary>
        public static void Exercise_03()
        {
            Console.Write("Enter the X coordinate: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Y coordinate: ");
            double y = Convert.ToDouble(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("The point is in Quadrant I.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("The point is in Quadrant II.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("The point is in Quadrant III.");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("The point is in Quadrant IV.");
            }
            else if (x == 0 && y != 0)
            {
                Console.WriteLine("The point is on the Y-axis.");
            }
            else if (y == 0 && x != 0)
            {
                Console.WriteLine("The point is on the X-axis.");
            }
            else
            {
                Console.WriteLine("The point is at the origin.");
            }
        }

        /// <summary>
        ///Check whether a triangle is Equilateral, Isosceles or Scalene.
        /// </summary>
        public static void Exercise01()
        {
            Console.Write("Enter side a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter side b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter side c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a == b && b == c)
            {
                Console.WriteLine("The triangle is Equilateral.");
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine("The triangle is Isosceles.");
            }
            else
            {
                Console.WriteLine("The triangle is Scalene.");
            }
        }

        /// <summary>
        ///Read 10 numbers and find their average and sum.
        /// </summary>
        public static void Exercise02()
        {
            int count = 10;
            double sum = 0;

            for (int i = 1; i <= count; i++)
            {
                Console.Write($"Enter number {i}: ");
                sum += Convert.ToDouble(Console.ReadLine());
            }

            double average = sum / count;
            Console.WriteLine($"Sum: {sum}, Average: {average}");
        }

        /// <summary>
        ///Display the multiplication table of a given integer.
        /// </summary>
        public static void Exercise03()
        {
            Console.Write("Enter an integer: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Multiplication Table of {num}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
        }

        /// <summary>
        ///Display a pattern like triangles with a number. The patterns like ..
        /// </summary>
        public static void Exercise04()
        {
            
        }

        /// <summary>
        ///Display the n terms of harmonic series and their sum. 1 + 1/2 + 1/3 + 1/4 + 1/5 ... 1/n terms
        /// </summary>
        public static void Exercise05()
        {
            Console.Write("Enter the number of terms (n): ");
            int n = Convert.ToInt32(Console.ReadLine());
            double sum = 0;

            Console.Write("Harmonic series: ");
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"1/{i} ");
                sum += 1.0 / i;
            }

            Console.WriteLine($"\nSum of the series: {sum}");
        }

        /// <summary>
        ///Find the ‘perfect’ numbers within a given number range.
        /// </summary>
        public static void Exercise06()
        {
            Console.Write("Enter the range (1 to n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Perfect numbers in the range:");
            for (int i = 1; i <= n; i++)
            {
                if (IsPerfect(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsPerfect(int number)
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            return sum == number;
        }


        /// <summary>
        ///Determine whether a given number is prime or not.
        /// </summary>
        public static void Exercise07()
        {
            Console.Write("Enter a number to check if it is prime: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (IsPrime(number))
            {
                Console.WriteLine($"{number} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a prime number.");
            }
        }

        static bool IsPrime(int num)
        {
            if (num <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
        //End of Control Flow Exercises
    }
}
