using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.Poly
{
    class Parent
    {
        public virtual void m1()
        {
            Console.WriteLine("Parent class m2 method");
        }
    }
    class ChildClass:Parent
    {
        public override void m1()
        {
            Console.WriteLine("Child Class m1 method");
        }
    }
    class Cl
    {
        static void Main(string[] args)
        {
            Parent p = new Parent();
            p.m1();
        }
    }


}
