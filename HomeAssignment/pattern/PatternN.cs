using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.pattern
{
    class PatternN
    {
        static void Main(string[] args)
        {
            for (int r = 0; r < 5; r++)
            {
                for (int c = 0; c < 5; c++)
                {
                    if((c==0 &&r>=0 &&r<5) || (c == 4 && r >= 0 && r < 5))
                    {
                        
                        Console.Write("*");
                        
                    }
                    if(r==c)
                    {
                        Console.Write("*");
                    }
                    Console.Write(" ");


                   
                }
                Console.WriteLine();
            }
                //Console.WriteLine();
        }
    }
    
}
