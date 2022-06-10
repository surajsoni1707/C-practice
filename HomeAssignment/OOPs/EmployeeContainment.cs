using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.OOPs
{
    public class EmployeeContainment
    {
        int empId;
        String empName;
        int empSal;
        Dept department;
        public EmployeeContainment() { }

        public int EmpId { get => empId; set => empId = value; }
        public string EmpName { get => empName; set => empName = value; }
        public int EmpSal { get => empSal; set => empSal = value; }
        internal Dept Department { get => department; set => department = value; }
    }
   public  class Dept
    {
        int deptId;
        String deptName;
        String deptManaer;

        public int DeptId { get => deptId; set => deptId = value; }
        public string DeptName { get => deptName; set => deptName = value; }
        public string DeptManaer { get => deptManaer; set => deptManaer = value; }
    }
    class Main1
    {
        static void Main(string[] args)
        {


            EmployeeContainment e = new EmployeeContainment();
            e.Department = new Dept();
            Console.WriteLine(e.EmpId = 101);
            Console.WriteLine(e.EmpName = "Suraj");
            Console.WriteLine(e.EmpSal = 25000);
            Console.WriteLine(e.Department.DeptId = 01);
            Console.WriteLine(e.Department.DeptName = "IT");
            Console.WriteLine(e.Department.DeptManaer = "Abc");

        }
    }
}
