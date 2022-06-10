using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DayOfTheWeek
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A Number");
            int day = Convert.ToInt32(Console.ReadLine());
            switch(day)
            {
                case 1:
                    Console.WriteLine("MONDAY");
                    break;
                case 2:
                    Console.WriteLine("TUESDAY");
                    break;
                case 3:
                    Console.WriteLine("WENDSDAY");
                    break;
                case 4:
                    Console.WriteLine("THURSDAY");
                    break;
                case 5:
                    Console.WriteLine("FRIDAY");
                    break;
                case 6:
                    Console.WriteLine("SATURDAY");
                    break;
                case 7:
                    Console.WriteLine("SUNDAY");
                    break;
                default:
                    Console.WriteLine("Erro, day does not exist");
                    break;
            }
        }
    }
}
