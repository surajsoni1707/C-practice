using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.OOPs
{
    class SecondMaxDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int num1 = num;
            int max = 0;
            int max2 = 0;
            int rem = 0;
            while(num>0)
            {
                rem = num % 10;
                if(rem>max)
                {
                    
                    max = rem;
                }
                
                else if((rem<max) && (rem>max2))
                {
                    max2 = rem;
                }
                num = num / 10;

            }
            

            Console.WriteLine("Second Largest Digit is:"+max2);


        }
    }
}
