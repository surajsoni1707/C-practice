using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment
{
    class TrimorphicNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int cube = num1 * num1 * num1;
            int lastDigit = cube % 10;
            Console.WriteLine("cube:{0}",cube);
            if(num1==lastDigit)
                Console.WriteLine("Number Is Trimorphic");
            else
                Console.WriteLine("Number Is Not Trimorphic");
        }
    }
}
