using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.pattern
{
    class Suraj
    {
        
        static void Main(string[] args)
        {
            int c = 0;
            for (char i='I';i<='U';i=(char)(i+4))
            {
                
                for(char j='I';j<=i;j=(char)(j+2))
                {
                    
                    Console.Write((char)(j));
                }
                
                Console.WriteLine();

            }
        }
    }
}
