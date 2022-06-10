using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.Collectionnn
{
    class MyPractice
    {
        static void Main(string[] args)
        {
            Hashtable hs = new Hashtable();
            hs.Add(1, "abc,efg");
            hs.Add(2, "pqr");
            hs.Add("xyz", 4);
            

            string b = (string)hs[1];
            Console.WriteLine(b);
            foreach (DictionaryEntry de in hs)
            {
                Console.WriteLine(de.Key + " " + de.Value);
            }

            hs[2] = "suraj soni";
            hs[1] = "aman agarwal";
            hs["xyz"] = "abcd";

            Console.WriteLine("After updation:");
            foreach (DictionaryEntry de in hs)
            {
                Console.WriteLine(de.Key + " " + de.Value);
            }
            Console.WriteLine();
            hs.Remove(1);
            Console.WriteLine("After Removing:");
            foreach (DictionaryEntry de in hs)
            {
                Console.WriteLine(de.Key + " " + de.Value);
            }
        }
    }
    //Sorted List

    class SortedListExample
    {
        static void Main(string[] args)
        {
            SortedList  sl = new SortedList();
            sl.Add(5, "suraj");
            sl.Add(2, "smita");
            sl.Add(6, "jeevan");
            sl.Add(4, "neha");
            foreach(var v in sl)
            {
                Console.WriteLine(v);
            }
            List<int> al = new List<int>();
            al.Add(8);
            al.Add(7);
            

        }
    }
    class swapMinMax
    {
        static void Main(string[] args)
        {
            int[] a = { 58, 45, 12, 35, 86 };
           int mx= a.Max();
            int mn = a.Min();
            int mxcount = 0;
            int mncount = 0;
            
            Console.WriteLine("max= {0} and min= {1}",mx,mn);

            for(int i=0;i<a.Length;i++)
            {
                if (a[i] == mx)
                    mxcount = i;
                    
                
                if(a[i]==mn)
                {
                    mncount=i;
                }

            }
            a[mxcount] = mn;
            a[mncount] = mx;
            foreach(int i in a)
            {
                Console.Write(i+" ");
            }
        }
    }
    class DictionaryExample
    {
        static void Main(string[] args)
        {

        }
    }
    class ArrayExample1
    {
        static void Main(string[] args)
        {
            int[] a = { 15, 20, 84, 75, 13, 56 };
            int max=a.Max();
            int[] b = new int[a.Length];
            Console.WriteLine(max);
            int min = a.Min();
            Console.WriteLine(min);
            Console.WriteLine(a.First());
            Console.WriteLine(  a.Contains(20));
            Console.WriteLine( a.Count());
            Console.WriteLine(a.Length);
            ArrayList al = new ArrayList();
            al.AddRange(a);
            al.Reverse();
           
            foreach(int i in b)
            {
                Console.WriteLine(i);
            }
        }
    }
    class DelPRact
    {
        static float sum(float a,float b)
        {
            return (a + b);
        }
        static void Main(string[] args)
        {
            Func<float, float, float> add = sum;
            Console.WriteLine( add(20, 30));
        }
    }
    class A1
    {
        public void m1(ref int a)
        {
            Console.WriteLine("a in m1"+a);
            a = 100;
        }
        public void M2(out int n)
        {
           // Console.WriteLine("n in m1" + n);

            n = 1000;
        }
        static void Main(string[] args)
        {
            int m = 10;
            A1 aa = new A1();
            aa.m1(ref m);
            Console.WriteLine("m in main"+m);
            int n1 = 10;
            aa.M2(out n1);
            Console.WriteLine("n1 in main"+n1);
        }
    }
    //sum of prime numbers
    class SumOfPrime
    {
      
       
        static void Main(string[] args)
        {

            int sum = 0;
            int[] n = new int[5];
            for(int i=0;i<n.Length;i++)
            {
                n[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n.Length; i++)
            {
                int count=0;
              for(int j=2;j<=n[i]/2;j++)
                {
                    if(n[i]%j==0)
                    {
                        count++;
                    }
                    
                }
              if(count==0)
                {
                    
                    sum = sum + n[i];
                }
            }
            
            Console.WriteLine(sum);
        }
    }
    class CountDuplicateWords
    {
        static void Main(string[] args)
        {
            String str = Console.ReadLine();
            String[] s = str.Split();
            Hashtable ht = new Hashtable();
            for(int i=0;i<s.Length;i++)
            {
                if (ht.ContainsKey(s[i])==true)
                {
                 int oldValue=(int)ht[s[i]]+1;
                    ht[s[i]] = oldValue;
                }
                else
                    ht.Add(s[i], 1);
            }
            foreach(dynamic d in ht )
            {
                if(d.Value>1)
                Console.WriteLine(d.Key);
            }
        }
    }
    class Aaaa
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50, 60 };
            int sum = 0;
            for(int i=0;i<arr.Length-1;i=i+2)
            {
                sum = arr[i] + arr[i + 1];
                Console.WriteLine(sum);
            }
        }
    }
    class CollectionPract
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>() { 10,20,20,30,30,40,50 };
            List<int> al = new List<int>() {40,50, 60,70,80,90,100 };
            List<int> al1 = new List<int>();
          for (int i=0;i<l.Count;i++)
            {
                if(al1.Contains(l[i])==false)
                {
                    al1.Add(l[i]);
                }
              

            }
            for (int i = 0; i < al.Count; i++)
            {
                if (al1.Contains(al[i])==false)
                {
                    al1.Add(al[i]);
                }
                
            }
            foreach(dynamic d in al1)
            {
                Console.WriteLine(d);
            }


        }
    }

}
