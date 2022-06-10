using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.OOPs
{
    class Person
    {
        int id;
        String name;
        Vehicle v;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        internal Vehicle V { get => v; set => v = value; }
    }
    class Vehicle
    {
        int vid;
        String vName;

        public int Vid { get => vid; set => vid = value; }
        public string VName { get => vName; set => vName = value; }
    }
    class Person1
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Id = 100;
            p.Name = "Suraj";
            p.V = new Vehicle();
            p.V.Vid = 10003;
            p.V.VName = "Avenger";
            Console.WriteLine("Person Id:"+ p.Id);
            Console.WriteLine("Person Name:"+ p.Name);
            Console.WriteLine("Vehicle Id:"+ p.V.Vid);
            Console.WriteLine("Vehicle Name:"+ p.V.VName);
            Console.WriteLine();
                Person p1 = new Person();
            p1.Id = 101;
            p1.Name = "Sumit";
            p1.V = new Vehicle();
            p1.V.Vid = 10004;
            p1.V.VName = "Pulser";
            Console.WriteLine("Person Id:" + p1.Id);
            Console.WriteLine("Person Name:" + p1.Name);
            Console.WriteLine("Vehicle Id:" + p1.V.Vid);
            Console.WriteLine("Vehicle Name:" + p1.V.VName); ;
        }
    }
}
