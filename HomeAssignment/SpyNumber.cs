using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment
{
    class SpyNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A numbber:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int product = 1;
            while(num1>0)
            {
                int a = num1 % 10;
                sum = sum + a;
                product = product * a;
                num1 = num1 / 10;
            }
            if(sum==product)
                Console.WriteLine("Entered number is SPY Number");
            else
                Console.WriteLine("Entered Number IS not A SPY Number");
        }
    }
}
