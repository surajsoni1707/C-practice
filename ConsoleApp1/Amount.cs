using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Amount
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Amount");
            int amount = Convert.ToInt32(Console.ReadLine());
            int discount = amount * 20 / 100;
            Console.WriteLine("Total Discount on"+amount+"is="+discount);
            int payable = amount - discount;
            Console.WriteLine("Net Payable="+payable);
        }
    }
}
