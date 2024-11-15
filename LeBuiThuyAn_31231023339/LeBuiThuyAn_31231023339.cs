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
            Random random = new Random();
            Console.Write("Nhap so dong n cua ma tran: "); int n = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[n][];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap so cot cho dong {i + 1}: ");
                int k = int.Parse(Console.ReadLine());
                jaggedArray[i] = new int[k];

                Console.WriteLine($"Nhap {k} phan tu ngau nhien cho dong {{i + 1}}: ");
                for (int j = 0; j < k; j++)
                {
                    jaggedArray[i][j] = int.Parse(Console.ReadLine());
                }
            }
            displayMenu(jaggedArray);
        }

        static void displayMenu(int[][] jaggedArray)
        {
            while (true)
            {
                Console.WriteLine("\nMenu: ");
                Console.WriteLine("1. In ra ma tran da nhap");
                Console.WriteLine("2. In ra phan tu lon nhat, nho nhat tren moi dong va tren toan bo ma tran");
                Console.WriteLine("3. Sap xep cac dong theo thu tu tang dan");
                Console.WriteLine("4. In ra cac phan tu cua dong la so nguyen to");
                Console.WriteLine("5. In ra tat ca vi tri xuat hien cua mot so X nhap tu nguoi dung");
                Console.WriteLine("6. Chuyen ma tran ve ma tran chu nhat voi cac o thieu duoc dien bang so 0");
                Console.WriteLine("7. Thoat");

                while(true)
                {
                    Console.WriteLine("Hay chon chuc nang: ");
                    int luachon = int.Parse(Console.ReadLine());

                    switch (luachon)
                    {
                        case 1: InMatran(jaggedArray); break;
                        case 2: TimMinMax(jaggedArray); break;
                        case 3: SapxepMatran(jaggedArray); break;
                        case 4: InPhantuDong(jaggedArray); break;
                        case 5: InVitriCuaX(jaggedArray); break;
                        case 6: ChuyenMatran(jaggedArray); break;
                        case 7: return;
                        default:
                            Console.WriteLine("Lua chon ban nhap khong hop le.");
                            break;
                    }
                }  
            }
        }

        static void InMatran(int[][] jaggedArray)
        {
            Console.WriteLine("\nMa tran ban da nhap la: ");
            foreach (var row in jaggedArray)
            {
                foreach (var item in row)
                {
                    Console.WriteLine(item + "\t");
                }   
                Console.WriteLine();
            }
        }

        static void TimMinMax(int[][] jaggedArray)
        {
            int Max = int.MaxValue; int Min = int.MinValue;
            Console.WriteLine("Phan tu  lon nhat, nho nhat tren moi dong: ");
            foreach (var row in jaggedArray)
            {
                int rowMax = row.Max();
                int rowMin = row.Min();
                Console.WriteLine($"Dong: Max = {rowMax}, Min = {rowMin}");
                if (rowMax > Max) Max = rowMax;
                if (rowMin > Min) Min = rowMin;
            }
            Console.WriteLine($"Tren toan bo ma tran: Max = {Max}, Min = {Min}");
        }

        static void SapxepMatran(int[][] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.Length - 1; i++)
            {
                for (int j = 0; j < jaggedArray.Length - 1 - i; j++)
                {
                    int sumJ = jaggedArray[j].Sum();
                    int sumJPlus1 = jaggedArray[j + 1].Sum();

                    if (sumJ > sumJPlus1)
                    {
                        var temp = jaggedArray[j];
                        jaggedArray[j] = jaggedArray[j + 1];
                        jaggedArray[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Ma tran sau khi sap xep cac dong theo thu tu tang dan theo tong gia tri:");
            InMatran(jaggedArray);
        }

        static void InPhantuDong(int[][] jaggedArray)
        {
            Console.WriteLine("\nCac phan tu la so nguyen to trong tung dong: "); 
            foreach (var row in jaggedArray)
            {
                foreach (var item in row)
                {
                    if (IsPrime(item))
                    {
                        Console.Write(item + "\t");
                    }
                }
                Console.WriteLine() ;
            }
        }

        static bool IsPrime (int num)
        {
            if (num < 2) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }

        static void InVitriCuaX(int[][] jaggedArray)
        {
            Console.Write("Nhap so X ma ban can tim: ");
            int X = int.Parse(Console.ReadLine());
            bool found = false;
            Console.WriteLine($"Cac vi tri cua {X}:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    if (jaggedArray[i][j] == X)
                    {
                        Console.WriteLine($"Vi tri [{i + 1}, {j + 1}]");
                        found = true;
                    }
                }
            }
            if (!found) Console.WriteLine($"Khong tim thay so {X}.");
        }

        static void ChuyenMatran(int[][] jaggedArray)
        {
            int maxColumns = 0;
            foreach (var row in jaggedArray)
            {
                maxColumns = Math.Max(maxColumns, row.Length);
            }

            int[,] rectMatrix = new int[jaggedArray.Length, maxColumns];
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    rectMatrix[i, j] = jaggedArray[i][j];
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
