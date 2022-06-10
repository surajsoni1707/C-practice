using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Enter A number");
        
            int a = Convert.ToInt32(Console.ReadLine());

            if(a%7==0)
             {
            Console.WriteLine("- is divisible by 7");
            }

            else
                Console.WriteLine(a + "- is not divisible by 7");
            if(a%10==7)
            Console.WriteLine( "last digit is 7");
            else
            Console.WriteLine("Last Digit is not 7");



        }
    }
}
