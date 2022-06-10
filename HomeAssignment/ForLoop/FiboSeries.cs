using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.ForLoop
{
    class FiboSeries
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibbonaci Series:");
            int a = 0;
            int b = 1;
            int sum = 0;
            for(int i=0;i<8;i++)
            {
                sum = a + b;
                Console.Write("\t"+sum);
                a = b;
                b = sum;
                
            }
            Console.WriteLine("");
            // Program to Diplay 2,5,10,17,26,37,50
            for(int i=1;i<8;i++)
            {
                Console.Write("\t"+(i*i+1));
            }
        }
    }
}
