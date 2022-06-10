using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.OOPs
{
    public class Employee
    {
        private int empId;
        private string empName;
        private float empSalary;

        public void SetEmpId(int id)
        {
            empId = id;
        }
        public void SetEmpName(string name)
        {
            empName = name;
        }
        public void SetEmpSalary(float sal)
        {
            empSalary = sal;
        }
        /********************************************************/
        public void GetEmpId()
        {
            Console.WriteLine("Id:"+empId);
        }
        public void GetEmpName()
        {
            Console.WriteLine("Employee Name:"+empName);
        }
        public void GetEmpSalary()
        {
            Console.WriteLine("Employee Salary:"+empSalary);
        }
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Console.WriteLine("Enter Employee ID:");
            emp.SetEmpId(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Enter Employee Name");
            emp.SetEmpName(Console.ReadLine());
            Console.WriteLine("Enter Salary:");
            emp.SetEmpSalary(Convert.ToSingle(Console.ReadLine()));
            emp.GetEmpId();
            emp.GetEmpName();
            emp.GetEmpSalary();

        }


    }
}
