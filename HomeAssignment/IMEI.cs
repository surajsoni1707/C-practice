using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment
{
    class IMEI
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 15 Digit IMEI Number:");
            long imei = Convert.ToInt64(Console.ReadLine());
            long imei2 = imei;
            int count = 0;
            int sum = 0;
            while(imei>0)
            {
                imei = imei / 10;
                count++;

            }
            imei = imei2;
            if(count==15)
            {
                for(int i=1;i<=15;i++)
                {
                    int d = (int)(imei % 10);
                    imei = imei / 10;
                    if (i % 2 == 0)
                    {
                        int d1 = 2 * d;
                        if(d1>9)
                        {
                            int a = d1 % 10;
                            int b = d1 / 10;
                            d1 = a + b;
                        }
                        d = d1;

                    }
                    
                    sum = sum + d;
                    //Console.WriteLine(sum);
                }
                Console.WriteLine(sum);
                if(sum%10==0)
                {
                    Console.WriteLine("valid IMEI number");
                }
                else
                    Console.WriteLine("Invalid IMEI number");
            }
            else
                {
                    Console.WriteLine("Enter 15 digit imei number");
                }
        
                }
    }
}
