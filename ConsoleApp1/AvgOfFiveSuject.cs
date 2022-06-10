using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class AvgOfFiveSuject
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name Of A Student=");
            string name = Console.ReadLine();
            Console.WriteLine("Enter The Marks of 1st subject=");
            int sub1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Marks of 2nd subject=");
            int sub2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Marks of 3rd subject=");
            int sub3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Marks of 4th subject=");
            int sub4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Marks of 5th subject=");
            int sub5 = Convert.ToInt32(Console.ReadLine());
            int total = sub1 + sub2 + sub3 + sub4 + sub5;
            Console.WriteLine("Total of FIve Subject="+ total);
            float avg = (sub1 + sub2 + sub3 + sub4 + sub5) / 5f;
                Console.WriteLine("Avg. of 5 Subject is="+avg);
        }
    }
}
