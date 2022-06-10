using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch
{
    class OddNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Odd Numbers Between 200 -150 are:");
            for(int i=200;i>=150;i--)
            {
                if(i%2==1)
                    Console.WriteLine(i);
            }

        }
    }
}
