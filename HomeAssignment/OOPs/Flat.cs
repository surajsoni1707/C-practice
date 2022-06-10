using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.OOPs
{
    class Flat
    {
        int flatNo;
        string buildingName;
       
        Owner owner;

        public int FlatNo { get => flatNo; set => flatNo = value; }
        public string BuildingName { get => buildingName; set => buildingName = value; }
        //public string FlatOwner { get => flatOwner; set => flatOwner = value; }
        internal Owner Owner { get => owner; set => owner = value; }
    }
    class Owner
    {
        String ownerName;
        int age;
        String gender;

        public string OwnerName { get => ownerName; set => ownerName = value; }
        public int Age { get => age; set => age = value; }
        public string Gender { get => gender; set => gender = value; }
    }
    class main3
    {
        static void Main(string[] args)
        {
             Flat f = new Flat();
            Console.WriteLine( f.FlatNo = 100);
            Console.WriteLine( f.BuildingName = "A1");
           f.Owner = new Owner();
            Console.WriteLine( f.Owner.OwnerName = "XYZ");
            Console.WriteLine( f.Owner.Age = 45);
            Console.WriteLine(f.Owner.Gender = "Male");


        }
    }
}
