using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.ForLoop
{
    class OddNumberUsingFor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First 10 Odd Numbers Are:");
            int count = 0;
            int sum = 0;
            for(int i=0;count<10;i++)
            {
                if(i%2!=0)
                {
                    Console.WriteLine(i);
                    sum = sum + i;
                    count++;
                }
            }
            Console.WriteLine("Addition Of First 10 Odd Number Is:"+sum);
        }

    }
}
