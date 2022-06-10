using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class PositiveOrNegativeNumber
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter A Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 < 0)
                Console.WriteLine("{0} is Negative Number",num1);
            else if (num1 > 0)
                Console.WriteLine("{0} is Positive Number", num1);
            else
                Console.WriteLine("Entered number is 0");
        }

    }
}
