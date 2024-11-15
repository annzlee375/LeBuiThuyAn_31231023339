using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeBuiThuyAn_31231023339
{
    internal class Section07
    {
        public static void Main7(string[] args)
        {
          //TwoDimensionalArrayEX();
            JaggedArray_01();
          //JaggedArray_02();

        }
        static void TwoDimensionalArrayEX()
        {
            int[,] a; //Khai bao 1 mang 2 chieu
            Console.Write("Enter the numbers of row N: ");
            int N = int.Parse(Console.ReadLine());

            Console.Write("Enter number of columns M: ");
            int M = int.Parse(Console.ReadLine());

            //Cap phat vung nho cho mang 2 chieu
            a = new int[N, M];

            CreateMatrixRandomly(a);
            ExportArray(a);

            Console.Write("Select a column to print: "); int selCol = int.Parse(Console.ReadLine());
            ExportArrayColIndex(a, selCol);

            //transpose(a);
            Console.WriteLine();
            ExportArray(a);

        /*rimaryDiagnol(a); Console.WriteLine();

            SecondaryDiagnol(a); Console.WriteLine();*/
        }

        static void CreateMatrixRandomly(int[,] a)
        {
            Random random = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = random.Next(100);
                }
            }
        }

        static void ExportArray(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i,j]}");
                }
                Console.WriteLine();
            }
        }

        static void ExportArrayColIndex(int[,] a, int ColIndex)
        {
            if (ColIndex < 0 || ColIndex > a.GetLength(0) - 1)
            {
                Console.WriteLine("Incorrect Value entered!");
                return;
            }
            for (int i = 0; i < a.GetLength(1); i++)
            {
                Console.Write($"{a[i, ColIndex]}\t");
            }
        }


        static void JaggedArray_01()
        {
            int[][] JaggedArray = new int[4][];
            JaggedArray[0] = new int[] { 1, 1, 1, 1, 1 };
            JaggedArray[1] = new int[] { 2, 2 };
            JaggedArray[2] = new int[] { 3, 3, 3 };
            JaggedArray[3] = new int[] { 4, 4 };

            
        }

        static void JaggedArray_02()
        {

        }
    }
}
