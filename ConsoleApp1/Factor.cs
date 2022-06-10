using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch
{
    class Factor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A value:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Factors of {0} are:",num);
            
            for(int i = 1;i<=num;i++)
            {
                if(num%i==0)
                Console.WriteLine(i);
            }

            Console.WriteLine("Factorial");
            Console.WriteLine("Enter A number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
                int sum = 1;
            for(int i=num2;i>0;i--)
            {
                sum=sum* i;
            }
            Console.WriteLine("Factorial of {0}={1}",num2,sum);

            Console.WriteLine("Series");
            int sum1 = 0;
            for (int i=1;i<=num2;i++)
            {
              
                sum1 = sum1 + i;
                Console.WriteLine(sum1);
            }

            Console.WriteLine("Multiplication");
            int mul = 1;
            for(int i=1;i<=num2;i++)
            {
                mul = mul * i;
                Console.WriteLine(mul);
            }


                
        }

    }
}
