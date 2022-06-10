using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class NumberInWord
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A Number");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("ONE");
                    break;
                case 2:
                    Console.WriteLine("TWO");
                    break;
                case 3:
                    Console.WriteLine("THREE");
                    break;
                case 4:
                    Console.WriteLine("FOUR");
                    break;
                case 5:
                    Console.WriteLine("FIVE");
                    break;
                default:
                    Console.WriteLine("invalid number");
                    break;
            }
        }
    }
}
