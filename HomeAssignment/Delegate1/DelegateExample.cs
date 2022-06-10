using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.Delegate1
{
    public delegate int mydel(int a, int b);
    public delegate void myString(string a);
    public delegate int MyDel3(int a);
    class DelegateExample
    {

        public int Sum1(int a, int b)
        {

            int total = a + b;
            return total;
        }
        public int Square1(int n)
        {
            return n * n;

        }
        public int Cube1(int n)
        {
            return n * n * n;

        }

        public void M1(string s)
        {
            Console.WriteLine(s);
        }

        public bool Even(int a)
        {
            if (a % 2 == 0)
                return true;
            else
                return false;
        }


        static void Main(string[] args)
        {
            DelegateExample s = new DelegateExample();
            mydel md = s.Sum1;
            int tot = md(5, 6);
            Console.WriteLine(tot);
            myString ms = (string s) => Console.WriteLine(s);
            ms("Hello");
           
            
            
            MyDel3 m3 = s.Square1;
            m3 = m3 + s.Cube1;
            Console.WriteLine(m3(5));
            m3 = m3 - s.Cube1;
            Console.WriteLine(m3(5));

            //Func Delegate
            Func<int,int> p1 = s.Square1;
            Console.WriteLine(p1(10));

            //Func Delegate using Lambda Expression
            Func<int, int, int> Mul = (a, b) => a * b;
            Console.WriteLine(Mul(10,20));


            //Action Delegate
            Action<string> ad = s.M1;
            ad("Helloooooooooooo");

            //Action Delegate using Lambda Expression
            Action<string> d1 = (string s) => Console.WriteLine(s);
            d1("abcdefg");

            //Predicate Delegate
            Predicate<int> pre = s.Even;
            Console.WriteLine(pre(15));

            //Predicate Delegate using Lambda Expression
            Predicate<int> p2 = (int a) => a == 15;
            Console.WriteLine(p2(15));

            //Predicate using Anonymus method

            Predicate<int> p3 = delegate (int n)
             {
                 if (n % 2 == 0)
                     return true;
                 else return false;
             };
            Console.WriteLine(p3(20));

        }
    }
    
}
