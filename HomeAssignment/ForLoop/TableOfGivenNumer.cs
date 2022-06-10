using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.ForLoop
{
    class TableOfGivenNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eter A Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Table of {0} is:",num1);
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(num1*i);
            }
        }
    }
}
