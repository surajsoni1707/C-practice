using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.OOPs
{
    class Student
    {
        int age;
        string name;
        float percentage;
        public void SetAge(int age)
        {
            this.age = age;
        }
        public void SetName(string name)
        {
            this.name = name;

        }
        public void SetPercentage(float per)
        {
            this.percentage = per;
        }
        /***********************************************************/
        public void GetAge()
        {
            Console.WriteLine(  "Age:"+age);
        }
        public void GetName()
        {
            Console.WriteLine(  "Student Name"+name);

        }
        public void GetPercentage()
        {
            Console.WriteLine("Percentage:"+percentage);
        }
    }
    class Student2
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            Console.WriteLine("Enter Name Of The Student:");
            s.SetName(Console.ReadLine());
            Console.WriteLine("Enter Age:");
            s.SetAge(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Enter Percentage:");
            s.SetPercentage(Convert.ToSingle(Console.ReadLine()));
            s.GetName();
            s.GetAge();
            s.GetPercentage();
        }
    }
}
