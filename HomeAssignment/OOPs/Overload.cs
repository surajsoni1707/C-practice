using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.OOPs
{
    class Overload
    {
        public void Pattern(int i)
        {
            for(int a=0;a<i;a++)
            {
                for (int b=0;b<i;b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
        public void Pattern(int i, int j, char c)
        {
            for (int a = 0; a < i; a++)
            {
                for (int b = 0; b < j; b++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Overload o = new Overload();
            o.Pattern(5);
            o.Pattern(5, 8, 's');

        }
    }
}
