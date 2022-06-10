using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.OOPs
{
    class Account
    {
        string name;
        long acc_no;
        float balance=25000.00f;
        long mobile;

        public void Insert() 
        {
            Console.WriteLine("Enter Account Holders Name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter Account Number");
            acc_no = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Mobile Number:");
            mobile = Convert.ToInt64(Console.ReadLine());


        }
        public void Display()
        {
            Console.WriteLine("Name:-"+name);
            Console.WriteLine("Account Number:-"+acc_no);
            Console.WriteLine("Mobile Number:-"+mobile);
            Console.WriteLine("Balance:-"+balance);
        }
        public float Deposit(float balance1)
        {
            balance =balance + balance1;
            return balance;

        }
        public float Withdraw(float balance1)
        {
           balance =balance - balance1;
            return balance;

        }
        static void Main(string[] args)
        {
            Account a = new Account();
            a.Insert();
            a.Display();
            Console.WriteLine("Enter Amount To Deposit");
            Console.WriteLine("Balance:-"+ a.Deposit(Convert.ToSingle(Console.ReadLine())));
            Console.WriteLine("Enter Amount To Withdraw:-");
            Console.WriteLine("Balance:-" + a.Withdraw(Convert.ToSingle(Console.ReadLine())));
        }
    }
}
