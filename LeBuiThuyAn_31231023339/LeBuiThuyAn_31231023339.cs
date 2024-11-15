using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeBuiThuyAn_31231023339
{
    internal class LeBuiThuyAn_31231023339
    {
        public static void Main()
        {
            Random rand = new Random();
            Console.Write("Nhap so dong n tu 1 den 100: ");
            int n = int.Parse(Console.ReadLine());
            int[][] matrix = new int[n][];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap so cot cho dong {i + 1} tu 1 den 100: ");
                int ki = int.Parse(Console.ReadLine());
                matrix[i] = new int[ki];
                Console.WriteLine($"Nhap cac phan tu ngau nhien cho dong {i + 1} ");
                for (int j = 0; j < ki; j++)
                {
                    matrix[i][j] = rand.Next(1, 101);
                }
            }

            Console.WriteLine("<< Menu >>");
            Console.WriteLine("1. In ra ma tran da nhap");
            Console.WriteLine("2. In ra phan tu lon nhat, nho nhat tren moi dong va tren toan bo ma tran");
            Console.WriteLine("3. Sap xep cac dong theo thu tu tang dan");
            Console.WriteLine("4. In ra cac phan tu cua dong la so nguyen to");
            Console.WriteLine("5. In ra tat ca vi tri xuat hien cua mot so X nhap tu nguoi dung");
            Console.WriteLine("6. Chuyen ma tran ve ma tran chu nhat voi cac o thieu duoc dien bang so 0");
            Console.WriteLine("7. Thoat");

            while (true)
            {
                Console.Write("Chon chuc nang: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: InMatran(matrix); break;
                    case 2: TimMinMax(matrix); break;
                    case 3: SapxepMatran(matrix); break;
                    case 4: InPhantuDong(matrix); break;
                    case 5: InVitriCuaX(matrix); break;
                    case 6: ChuyenMatran(matrix); break;
                    case 7: return;
                    default:
                        Console.WriteLine("Hay chon lua chon co san trong Menu!");
                        break;
                }
            }

            static void InMatran(int[][] matrix)
            {
                Console.WriteLine("Ma tran da nhap la:");
                foreach (var row in matrix)
                {
                    foreach (var item in row)
                    {
                        Console.Write(item + "\t");
                    }
                    Console.WriteLine();
                }
            }

            static void TimMinMax(int[][] matrix)
            {
                int Min = int.MaxValue, Max = int.MinValue;
                Console.WriteLine("Phan tu lon nhat, nho nhat tren moi dong: ");
                foreach (var row in matrix)
                {
                    int rowMin = int.MaxValue, rowMax = int.MinValue;
                    foreach (var item in row)
                    {
                        rowMin = Math.Min(rowMin, item);
                        rowMax = Math.Max(rowMax, item);
                        Min = Math.Min(Min, item);
                        Max = Math.Max(Max, item);
                    }
                    Console.WriteLine($"Dong {Array.IndexOf(matrix, row) + 1}: Min = {rowMin}, Max = {rowMax}");
                }
                Console.WriteLine($"Toan bo ma tran: Min = {Min}, Max = {Max}");
            }

            static void SapxepMatran(int[][] matrix)
            {
                for (int i = 0; i < matrix.Length - 1; i++)
                {
                    for (int j = 0; j < matrix.Length - 1 - i; j++)
                    {
                        int sumJ = matrix[j].Sum();
                        int sumJPlus1 = matrix[j + 1].Sum();

                        if (sumJ > sumJPlus1)
                        {
                            var temp = matrix[j];
                            matrix[j] = matrix[j + 1];
                            matrix[j + 1] = temp;
                        }
                    }
                }

                Console.WriteLine("Ma tran sau khi sap xep cac dong theo thu tu tang dan theo tong gia tri:");
                InMatran(matrix);
            }

            static void InPhantuDong(int[][] matrix)
            {
                Console.WriteLine("Cac phan tu la so nguyen to:");
                foreach (var row in matrix)
                {
                    foreach (var item in row)
                    {
                        if (IsPrime(item))
                        {
                            Console.Write(item + "\t");
                        }
                    }
                    Console.WriteLine();
                }
            }
            static bool IsPrime(int num)
            {
                if (num < 2) return false;
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0) return false;
                }
                return true;
            }

            static void InVitriCuaX(int[][] matrix)
            {
                Console.Write("Nhap so X ma ban can tim: ");
                int X = int.Parse(Console.ReadLine());
                bool found = false;
                Console.WriteLine($"Cac vi tri cua {X}:");
                for (int i = 0; i < matrix.Length; i++)
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        if (matrix[i][j] == X)
                        {
                            Console.WriteLine($"Vi tri [{i + 1}, {j + 1}]");
                            found = true;
                        }
                    }
                }
                if (!found) Console.WriteLine($"Khong tim thay so {X}.");
            }

            static void ChuyenMatran(int[][] matrix)
            {
                int maxColumns = 0;
                foreach (var row in matrix)
                {
                    maxColumns = Math.Max(maxColumns, row.Length);
                }

                int[,] rectMatrix = new int[matrix.Length, maxColumns];
                for (int i = 0; i < matrix.Length; i++)
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        rectMatrix[i, j] = matrix[i][j];
                    }
                }

                Console.WriteLine("Ma tran chu nhat:");
                for (int i = 0; i < rectMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < rectMatrix.GetLength(1); j++)
                    {
                        Console.Write(rectMatrix[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }

        }

    }
}
