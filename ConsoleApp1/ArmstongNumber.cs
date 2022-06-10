using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch
{
    class ArmstongNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A Number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = num1;
            int sum = 0;
            while(num1>0)
            {
                int a = num1 % 10;
                sum = sum + (a * a * a);
                num1 = num1 / 10;

            }
            if(num2==sum)
                Console.WriteLine("Armstrong Number");
            else
                Console.WriteLine("Not A Armstrong Number");
        }
    }
}
