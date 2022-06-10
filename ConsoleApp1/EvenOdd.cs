using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class EvenOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if(num1%2==0)
                Console.WriteLine("{0} is even number", num1);
            else
                Console.WriteLine("{0} is odd number",num1);
        }
    }
}
