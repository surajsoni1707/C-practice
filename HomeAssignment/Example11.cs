using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment
{
    class Example11
    {
        static void Main(string[] args)
        {
            String s = Console.ReadLine();
            char[] str = s.ToCharArray();
            ArrayList al = new ArrayList();
            int count = 0;
            
           for(int i=0;i<str.Length-1;i++)
            {
                count = 0;
                for(int j=i+1;j<str.Length;j++)
                {
                    if(str[i]==str[j])
                    {
                        count++;
                    }
                }
               
                    if(count==0)
                    {
                         al.Add(str[i]);

                    }
                
            }
           foreach(var v in al)
            {
                Console.Write(v);
            }

        }
    }
    class Department
    {
        //string dept_name;
        //int dept_id;
        //string location;

        public string Dept_name { get; set; }
        public int Dept_id { get; set; }
        public string Location { get; set; }

        public override string ToString()
        {
            return Dept_name + " " + Dept_id + " " + Location;
        }

        static void Main(string[] args)
        {
            Department d = new Department();
            d.Dept_name = "Finance";
            d.Dept_id = 101;
            d.Location = "Aurangabad";
            Console.WriteLine("department name:"+d.Dept_name);
            Console.WriteLine("department id:"+d.Dept_id);
            Console.WriteLine("Location"+d.Location);
            Console.WriteLine();
            Console.WriteLine(d);
        }
    }
    class Emp
    {
         static int count = 0;
         public int id = 0;
        public string name;
        public int sal;
        public Emp(string n, int s)
        {
            count++;
            id = count;
            
            name = n;
            sal = s;
            //Console.WriteLine("id:"+id);
            //Console.WriteLine("name:"+name);
            //Console.WriteLine("salary"+sal);
        }
        public override string ToString()
        {
            return id + " " + name + " " + sal;
        }
    }

    class Emp1 { 
        static void Main(string[] args)
        {
            Emp e1 = new Emp("a", 10000);
           
            Emp e2 = new Emp("b", 10000);
            Emp e3= new Emp("c", 10000);
            Emp e4 = new Emp("d", 10000);
            Emp e5 = new Emp("e", 10000);
            Emp[] ob = new Emp[5];
            ob[0] = e1;
            ob[1] = e2;
            ob[2] = e3;
            ob[3] = e4;
            ob[4] = e5;
            foreach(dynamic d in ob)
            {
                Console.WriteLine(d);
            }



        }
    }

    class Example
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6];
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int count = 0;
            Array.Sort(arr);
            int bb1 = 0;
           
            int sum = Convert.ToInt32(Console.ReadLine());
            int[] temp = new int[arr.Length];
            for(int i=0;i<arr.Length;i++)
            {
                count = 0;
                int rem = sum;
                Array.Clear(temp,0,temp.Count()-1);
                for(int j=i;j<arr.Length;j++)
                {
                   
                    if(rem>=arr[j])
                    {
                        temp[count] = arr[j];
                        rem = rem - arr[j];
                       count++;
                    }
                    for (int l = j; l < arr.Length; l++)
                    {
                        if (rem == arr[l])
                        {
                            temp[count] = arr[l];
                            bb1++;
                        }
                    }
                    if (temp.Sum() == sum || bb1>0)
                    {
                        bb1++;
                        break;
                    }
                }
                if (bb1 > 0)
                    break;
              

            }
            foreach (dynamic d in temp)
            {
                if(d>0 || d<0)
                Console.Write(" " + d);
            }
            Console.WriteLine();

        }

    }
    public delegate void Mydel();
    class Bank
    {
        public event Mydel balIsZero;
        public event Mydel insufficientBal;
        int bal;
        public Bank()
        {
            bal = 0;
        }
        public void credit(int n)
        {
            bal = bal + n;
        }
        public void debit(int n)
        {
            if(bal<n)
            {
                insufficientBal();
            }
            if (bal >= n)
            {
                bal = bal - n;
                if(bal==0)
                {
                    balIsZero();
                }
            }
        }
    }
    class Bank1
    {
        static void InsufficientBalance()
        {
            Console.WriteLine("Insufficient Balance");
        }
        static void ZeroBalnce()
        {
            Console.WriteLine("Balance is zero");
        }
        static void Main(string[] args)
        {
            Bank b = new Bank();
            b.balIsZero += new Mydel(ZeroBalnce);
            b.insufficientBal += new Mydel(InsufficientBalance);
           // b.credit(100);
            b.debit(100);
        }
    }
}
