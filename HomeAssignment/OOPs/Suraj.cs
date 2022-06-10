using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.OOPs
{
    class Suraj
    {
        public Suraj()
        {
            Console.WriteLine(" in Constructor");
        }
        public void m1()
        {
            Console.WriteLine("In m1");
            m2();
        }
        public void m2()
        {
            Console.WriteLine("In m2");
            Suraj.m3();
        }
        public static void m3()
        {
            Console.WriteLine("In m3");
           

        }
        public static void  m4() 
        {
            Console.WriteLine("In m4");
            m3();
        }
        static void Main(string[] args)
        {
            Suraj s = new Suraj();
            s.m1();
            s.m2();
             Suraj.m3();
            Suraj.m4();
        }


    }
}
