using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Two Values:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;

            Console.WriteLine("Enter 1 For Addition");
            Console.WriteLine("Enter 2 For Subtraction");
            Console.WriteLine("Enter 3 For Multiplication");
            Console.WriteLine("Enter 4 For Division");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch(ch)
            {
                case  1:
                    {
                        result = num1 + num2;
                        Console.WriteLine("Addition:"+result);
                        break;
                    }
                case 2:
                    {
                        result = num1 - num2;
                      Console.WriteLine("Subtraction:" + result);
                            break;
                    }
                case 3:
                    {
                        result = num1 * num2;
                        Console.WriteLine("Multiplication:" + result);
                        break;
                    }
                case 4:
                    {
                        result = num1 / num2;
                        Console.WriteLine("Division:" + result);
                        break;

                    }
                default:
                    Console.WriteLine("invalid number, Enter number between 1 to 4");
                    break;

            }


        }
    }
}
