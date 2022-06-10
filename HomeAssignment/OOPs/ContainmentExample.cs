using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.OOPs
{
    class ContainmentExample
    {
        public int ReturnSum(int a,int b)
        {
            return a + b;
        }
    }
    public class class2
    {
        ContainmentExample c1;
        public void SampleMetod()
        { }
        public int CallBase(int a,int b)
        {
            c1 = new ContainmentExample();
            return c1.ReturnSum(a, b);

        }
    }
    class Class3
    {
        static void Main(string[] args)
        {
            class2 c2 = new class2();
            Console.WriteLine(c2.CallBase(5, 8));


        }
    }
}
