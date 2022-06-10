using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class AreaAndPerimeterOfSquare
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Side of a Square=");
            int side = Convert.ToInt32(Console.ReadLine());
            int area = side * side;
            int perimeter = 4 * side;
            Console.WriteLine("Area Of A Square="+area);
            Console.WriteLine("Perimeter Of A Square="+perimeter);
        }
    }
}
