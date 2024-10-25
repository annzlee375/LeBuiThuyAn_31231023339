using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeBuiThuyAn_31231023339
{
    internal class Section03
    {
        public static void Main()
        {
            Exercise_01 ();
            //Exercise_02 ();
            //Exercise_03 ();

            Console.WriteLine("Press any key to stop");
            Console.ReadKey();
        }
        /// <summary>
        /// convert from degrees Celsius to Kelvin and Farenheit
        /// </summary>
        public static void Exercise_01()
        {
            do
            {
                Console.Write("Enter a value in Celsius at least -273.15: ");
                double celsius;
                bool res = double.TryParse(Console.ReadLine(), out celsius);
                if (res && (celsius >= -273.15))
                {
                    double kelvin = celsius + 273;
                    Console.WriteLine($"Changing the value into Kelvin: {celsius} + 273 = {kelvin}");

                    double fahrenheit = (celsius * 18 / 10) + 32;
                    Console.WriteLine($"Changing the value into Fahrenheit: ({celsius} * 18/10) + 32 = {fahrenheit}");
                    break;
                }
                else
                {
                    Console.WriteLine("The minimum value in Celsius is at least -273.15!!! oe oe");
                }
            } while (true);
        }
            

        /// <summary>
        /// calculate the surface and volume of a sphere, given its radius
        /// </summary>
        public static void Exercise_02()
        {
            Console.Write("Enter a value of radius: ");
            double radius = double.Parse(Console.ReadLine());
            double surface = 4 * radius * radius * Math.PI;
            double volume = 4 / 3 * radius * radius * radius * Math.PI;
            Console.WriteLine($"The surface of a sphere, given its radius: {surface}");
            Console.WriteLine($"The volume of a sphere, given its radius: {volume}");
        }

        /// <summary>
        /// calculates the result of adding, subtracting, multiplying and dividing two numbers entered by the user
        /// </summary>
        public static void Exercise_03()
        {
            Console.Write("Enter the first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int b = int.Parse(Console.ReadLine());
            int addition = a + b;
            int subtraction = a - b;
            int multipliation = a * b;
            int division = a / b;
            int mod = a % b;
            Console.WriteLine($"The result of adding two numbers entered: {a} + {b} = {addition}");
            Console.WriteLine($"The result of subtracting two numbers entered: {a} - {b} = {subtraction}");
            Console.WriteLine($"The result of multiply two numbers entered: {a} * {b} = {multipliation}");
            Console.WriteLine($"The result of dividing two numbers entered and the rest of the division: {a} / {b} = {division} and {mod}");
        }
    }
}
