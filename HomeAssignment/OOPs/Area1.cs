using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.OOPs
{
    class Area1
    { float area;
        float pi = 3.14f;
        public void Area(int a)
        {
            area = a * a;
            Console.WriteLine("Area Of Square Is:"+area);

        }
        public void Area(int length, int width)
        {
            area = length * width;
            Console.WriteLine("Area Of Rectangle:"+area);
        }
        public void AreaOfCircle(int b)
        {
            area = pi * b * b;
            Console.WriteLine("Area Of Circle:"+area);
        }

    }
    class Area2
    {
        static void Main(string[] args)
        {
            Area1 a = new Area1();
            Console.WriteLine( "Enter A side Of A Square" );
            a.Area(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Enter Width And Length of Rectangle:");
            int width = Convert.ToInt32(Console.ReadLine());
            int length = Convert.ToInt32(Console.ReadLine());
            a.Area(length, width);
            Console.WriteLine("Enter Radious of A circle:");
            a.AreaOfCircle(Convert.ToInt32(Console.ReadLine()));

        }
    }
}
