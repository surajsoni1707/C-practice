using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.OOPs
{
    class Calculator
    {
        static int abc = 10;
        public int Add()
        {
            
            Console.WriteLine("Enter First Value:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter First Value:");
            int b = Convert.ToInt32(Console.ReadLine());
            return a + b;
        }
        public float SimpleIntrest()
        {
            Console.WriteLine("Enter Principle Amount");
            float principle_amt = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter Anual Intrest Rate");
            float intrest = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter time in years");
            float time = Convert.ToSingle(Console.ReadLine());
            float si = (principle_amt *intrest * time)/100;
            return si;
        }

        public bool LeapYear()
        {
            bool aa;
            Console.WriteLine("Enter A Year");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0)
            { aa = true; }
            else
                aa = false;
            return aa;

        }
    }
    class Calc
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            Console.WriteLine("Addition Is:"+c.Add());
            Console.WriteLine("Simple Intrest:"+c.SimpleIntrest());
            bool aa = c.LeapYear();
            if(aa==true)
                Console.WriteLine("leap Year");
            else
                Console.WriteLine("Not A Leap Year");



        }
    }
}
