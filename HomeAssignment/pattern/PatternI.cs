using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.pattern
{
    class PatternI
    {
        static void Main(string[] args)
        {
            for (int r = 0; r < 5; r++)
            {
                for (int c = 0; c < 5; c++)
                {
                    if ( r==0 || r==4 || c==2)
                    {
                        if (r>=1 && r<4 && c==2)
                        {
                            Console.Write("  *");
                        }
                        else
                            Console.Write("*");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
