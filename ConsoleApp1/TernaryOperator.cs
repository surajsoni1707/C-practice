using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch
{
    class TernaryOperator
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter A year:");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(year % 4 == 0 ? "Leap year" : "NOT A Leap Year");
        }
    }
}
