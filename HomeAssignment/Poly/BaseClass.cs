using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.Poly
{
     class BaseClass
    {
        public readonly int a;
        public const int b=10;

        public BaseClass(int a)
        {
            this.a = a;
            Console.WriteLine("Value of a:"+a);
            
          
        }
    }
     class ChildClass1:BaseClass
    {
        public ChildClass1(int a):base(a)
       { }
      
    }
    class ChildOfChild:ChildClass1 
    {
       public ChildOfChild(int a):base(a) { }
    }
    class A1
    {
        static void Main(string[] args)
        {
            ChildOfChild c = new ChildOfChild(20);
            int m=c.a;
            int n = ChildClass1.b;
            Console.WriteLine("m="+m);
            Console.WriteLine("n="+n);
        }
    }
    


}
