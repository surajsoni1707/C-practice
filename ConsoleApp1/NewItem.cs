using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class NewItem
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter name-");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Age-");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Height-");
            float height =Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter Gender M/F-");
            char gender = Convert.ToChar(Console.ReadLine());
            
            
            Console.WriteLine("Name="+name);
            Console.WriteLine("Age="+age);
            Console.WriteLine("height="+height);
            Console.WriteLine("Gender="+gender);
        }

    }
}
