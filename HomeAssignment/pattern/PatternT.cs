using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.pattern
{
    class PatternT
    {
        static void Main(string[] args)
        {
            for(int r=0;r<5;r++)
            {
                for(int c=0;c<5;c++)
                {
                    if(r==0 || c==2)
                    {
                        if(c==2 && r>0)
                        {
                            Console.Write("  *");
                        }
                        else
                        Console.Write("*");
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}
