using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeBuiThuyAn_31231023339
{
    internal class Section06
    {
        static void Main()
        {
            Exercise_01();
            Exercise_02();

        }
        //Declare an array N items. With N is entered from user.
        public static void Exercise_01()
        {
            //Enter item values for this array
            Console.Write("Enter the number of items in array N: ");
            int N = int.Parse(Console.ReadLine());
            int[] a = new int[N];
            nhapmangbangCom(a);
            Console.WriteLine("Increase each item of N by adding 2 and print array: "); IncreaseItems(a, 2);
            InMang(a);
            Console.Write("Sum of array: "); Sum(a);
            Console.WriteLine("Press any key to stop");
            Console.ReadKey();
        }

        static void nhapmangbangCom(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"Enter the values #{i}: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        static void SinhMangNgauNhien(int[] a)
        {
            Random random = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(100);
            }
        }

        static void InMang(int[] a)
        {
            foreach (int item in a)
            {
                Console.WriteLine($"{item}, ");
            }
        }

        //Increase each item of the array by adding it with 2
        static void IncreaseItems(int[] a, int val)
        {
            for (int i = 0; i < a.Length; i++)
                a[i] += val;
        }

        //Calculate the Sum of all items of the array
        static int Sum(int[] a)
        {
            int sum = 0;
            foreach (int item in a)
            {
                sum += item;
            }
            return sum;
        }

        //Average
        static void Average(int[] a)
        {
            int average = 0;
        }

        //Min

        //Max

        //Create a random integer values array, then create functions that:
        public static void Exercise_02()
        {

        }
    }
}
