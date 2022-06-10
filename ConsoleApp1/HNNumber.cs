using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch
{
    class HNNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter A Number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int aa = num1;
            while(num1>0)
            {
                int a = num1 % 10;
                sum = sum + a;
                num1 = num1 / 10;
            }
            Console.WriteLine("Addition of digit is: {0}",sum);
            if(aa%sum==0)
                Console.WriteLine("Harshad niven Number");
            else
                Console.WriteLine("not a Harshad Niven Number");
        }
    }
}
