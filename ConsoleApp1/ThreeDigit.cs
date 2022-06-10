using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ThreeDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Three Digit Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int first_digit = 0;
            int third_digit = 0;
            //int num1 = 0;
            if(num>99 && num<1000)
            {
               
                    third_digit = num % 10;
                    num = num / 10;

                int second_digit = num % 10;
                num = num / 10;

                first_digit = num % 10;
                int sum = first_digit + third_digit;
                Console.WriteLine("sum of 1st & 3rd digit is=" + sum);
            }
            else
                Console.WriteLine("invalid number,Enter Three digit Number");
           
        }
    }
}
