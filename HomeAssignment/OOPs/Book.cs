using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.OOPs
{
   public class Book
    {
        String bookName;
        int price;
        string author;
        string publication;
        public Book()
        {
            Console.WriteLine("Constructor1");
        }
       public void setDetails(String bookName, int price, string author, string publication)
        {
             this.bookName=bookName;
            this.price=price;
            this.author=author;
            this.publication=publication;
            //Console.WriteLine("Book Name:"+bookName);
           // Console.WriteLine("Book Price:" + price);
            //Console.WriteLine("Books Author:" + author);
            //Console.WriteLine("Publication:" + publication);

        }
        public void setDetails2()
        {
            Console.WriteLine("Enter book Name:");
            bookName = Console.ReadLine();
            Console.WriteLine("Enter Book Price:");
            price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Author:");
            author=Console.ReadLine();
            Console.WriteLine("Enter Publication");
            publication=Console.ReadLine();
        }
        public void display()
        {
            Console.WriteLine("Book Name:" + bookName);
            Console.WriteLine("Book Price:" + price);
            Console.WriteLine("Books Author:" + author);
            Console.WriteLine("Publication:" + publication);

        }
    }
    class Book2
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();
            b1.setDetails("ABCD", 375, "AMAN", "NAVNEET");
            b1.display();
            Book b2 = new Book();
            b2.setDetails2();
            b2.display();
            
            

        }
    }
}
