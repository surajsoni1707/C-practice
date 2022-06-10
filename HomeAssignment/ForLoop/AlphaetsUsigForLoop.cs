using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.ForLoop
{
    class AlphaetsUsigForLoop
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alphabets using for loop");
            for(int i=97;i<=122;i++)
            {
                char ch = (char)i;
                Console.Write(ch);
                Console.Write("\t");
            }
        }
    }
}
