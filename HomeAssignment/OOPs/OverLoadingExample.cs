using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.OOPs
{
    class OverLoadingExample
    {
        double v;
        public double Volume(double r)
        {
             v= (4 / 3) * (22 / 7) * (r*3);
            return v;
        }
        public double Volume(double h,double r)
        {
            v = (22 / 7) * (r * 2) * h;
            return v;
        }
        public double Volume( double l, double b,double h)
        {
            v = l * b * h;
            return v;
        }
        static void Main(string[] args)
        {
            OverLoadingExample e = new OverLoadingExample();
            Console.WriteLine("Volume Of Sphere:"+e.Volume(12.00d));
            Console.WriteLine("Volume Of Cylinder:"+e.Volume(10.00d, 12.00d));
            Console.WriteLine("Volume Of Cuboid:"+e.Volume(12, 13, 14));
        }
    }
}
