using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.ForLoop
{
    class CommonFactorsOf2Numbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int smallNumber,bigNumber;
            if(num1>num2)
            {
                smallNumber = num2;
                bigNumber = num1;
            }
            else if(num1<num2)
            {
                smallNumber = num1;
                bigNumber = num2;

            }
            else
            {
                smallNumber = num1;
                bigNumber = num2;

            }
            for (int i=1;i<=smallNumber;i++)
            {
                if(num1%i==0)
                {
                    for(int j=i;j<bigNumber;j++)
                    {
                        if(num2%j==0 && i==j )
                            Console.WriteLine(j);
                    }
                    
                }
            }
        }

    }
}
