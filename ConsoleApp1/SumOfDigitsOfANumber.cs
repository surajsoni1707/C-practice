using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SumOfDigitsOfANumber
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter A Digit=");
            int digit = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int remainder;
            while(digit>0)
            {
                remainder = digit % 10;
                sum = sum + remainder;
                digit = digit / 10;

            }
            Console.WriteLine("Sum Of Digits="+sum);
        }
    }
}
