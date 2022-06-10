using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch
{
    class BaseIndex
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Base:");
            int base1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter index:");
            int index = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            for(int i=1;i<=index;i++)
            {
                result = result * base1;
            }
            Console.WriteLine("Result: {0}",result);

        }
    }
}
