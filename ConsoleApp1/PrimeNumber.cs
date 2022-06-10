using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for(int i=2;i<num;i++)
            {
                if(num%i==0)
                {
                    count++;
                }

            }
            if(count==0|| num==1 || num==2)
            {
                Console.WriteLine("Entered Number Is Prime");
            }
            else
                Console.WriteLine("Entered Number is Not Prime.");

        }
    }
}
