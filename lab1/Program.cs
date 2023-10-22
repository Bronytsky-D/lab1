using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task_2();
        }
        static void Task_1()
        {
            Console.WriteLine("The octal equivalent of {0} is {1}");

            Console.WriteLine("The octal equivalent of {0} is {1}");
            Console.WriteLine("The octal equivalent of {0} is {1}"); 
            Console.WriteLine("The octal equivalent of {0} is {1}"); 
            Console.WriteLine("The octal equivalent of {0} is {1}"); 
            Console.WriteLine("The octal equivalent of {0} is {1}");

            Console.WriteLine("The octal equivalent of {0} is {1}");
            Console.WriteLine("The octal equivalent of {0} is {1}");
            Console.WriteLine("The octal equivalent of {0} is {1}");
            Console.WriteLine("The octal equivalent of {0} is {1}");
            int octal = 0, i = 1;
            Console.Write("Enter a decimal number: ");
            int decimalNumber = int.Parse(Console.ReadLine());
            int temp = decimalNumber;
            while (temp > 0)
            {
                int remainder = temp % 8;
                octal += remainder * i;
                i *= 10;
                temp /= 8;
            }
            Console.WriteLine("The octal equivalent of {0} is {1}.", decimalNumber, octal);
        }
        static void Task_2()
        {
            Console.Write("Введіть x : ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введіть y : ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Введіть z : ");
            double z = double.Parse(Console.ReadLine());
            double a, b, c;
            a = (x * y) / z + z / (x * y);
            b = Math.Sin(((x * y) + z) / z) - Math.Cos(1 + (z / (x * y))) + 0.5;
            c = 2 - Math.Sqrt(Math.Pow(((x * y) / z) + (z / (x * y)), 2) + 5);
            Console.WriteLine($"a {a}, b {b}, c{c}");
            if (a <= b && a <= c)
                Console.WriteLine($"Min val is a= {a}");
            else if (b <= a && b <= c)
                Console.WriteLine($"Min val is b= {b}");
            else
                Console.WriteLine($"Min val is c= {c}");
        }
        static void Task_3()
        {
            int[,] A = GenerateMatrix();
            writeMatrix(A);
            int[] b = new int[A.GetLength(0)];
            int count = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] % 2 == 0)
                    {
                        count++;
                    }
                }
                b[i] = count;
                count = 0;
            }
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write($"{b[i]} ");
            }
            Console.WriteLine($"--max elem b {b.Max()}");
        }
        public static int[,] GenerateMatrix()
        {
            int rows = 5;
            int cols = 7;
            int[,] matrix = new int[rows, cols];
            Random random = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = random.Next(0, 100);
                }
            }

            return matrix;
        }
        public static void writeMatrix(int[,] matrix) 
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.Write($"\n");
            }

        }
        
    }
}
