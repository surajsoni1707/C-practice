using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.OOPs
{
    class Account1
    {
        string cust_name;
        long acc_no;
        public Account1()
        {
            Console.WriteLine("Enter Customer Name:-");
            cust_name = Console.ReadLine();
            Console.WriteLine("Enter Account Number:-");
            acc_no = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("I am in Default Constructor");
        }
        public void Display()
        {
            Console.WriteLine("Customer name:"+cust_name);
            Console.WriteLine("Account Number:"+acc_no);
        }
        public Account1(string name, long acc_no)
        {
            this.cust_name = name;
            this.acc_no = acc_no;
            Console.WriteLine(" I am In Parameterized Constructor");

        }
        static void Main(string[] args)
        {
            Account1 aa = new Account1();
            aa.Display();
           
            Account1 aa1 = new Account1("Suraj", 123456987);
            aa1.Display();
        }
    }
}
