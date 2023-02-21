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
    }
}
