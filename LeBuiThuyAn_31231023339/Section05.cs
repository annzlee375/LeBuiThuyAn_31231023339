using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeBuiThuyAn_31231023339
{
    internal class Section05
    {
        public static void Main (string[] args) 
        {
            //Exercise_01();
            //Exercise_02();
            //Exercise_03();
            //Exercise_04();
            //Exercise_05();
            //Exercise_06();

            Console.WriteLine("Press any key to stop");
            Console.ReadKey();
        }

        /// <summary>
        ///1. Find the maximum of three numbers
        /// </summary>
        public static void Exercise_01()
        {
            // Enter 3 numbers
            Console.Write("Enter the first number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int c = int.Parse(Console.ReadLine());

            //Find the maximum of three numbers
            int max = max3Nums(a, b, c);
            Console.WriteLine("The maximum of three numbers is " + max);
        }
            
            static int max2Nums(int a, int b)
            {
                return a > b ? a : b;
            }

            static int max3Nums (int a, int b, int c)
            {
                return max2Nums (a, max2Nums (b, c));
            }



            //Improve the next version that accept at least 1 parameter
            static int Max(params int[] numbers)
            {
                if (numbers.Length == 0)
                {
                    throw new ArgumentException("At least one number must be provided.");
                }

                int max = numbers[0];
                foreach (int num in numbers)
                {
                    if (num > max)
                    {
                        max = num;
                    }
                }
                return max;
            }

        /// <summary>
        ///2. Calculate the factorial (giai thừa) of a number (a non-negative integer) (số nguyên không âm). The function accepts the number as an argument.
        /// </summary>
        public static void Exercise_02()
        {
           
            Console.Write("Enter a non-negetive integer: ");
            string input = Console.ReadLine();

            // Convert the input string to an integer
            if (int.TryParse(input, out int n) && n >= 0)
            {
                // Calculate the factorial 
                long factorial = Factorial(n);
                Console.WriteLine($"The factorial of {n} is {factorial}");
            }
            else
            {
                Console.WriteLine("Please enter a valid non-negative integer!");
            }
        }

        //Calculate factorial
        static long Factorial(int n)
        {
            if (n == 0) 
            {
                return 1;
            }

            return n * Factorial(n - 1); 
        }

        /// <summary>
        ///3. Takes a number as a parameter (tham số) and checks whether the number is prime (số nguyên tố) or not
        /// </summary>
        public static void Exercise_03()
        {
            int num;
            bool isValidInput = false;

            // Check if the input is a number
            while (!isValidInput)
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out num))
                {
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine("The input is invalid. Please enter a number.");
                }
            }

            // Check if the number is prime
            if (isPrime(num))
            {
                Console.WriteLine($"The number {num} you entered is prime.");
            }
            else
            {
                Console.WriteLine($"The number {num} you entered is not prime.");
            }
        }

        // Function to check if a number is prime
        static bool isPrime(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            for (int i = 3; i * i <= n; i += 2)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        ///4. Print  1. all prime numbers that less than a number (enter prompt keyboard) 2. the first N prime numbers
        /// </summary>
        public static void Exercise_04()
        {
            int num;
            bool isValidInput = false;

            // Check if the input is a number
            while (!isValidInput)
            {
                Console.Write("Enter a positive integer: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out num) && num > 1)
                {
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine("The input is invalid. Please enter a positive integer greater than 1.");
                }
            }

            Console.WriteLine($"Prime numbers less than {num}:");
            for (int i = 2; i < num; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine(); 
        }

        // Function to check if a number is prime
        static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            for (int i = 3; i * i <= n; i += 2)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }

        /// <summary>
        ///5. Check whether a number is "Perfect" or not. Then print all perfect number that less than 1000.
        /// </summary>
        public static void Exercise_05()
        {
        Console.WriteLine();
        }

        /// <summary>
        ///6. Check whether a string is a pangram or not
        /// </summary>
        public static void Exercise_06()
        {
            
        }
    }
}
