using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeBuiThuyAn_31231023339
{
    internal class Section02
    {
        public static void Main()
        {
            //Question_01();
            //Question_02();
            //Question_03();
          //Question_04();
         //Question_05();
          //Question_06();
          //Question_07();
        //Question_08();
       //Question_09();
          //Question_10();

            Console.WriteLine("Press any key to stop");
            Console.ReadKey();
        }

        /// <summary>
        /// 1. to Add / Sum Two Numbers
        /// </summary>
        public static void Question_01()
        {
            Console.Write("Enter a number a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter a number b = ");
            int b = int.Parse(Console.ReadLine());
            int sum = a + b;
            int product = a * b;
            Console.WriteLine($"{a} + {b} = {sum}");
            Console.WriteLine($"{a} * {b} = {product}");
        }

        /// <summary>
        /// 2. to Swap Values of Two Variables
        /// </summary>
        public static void Question_02()
        {
            Console.Write("Enter a number a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter a number b = ");
            int b = int.Parse(Console.ReadLine());
            int swap_a = b;
            int swap_b = a;
            Console.WriteLine($"The swap value of a = {swap_a}");
            Console.WriteLine($"The swap value of b = {swap_b}");
        }

        /// <summary>
        /// 3. to Multiply two Floating Point Numbers
        /// </summary>
        public static void Question_03()
        {
            Console.Write("Enter a number a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter a number b = ");
            double b = double.Parse(Console.ReadLine());
            double multiply = a * b;
            Console.WriteLine($"{a} * {b} = {multiply}");
        }

        /// <summary>
        /// 4. to convert feet to meter
        /// </summary>
        public static void Question_04()
        {
            Console.Write("Enter a value in feet = ");
            double a = double.Parse(Console.ReadLine());
            double meter = a * 0.3048;
            Console.WriteLine($"Convert {a} feet to {meter} meter");
        }

        /// <summary>
        /// 5. to convert Celsius to Fahrenheit and vice versa
        /// </summary>
        public static void Question_05()
        {
            Console.Write("Enter a value in Celsius = ");
            double a = double.Parse(Console.ReadLine());
            double fahrenheit = (a * 9 / 5) + 32;
            Console.WriteLine($"Convert {a} Celsius to {fahrenheit} Fahrenheit");
            Console.WriteLine($"Convert {fahrenheit} Fahrenheit to {a} Celsius");
        }

        /// <summary>
        /// 6. to find the Size of data types
        /// </summary>
        public static void Question_06()
        {

        }

        /// <summary>
        /// 7. to Print ASCII Value (tip: read character, print number of this char)
        /// </summary>
        public static void Question_07()
        {

        }

        /// <summary>
        /// 8. to Calculate Area of Circle
        /// </summary>
        public static void Question_08()
        {
            Console.Write("Enter the radius r = ");
            double r = double.Parse(Console.ReadLine());    
            const double PI = 3.14;
            double circle = PI * (r * r);
            Console.WriteLine($"Calculate Area of Circle with the radius r = {circle}");
        }

        /// <summary>
        /// 9. to Calculate Area of Square
        /// </summary>
        public static void Question_09()
        {
            Console.Write("Enter the side a of the square = ");
            double a = double.Parse(Console.ReadLine());
            double square = a * a;
            Console.WriteLine($"Calculate Area of Square with the side a = {square}");
        }

        /// <summary>
        /// 10. to convert days to years, weeks and days
        /// </summary>
        public static void Question_10()
        {
            Console.Write("Enter the number of days: ");
            int day= int.Parse(Console.ReadLine());
            int years = day / 365;
            int day_w = day - years*365;
            int weeks = day_w / 7;
            int d = day_w % 7;
            Console.WriteLine($"{day} is approximately {years} years, {weeks} weeks, and {day}
        }


    }
}
