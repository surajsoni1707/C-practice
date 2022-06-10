using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.Inheritance
{
    class ParentClass
    {
       public ParentClass()
        {
            Console.WriteLine("Paren class constructor");
        }
        public void m1()
        {         
            Console.WriteLine("Parent Class Method");
        }
    }
    class ChildClass:ParentClass
    {
        public ChildClass()
        {
            Console.WriteLine("chaild class constructor");
        }
        static void Main(string[] args)
        {
            ChildClass c = new ChildClass();
            c.m1();
           
        }
    }
}
