using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Year:");
            int year = Convert.ToInt32(Console.ReadLine());
            if(year%4==0)
                Console.WriteLine("{0} is a Leap Year",year);
            else
                Console.WriteLine("{0} is Not a Leap Year",year);
        }
    }
}
