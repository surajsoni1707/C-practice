using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.OOPs
{
    class Order
    {
        int orderId;
        int orderDate;
        Customer c;
        Item item;

        public int OrderId { get => orderId; set => orderId = value; }
        public int OrderDate { get => orderDate; set => orderDate = value; }
        internal Customer C { get => c; set => c = value; }
        internal Item Item { get => item; set => item = value; }
    }
    class Customer
    {
        int custId;
        String custName;
        Address add;

        public int CustId { get => custId; set => custId = value; }
        public string CustName { get => custName; set => custName = value; }
        internal Address Add { get => add; set => add = value; }
    }
    class Address
    {
        String city;
        string state;

        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
    }
    class Item
    {
        int itemId;
        string itemName;
        int itemPrice;

        public int ItemId { get => itemId; set => itemId = value; }
        public string ItemName { get => itemName; set => itemName = value; }
        public int ItemPrice { get => itemPrice; set => itemPrice = value; }
    }
    class Order1
    {
        static void Main(string[] args)
        {
            Order o = new Order();
            Console.WriteLine("Enter Order ID: ");
            o.OrderId =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ente Order Date: "); 
            o.OrderDate = Convert.ToInt32(Console.ReadLine());
            o.C = new Customer();
            Console.WriteLine("Enter Cust ID: ");
            o.C.CustId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Customer Name: ");
            o.C.CustName = Console.ReadLine();
            o.C.Add = new Address();
            Console.WriteLine("Enter City: ");
            o.C.Add.City = Console.ReadLine();
            Console.WriteLine("Enter State: ");
            o.C.Add.State = Console.ReadLine();
            o.Item = new Item();
            Console.WriteLine("Item ID: ");
            o.Item.ItemId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Item Name: ");
            o.Item.ItemName = Console.ReadLine();

            Console.WriteLine("Enter Item Price: ");
            o.Item.ItemPrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("************************************");
            Console.WriteLine("************************************");
            Console.WriteLine("Order Id: "+o.OrderId);
            Console.WriteLine("Oeder Date: "+o.OrderDate);
            Console.WriteLine("Customer Id: "+o.C.CustId);
            Console.WriteLine("Customer Name: "+o.C.CustName);
            Console.WriteLine("Customer City&State: "+o.C.Add.City+","+o.C.Add.State);
            Console.WriteLine("Item Id: "+o.Item.ItemId);
            Console.WriteLine("Item Name: "+o.Item.ItemName);
            Console.WriteLine("Item Price: "+o.Item.ItemPrice);


        }
    }
}
