using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment
{
    class TwinPrimeNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Numer:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int count1 = 0;
            int count2=0;
            for (int i = 2; i <= num1 / 2 ; i++)
            {
                if(num1%i==0)
                {
                    count1++;
                }
                    
            }
            if(count1==0)
                Console.WriteLine("{0} is prime Number",num1);
            else
                Console.WriteLine("{0} is not A Prime Number",num1);
            for (int i = 2; i <= num2 / 2; i++)
            {
                if (num2 % i == 0)
                {
                    count2++;
                }

            }
            if (count2 == 0)
                Console.WriteLine("{0} is prime Number", num2);
            else
                Console.WriteLine("{0} is not A Prime Number", num2);
            if(count1==0 && count2==0 && (num1-num2==2 || num2-num1==2))
                Console.WriteLine("{0} and {1} are twin prime numbers",num1,num2);
            


        }
    }
}
