using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.arrList
{
    class ArrL1
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList() { 1, 5, "Suraj", "Amit", true };
            Console.WriteLine(a.Count);
            a.Add(Console.ReadLine());
            a.Insert(3, "abcd");
            for (int i=0;i<a.Count;i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Reverse List");
            a.Reverse();
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine();
            Hashtable ht = new Hashtable();
            ht.Add(1, "suraj");
            ht.Add(2, "amit");
            ht.Add(3, "sumit");
            ht.Add(4, "shubham");
            Console.WriteLine(ht.Count);
            Console.WriteLine();
            Console.WriteLine(ht.ContainsKey(4));
            Console.WriteLine(ht.ContainsValue("sumit seth"));
            foreach(dynamic d in ht.Keys)
            {
                Console.WriteLine(d+":"+ht[d]);
            }
            
        }
    }
    class ArrExmple
    {
        static void Main(string[] args)
        {
            int[] n = new int[5];
            Array.Resize(ref n, 10);
            Console.WriteLine(n.Length);
        }
    }
    class Strex
    {
        public static void sort1(char c)
        {
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A String");
            String sd1 = Console.ReadLine();
            for (int i = 0; i < sd1.Length; i++)
            {
                if(i==0)
                {
                    if (sd1[i] >= 97 && sd1[i] <= 122)
                    {
                        Console.Write((char)(sd1[i]-32));
                    }
                    else if(sd1[i] >= 65 && sd1[i] <= 90)
                {
                        Console.Write(sd1[i]);
                    }
                }

                else if((sd1[i]>=65 && sd1[i]<=90) &&((sd1[i-1]<65 && sd1[i]>90)|| sd1[i - 1] >122 ))
                {
                    Console.Write(sd1[i]);
                }
                else if (sd1[i] >= 65 && sd1[i] <= 90)
                {
                    Console.Write((char)(sd1[i] + 32));
                }
                else if ((sd1[i] >= 97 && sd1[i] <= 122) && ((sd1[i - 1] < 65 && sd1[i] > 90) || sd1[i - 1] > 122))
                {
                    Console.Write((char)(sd1[i]-32));
                }
                else if (sd1[i] >= 97 && sd1[i] <= 122)
                {
                    Console.Write(sd1[i]);
                }


            }
        }
    }
    class HashTableExample
    {
       

       
        static void Main(string[] args)
        {
            HashTableExample he = new HashTableExample();
            ArrayList al = new ArrayList();
            al.Add(100);
            al.Add(200);
            al.Add("Suraj");
            al.Add("Amit");

           
            ArrayList al2 = new ArrayList();
            al2.Add(1000);
            al2.Add(2000);
            al2.Add("Suraj1111");
            al2.Add("Amit1111");
            Console.WriteLine();

            Hashtable ht = new Hashtable();
            ht.Add(1, al);
            ht.Add(2, al2);
            Console.WriteLine(ht.Count);
            foreach (var d in ht.Keys)
            {
                ArrayList l = (ArrayList)ht[d];
                Console.WriteLine(ht.ContainsValue("Suraj"));
                foreach(var v in l)

                {
                    Console.Write(v+" ");
                }
                Console.WriteLine();
                
               
            }

        }
    }
    class Test
    {
        public static int Sum(int[] arr1)
        {
            int tot = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                tot = tot + arr1[i];
            }
            return tot;

        }
        static void Main(string[] args)
        {
            int sizeofArray = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[sizeofArray];
            for(int j=0;j<arr1.Length;j++)
            {
                arr1[j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine( Sum(arr1));
        }
    }
    class ArrList
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Sun");
            al.Add("Mon");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Mon");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Mon");
            
            for(int i=0;i<al.Count;i++)
            {
             
                for(int j=i+1;j<al.Count;j++)
                {
                    
                    if(al[i]==al[j])
                    {
                        al.RemoveAt(j);
                        j--;
                    }
                }
                


                
            }
            foreach (var v in al)
            {
                Console.WriteLine(v);
            }

        }
    }
    class StringReverse
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList(8);
            Console.WriteLine("Enter words");
            for(int i=0;i<al.Capacity;i++)
            {
                al.Add(Console.ReadLine());
            }
            Console.WriteLine("***********************");

            al.Sort();
            al.Reverse();
            foreach(var v in al)
            {
                Console.Write(v+" ");
            }

        }
    }
    class Encryption
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A String:");
            String s = Console.ReadLine();
            string[] str = s.Split();
            int[] arr = new int[str.Length];
            
            for(int i=0;i<str.Length;i++)
            {
                int total = 0;
                
                char[] ch = str[i].ToCharArray();
                for (int j=0;j<str[i].Length;j++)
                {
                    if(ch[j]>=65 && ch[j]<=90)
                    {
                        total = total + (ch[j] - 64);
                    }

                }
                Console.WriteLine(total);

                arr[i] = total;
            }


            for (int i = 0; i < arr.Length; i++)
            {


                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        string temp = str[i];
                        str[i] = str[j];
                        str[j] = temp;

                        int temp1 = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp1;

                    }
                }
                Console.Write(str[i]+" ");
                                //Console.Write(str[i] + " ");
            }


               
        }
    }
    class Player
    {
        int pid;
        string pname;
        string country;
        string team;

        public Player(int pid, string pname, string country, string team)
        {
            this.Pid = pid;
            this.Pname = pname;
            this.Country = country;
            this.Team = team;
        }

        public int Pid { get => pid; set => pid = value; }
        public string Pname { get => pname; set => pname = value; }
        public string Country { get => country; set => country = value; }
        public string Team { get => team; set => team = value; }

        public override string ToString()
        {
            return "pid:" + Pid+" " + "player name:" + Pname+" " + "country:" + Country+" " + "Team:" + Team;
        }



    }
    class Player1
    {
        
        static void Main(string[] args)
        {
            
            ArrayList al = new ArrayList();

            al.Add(new Player(1, "sachin", "India", "mumbai indians"));
            al.Add(new Player(2, "Ricky ponting", "australia", "rajasthan royals"));
            al.Add(new Player(3, "gill christ", "australia", "rajasthan royals"));
            al.Add(new Player(4, "Mahendra sing dhoni", "India", "chennai super kings"));
            al.Add(new Player(5, "suresh raina", "India", "chennai super kings"));
            al.Add(new Player(6, "sanju samson", "India", "mumbai indians"));

            string max_teamName="";
            int max_count=0;
            foreach(Player p in al)
            {
                string t = p.Team;
                int c = 0;
                foreach (Player p2 in al)
                {
                    if (p2.Team == t && p2.Country == "australia")
                    {
                        c++;
                    }
                }
                    if(max_count<c)
                    {
                        max_teamName = p.Team;
                        max_count = c;
                    }
                
            }
            Console.WriteLine($"Maximum Austrelian player are there in {max_teamName} : {max_count}");
        }
    }
    /*5.	Write a program to get the value of a specified key in a HashTable
    and also update the value for given key.*/

    class SpecifiedKey
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "Suraj");
            ht.Add(2, "Sumit");
            ht.Add(3, "amit");
            ht.Add(4, "Shubh");
            ht.Add(5, "Sagar");
            
            
            foreach(DictionaryEntry v in ht)
            {
                Console.WriteLine(v.Key+" "+v.Value);

            }
            Console.WriteLine("Enter a Key:");
            int key1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"value of key {key1}is {ht[key1]}");
            Console.WriteLine("Enter A Value to update:");
            dynamic d1 = Console.ReadLine();
            ht[key1] = d1;

            foreach (DictionaryEntry v in ht)
            {
                Console.WriteLine(v.Key + " " + v.Value);

            }

        }
    }
   // 6.	Write a program to get a set of keys contained in HashTable and print whole HashTable using for each loop.
   class SetOFKeys
    {
         public dynamic d()
        {
            return Console.ReadLine();
        }
        static void Main(string[] args)
        {
            SetOFKeys ss = new SetOFKeys();
            Hashtable ht = new Hashtable();
            for (int i = 0; i < 5; i++)
            {
                ht.Add(ss.d(), ss.d());
            }

            
            Console.WriteLine("Key set is:");
            foreach(DictionaryEntry de in ht)
            {
                Console.Write(de.Key+" ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Whole Hash Table:");

            foreach (DictionaryEntry de in ht)
            {
                Console.WriteLine(de.Key + " "+de.Value);
            }
        }
    }
   // 7.	Create a HashTable where key is integers 1 to 10 and string is number in Words.
   // Remove entry for which number is divisible by 3.
   class HashTableKey1to10
    {

        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            Hashtable ht = new Hashtable();
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("enter {0} in words",i);
                ht.Add(i, Console.ReadLine());
            }
            Console.WriteLine("*****************************************");
            Console.WriteLine("HashTAble:");
            foreach (DictionaryEntry de in ht)
            {
                Console.WriteLine(de.Key+ " "+de.Value);
            }
            
           foreach(dynamic de in ht)
            {
                if((int)de.Key%3==0)
                {
                    al.Add(de.Key);
                }
            }
           for(int i=0;i<al.Count;i++)
            {
                ht.Remove(al[i]);
            }
            Console.WriteLine("********************************************");
            foreach (DictionaryEntry de in ht)
            {
                Console.WriteLine(de.Key + " " + de.Value);
            }

        }

    }
    /*8.	ArrayList Contains 
                        al.Add("pune");
                        al.Add("Mumbai");
                        al.Add("pune");
                        al.Add("Mumbai");
                        al.Add("Nasik");
                        al.Add("pune");
    Create a HashTable which contain String as key and Integer as value key is name of city and
    value is frequency of that city.
        ("pune",3);
        ("Mumbai",2);
        Print hashtable using Foreach loop.*/
    class ArrayListCity
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            Hashtable ht = new Hashtable();
            al.Add("pune");
            al.Add("Mumbai");
            al.Add("pune");
            al.Add("Mumbai");
            al.Add("Nasik");
            al.Add("pune");
            foreach(dynamic d in al)
            {
                if (ht.ContainsKey(d))
                {
                    int oldValue = ht[d];
                    ht[d] = oldValue + 1;
                }
                else
                    ht.Add(d, 1);
            }
            foreach(DictionaryEntry de in ht)
            {
                Console.WriteLine(de.Key+" "+de.Value);
              
            }
        }
    }
    class Abc
    {
        public static void Cal(int K,int N,int[] A)
        {
            int result1 = 0, result2 = 0;
            for(int i=0;i<N;i++)
            {
                for(int j=i;j<N;j++)
                {
                    if(A[i]<A[j])
                    {
                        int temp = A[i];
                        A[i] = A[j];
                        A[j] = temp;
                    }
                }
            }
            for (int i = 0; i < N; i++)
            {
                if(K>result2)
                {
                    if((result2+A[i])<=K)
                    {
                        result2 = result2 + A[i];
                        result1++;
                    }
                }
            }
            Console.WriteLine(result1+ " "+result2 );

        }
        static void Main(string[] args)
        {
            int N = 0, K = 0;
            
            Console.WriteLine("Enter Array length:");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Money");
            K= Convert.ToInt32(Console.ReadLine());
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i]= Convert.ToInt32(Console.ReadLine());
            }

            Cal(K, N, A);

        }
    }
    class classA
    {
        public static int cal1(int N,int[] A)
        {
            int result = 0;


            ArrayList al = new ArrayList();
            for (int i = 0; i < N; i++)
            {
                al.Add(A[i]);
            }
            al.Sort();


            Console.WriteLine("********************************");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(A[i]+" "+al[i]);
            }
                for (int i=0;i<N;i++)
            {
                if(A[i]==(int)al[i])
                {
                    
                    result++;
                }
            }

            return result;
        }
        static void Main(string[] args)
        {
            int N = 0;

            Console.WriteLine("Enter Array length:");
            N = Convert.ToInt32(Console.ReadLine());
            
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(cal1(N,A));
        }
    }
    class StringSplit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A string");
            String str = Console.ReadLine();
            string[] al;
           al = str.Split();
            for(int i=0;i<al.Length;i++)
            {
                String first = al[i].Substring(0, 1);
                string rem = al[i].Substring(1);
                Console.Write(first.ToUpper()+rem+" ");
            }
        }
    }
    class CountVoelsYZ
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A string");
            String str = Console.ReadLine();
                      
                char[] ch = str.ToCharArray();
            int count = 0;
            for(int i=0;i<ch.Length;i++)
            {
                if (ch[i] =='a' || ch[i] == 'A'|| ch[i] == 'E'|| ch[i] == 'e'|| ch[i] == 'i'|| 
                    ch[i] == 'I'|| ch[i] == 'o'|| ch[i] == 'O'|| ch[i] =='u'|| ch[i] == 'U'||
                    ch[i] == 'y'|| ch[i] == 'Y'|| ch[i] == 'Z'|| ch[i] == 'z')
                    
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
    class Practice
    {
        
        static void Main(string[] args)
        {
            /*string str = Console.ReadLine();
            string[] ss = str.Split();
            for (int i = 0; i < ss.Length; i++)
            {
                char[] ch = ss[i].ToCharArray();
                Array.Reverse(ch);
                Console.Write(ch);
                Console.Write(" ");
            }*/
            ArrayList al = new ArrayList();
            ArrayList al2 = new ArrayList();
            Hashtable ht = new Hashtable();
            ht.Add(null, 1);
            al.Add(0);
            al2.Add(0);
            Console.WriteLine(al[0].Equals(al2[0]));
        }
    }
    class Employee:IComparable
    {
        int eid;
        String name;
        string dept;

        public Employee(int eid, string name, string dept)
        {
            this.eid = eid;
            this.name = name;
            this.dept = dept;
        }

        public int Eid { get => eid; set => eid = value; }
        public string Name { get => name; set => name = value; }
        public string Dept { get => dept; set => dept = value; }

       

        public int CompareTo(object obj)
        {
            Employee e = (Employee)obj;
            return this.eid.CompareTo(e.eid);
        }
        public override string ToString()
        {
            return $"{eid} {name} {dept} ";
        }
    }
    class Details
    {
        static void Main(string[] args)
        {
            SortedList s = new SortedList();
            s.Add(new Employee(1, "Suraj", "HR"),45000);
            s.Add(new Employee(2, "Aman", "Dev"), 60000);
            s.Add(new Employee(3, "Rajesh", "Fin"), 55000);
            s.Add(new Employee(4, "Shubham", "HR"), 65000);
            s.Add(new Employee(5, "Kartik", "Fin"), 56000);
            s.Add(new Employee(6, "Prasad", "Dev"), 35000);

            foreach(DictionaryEntry de in s)
            {
                Console.WriteLine(de.Key+" "+de.Value);
            }

        }
    }
    class ListExample
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            a.Add(1);
            a.Add(2);
            a.Add(3);
            foreach (dynamic d in a)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine(a[2]);
        }
    }
    class Student:IComparable
    {
        int id;
        string name;
        string city;

        public Student(int id, string name, string city)
        {
            this.Id = id;
            this.Name = name;
            this.City = city;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string City { get => city; set => city = value; }

        
        public int CompareTo(object obj)
        {
            Student ss = (Student)obj;
            if (this.city.Equals(ss.city))
            { return this.name.CompareTo(ss.name); }
            else
                return this.city.CompareTo(ss.city);
        }
        public override string ToString()
        {
            return $"{id} {name} {city} ";
        }
    }
    class A1
    {
        static void Main(string[] args)
        {
            SortedList<object, int> sl = new SortedList<object, int>();
            sl.Add(new Student(1, "Suraj", "Aurangabd"), 20000);
            sl.Add(new Student(2, "Shubh", "pune"), 30000);
            sl.Add(new Student(3, "rohit", "mumbai"), 10000);
            sl.Add(new Student(4, "aman", "pune"), 10000);
            sl.Add(new Student(5, "rajesh", "mumbai"), 10000);
            sl.Add(new Student(6, "shreya", "mumbai"), 10000);
            
            foreach(dynamic d in sl)
            {
                Console.WriteLine(d);
            }
        }
    }
   
}


