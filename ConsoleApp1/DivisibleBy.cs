using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DivisibleBy
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter A Number:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 5 == 0 && number % 11 == 0)
                Console.WriteLine("{0} is divisible by 5 & 11",number);
            else
                Console.WriteLine("{0} is not divisible by 5&11");
        }

    }
}
