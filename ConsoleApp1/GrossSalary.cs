using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class GrossSalary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Basic Salary Of an Employee:");
            float basic_salary = Convert.ToSingle(Console.ReadLine());
            float hra=0;
            float da = 0;
            float gross_salary = 0;
            if(basic_salary<=10000)
            {
                hra = basic_salary * 20 / 100;
                da = basic_salary * 80 / 100;
                gross_salary = basic_salary + hra + da;
            }
            else if (basic_salary > 10000 && basic_salary<=20000)
            {
                hra = basic_salary * 25 / 100;
                da = basic_salary * 90/ 100;
                gross_salary = basic_salary + hra + da;
            }
            else
            {
                hra = basic_salary * 30 / 100;
                da = basic_salary * 95 / 100;
                gross_salary = basic_salary + hra + da;
            }
            Console.WriteLine("HRA="+hra);
            Console.WriteLine("DA="+da);
            Console.WriteLine("Gross Salary="+gross_salary);
        }
    }
}
