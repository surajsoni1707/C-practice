using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.OOPs
{
    class ConstructorChain
    {
        string studName;
        int rollNo;
        float per;
        int passYear;
        string address;
        public ConstructorChain(string nm)
        {
            studName = nm;

        }
        public ConstructorChain(string nm,int rn, float pers): this("Suraj")
        {
            rollNo = rn;
            per = pers;
        }
        public ConstructorChain(string nm,int rn,float per,int py, string add):this("suraj",101,75.00f)
        {
            passYear = py;
            address = add;
        }
        public void Display()
        {
            Console.WriteLine(studName);
            Console.WriteLine(rollNo);
            Console.WriteLine(per);
            Console.WriteLine(passYear);
            Console.WriteLine(address);
        }

    }
    class Example
    {
        static void Main(string[] args)
        {
            ConstructorChain cc = new ConstructorChain("suraj", 101, 75.00f, 2020, "Aurangabad");
            cc.Display();
        }
    }
}
