using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.Poly
{
    class Class1
    {
        public static void M1(int i)
        {
            if(i>0)
            {
                Console.WriteLine(i);
                M1(i - 1);
            }
        }
        static void Main(string[] args)
        {
            M1(5);
        }
    }
}
