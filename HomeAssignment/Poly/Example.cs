using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.Poly
{
    class Example
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int rem = 0;
            int max1 = 0;
            int max2 = 0;
            int count1 = 0;
            int count2 = 0;
            while(num>0)
            {
                rem = num % 10;
                if(rem>max1)
                {
                    max1 = rem;
                    count1++;
                }
                else if(max1>max2 && max1>rem)
                {
                    max2 = max1;
                    count2++;
                }
                num = num / 10;
            }
            if(count1>1 && count2==0)
            { Console.WriteLine("Decreasing"); }
            else if(count1==1 && count2>0)
            {
                Console.WriteLine("Increasing");
            }
            else if(count1>0 && count2>0)
            {
                Console.WriteLine("Bouncy");
            }
            
        }
    }
}
