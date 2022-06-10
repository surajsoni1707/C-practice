using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.Collectionnn
{
    //1.	WAP to sort the elements of List that contains String objects. Print List.
    class ArrList
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList(5);

            for(int i=0;i<al.Capacity;i++)
            {
                al.Add(Console.ReadLine());
            }
            al.Sort();
            foreach(dynamic d in al)
            {
                Console.Write(d + " ");
            }
                
                
        }
    }
    //2.	WAP to create a class Employee with (name, designation ,salary).
    //Now create and add Employee objects elements to List. Print List.
    class Employee:IComparable
    {
        string name, designation;
         int salary;

        public Employee(string name, string designation, int salary)
        {
            this.Name = name;
            this.Designation = designation;
            this.Salary = salary;
        }
        
        public string Name { get => name; set => name = value; }
        public string Designation { get => designation; set => designation = value; }
        public int Salary { get => salary; set => salary = value; }

        public int CompareTo(object obj)
        {
            Employee e =(Employee) obj;

            return e.salary.CompareTo(salary);
        }

        public override bool Equals(object obj)
        {
            return obj is Employee employee &&
                   name == employee.name &&
                   designation == employee.designation &&
                   salary == employee.salary;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(name, designation, salary);
        }

        public override string ToString()
        {
            return "name:" + name + " " + "Designation:" + designation + " " + "Salary:" + salary;
        }
    }
    class listExample
    {
        static void Main(string[] args)
        {
            List<object> e = new List<object>();
            e.Add(new Employee("suraj", "Manager", 40000));
            e.Add(new Employee("rajesh", "developer", 25000));
            e.Add(new Employee("hema", "Secretary", 35000));
            e.Add(new Employee("suraj", "Manager", 40000));
            Console.WriteLine(e[2]);
            
            Console.WriteLine(e.Count);
            
            foreach (dynamic d in e)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine();
            for (int i = 0; i < e.Count; i++)
            {
                Console.WriteLine(e[i]);
            }
            e.Reverse();
            Console.WriteLine();
            for (int i = 0; i < e.Count; i++)
            {
                Console.WriteLine(e[i]);
            }


        }
    }
    //3.	WAP to create a Queue with some colors (String) using generics.
    class QueueExample
    {
       
       
        static void Main(string[] args)
        {
            Queue<String> q = new Queue<string>();
            q.Enqueue("red");
            q.Enqueue("blue");
            q.Enqueue("green");
            q.Enqueue("blue");
            q.Enqueue("white");
            q.Enqueue("silver");
            q.Enqueue("blue");

            
            Console.WriteLine(q.Peek());
            

            foreach(dynamic d in q)
            {
                Console.Write(d+" ");
            }
           
            
        }
    }
    //4.	WAP to add user defined objects of type Employee in a HashSet employee object.
    //Make sure if I create 2 different objects with same data the other one should not be added as hashset stores
    //unique objects.
    
    class HashSetExample
    {
        static void Main(string[] args)
        {
            HashSet<object> hs = new HashSet<object>();
           hs.Add(new Employee("suraj", "sr.developer", 25000));
            hs.Add(new Employee("amit", "project lead", 50000));
            hs.Add(new Employee("ritik", "QA", 20000));
            hs.Add(new Employee("suraj", "jr.developer", 15000));
            hs.Add(new Employee("suraj", "sr.developer", 25000));

            foreach (dynamic d in hs)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine();

            for(int i=0;i<hs.Count;i++)
            {
                Console.WriteLine( );
            }
        }
    }
    class SimpleArrayList
    {
       
        static void Main(string[] args)
        {
            var arrlist = new ArrayList();
            var al = new ArrayList()
            {
                1,"Suraj",true,1.4
            };
            var al2 = new ArrayList()
            {
                2,"rita","amrish"
            };

            var hs = new Hashtable();
            hs.Add("abc", 123);
            hs.Add(12, "abc");

            arrlist.AddRange(al);
            arrlist.AddRange(hs);
            dynamic s = arrlist[5].GetType();
            arrlist.InsertRange(5, al2);

            
            
            Console.WriteLine(arrlist.Count);
            
            foreach(dynamic de in arrlist)
            {
                dynamic dd = de.GetType();
                if(dd==s)
                {
                    Console.WriteLine("key: "+de.Key+" "+"Value: "+de.Value);
                }
                else
                {
                    Console.WriteLine(de);
                }
   
                
            }
            arrlist.Remove("rita");
            arrlist.RemoveAt(4);
            Console.WriteLine();
            arrlist.Reverse();
            Console.WriteLine("index of"+arrlist.IndexOf(2));
            foreach (dynamic de in arrlist)
            {
                dynamic dd = de.GetType();
                if (dd == s)
                {
                    Console.WriteLine("key: " + de.Key + " " + "Value: " + de.Value);
                }
                else
                {
                    Console.WriteLine(de);
                }


            }

        }
    }
    // merge two arrays and remove duplicate elements
    class MergArray
    {
        static void Main(string[] args)
        {
            int[] ss={ 51,3,17,9,14,12,8};
            
            Console.WriteLine(ss.Sum());
            Console.WriteLine( ss.Max());
            var al = new ArrayList() { 1, 2, 3, 4, 5 };
            var al2 = new ArrayList() { 4, 5, 6, 7, 8 };
            var al3 = new ArrayList();
            al3.AddRange(ss);
            al3.Sort();
            al3.Reverse();
            
            for(int i=0;i<al2.Count;i++)
            {
                if(al.Contains(al2[i])==false)
                {
                    al.Add(al2[i]);
                }
            }
            
          
            foreach(dynamic d in al)
            {
                Console.WriteLine(d);
            }
            
            
        }
    }
    //5.	WAP to create SortedList where key is of Integer type and value string and print all key-value pairs.
    class SortedListExample1
    {
        static void Main(string[] args)
        {
            SortedList<int,string> sl = new SortedList<int,string>();
            sl.Add(5, "suraj");
            sl.Add(2, "smita");
            sl.Add(6, "jeevan");
            sl.Add(4, "neha");
            foreach (var v in sl)
            {
                Console.WriteLine(v.Key+" "+v.Value);
            }
           

        }
    }
    //6.	WAP to create Dictionary where key is of string type and value of float type and print all key-value pairs.
    class DictionaryExample1
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(3, "Suraj3");
            d.Add(2, "Suraj2");
            d.Add(8, "Suraj8");
            d.Add(6, "Suraj6");
            d.Add(4, "Suraj4");
            d.Add(1, "Suraj1");
           

            foreach(KeyValuePair<int,string> de in d)
            {
                Console.WriteLine(de.Key+" "+de.Value);
            }
        }
    }
    //7.	Make use of such collection that stores moviename such that last entered movie is first
    //      deleted and accordingly previous one.
    class StackExample
    {
        static void Main(string[] args)
        {

            Stack<string> st = new Stack<string>();
            st.Push("zindagi na milegy dobara");
            st.Push("vivah");
            st.Push("hum aapke hain kon");
            st.Push("singham");
            st.Push("wanted");

            foreach(var v in st)
            {
                Console.WriteLine(v);
                
            }
            st.Pop();
            st.Pop();
            Console.WriteLine();
            Console.WriteLine("After Pop Operation:");
            foreach (var v in st)
            {
                Console.WriteLine(v);

            }
        }

    }
    //8.	WAP to create SortedList<Employee,string> where key is of Employee type
    //and value is departmentname(string) he works in. SortedList should maintain data in descending order 
    //of salary.

    class SortListEx
    {
        static void Main(string[] args)
        {
            SortedList<object, string> st = new SortedList<object, string>();
            st.Add(new Employee("suraj", "Manager", 50000), "Finance");
            st.Add(new Employee("amit", "supervisior", 12000), "production");
            st.Add(new Employee("raju", "Accountant", 35000), "Accounts");

            foreach(KeyValuePair<object,string> kv in st)
            {
                Console.WriteLine(kv.Key+" "+ kv.Value);
            }
        }
    }


}
