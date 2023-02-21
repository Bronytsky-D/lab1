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
            Task_1();
        }
        static void Task_1()
        {
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
            if (a >= b && a <= c)
                Console.WriteLine($"Min val is b= {b}");
            else if (a <= b && a <= c)
                Console.WriteLine($"Min val is a= {a}");
            else
                Console.WriteLine($"Min val is c= {c}");
        }

    }
}
