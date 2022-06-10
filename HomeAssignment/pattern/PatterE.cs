using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.pattern
{
    class PatternE
    {
        static void Main(string[] args)
        {
            for (int r = 0; r < 5; r++)
            {
                for (int c = 0; c < 5; c++)
                {
                    if (c==0 || r==0 ||r==4 || r==2)
                    {
                        Console.Write("*");
                    }
                    /*else
                        Console.Write("*");*/
                }
                Console.WriteLine();
            }
        }
    }
}
