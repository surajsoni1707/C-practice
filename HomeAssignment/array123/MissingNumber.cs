using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.array123
{
    class MissingNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array Elements:");
            int[] arr1 = new int[8];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arr1);
            int diff = arr1[0] - arr1[1];
            Console.WriteLine(diff);
            for (int i = 0; i < arr1.Length - 1; i++)
            {
                if ((arr1[i] - arr1[i + 1]) != diff)
                {
                    Console.WriteLine($"{arr1[i] + (-1 * diff)} is Missing");
                    break;
                }
            }
            // Console.WriteLine($"{ab + diff} is Missing");


        }
    }
    class Fibbonacci
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, count = 2, n;
            Console.WriteLine("Enter the position:");
            n = Convert.ToInt32(Console.ReadLine());

            int n3 = 0;
            for (int i = 2; i <= 10; i++)
            {
                if (n == 0)
                {
                    Console.WriteLine(n1);
                    break;
                }
                else if (n == 1)
                {
                    Console.WriteLine(n2);
                    break;
                }
                n3 = n1 + n2;
                count++;
                if (count == n)
                {
                    Console.Write(" " + n3);
                }

                n1 = n2;
                n2 = n3;
            }
        }
    }
    class RefKey
    {
        int real, img;
        public RefKey(int a, int b)
        {
            real = a;
            img = b;
        }
        public static void AddValue(ref RefKey obj)
        {
            obj.real = obj.real + 5;
            obj.img = obj.img + 7;
        }
        static void Main(string[] args)
        {
            RefKey r = new RefKey(10, 20);
            AddValue(ref r);
            Console.WriteLine(r.real+","+r.img);
        }
    }
    class Anagram
    {
        public string IsAnagram(string input1,string input2)
        { string s = "";
            if (input1.Length == input2.Length)
            {
                char[] ch1 = input1.ToCharArray();
                char[] ch2 = input2.ToCharArray();
                int c1 = 0, c2 = 0, count = 0;
                for (int i = 0; i < input1.Length; i++)
                {

                    for (int j = 0; j < input1.Length; j++)
                    {
                        if (ch1[i] == ch1[j])
                        {
                            c1++;
                        }
                        if (ch1[i] == ch2[j])
                        {
                            c2++;
                        }
                    }
                    if (c1 != c2)
                    {
                        count++;
                        s = "no";
                        break;
                    }

                }
                if (count == 0)
                {
                    s = "yes";
                }
                else
                    s = "no";

            }
            else
                s = "no";
            return s;
        }
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            Anagram a = new Anagram();
            Console.WriteLine(a.IsAnagram(str1, str2));



        }
    }
    class Cuckoo
    {
        int coo(int s)
        {
            if (s == 1)
            {
                s = 0;
            }
            if (s == 2)
            {
                s = 1;
            }

            return s;
        }
        static void Main(string[] args)
        {


            Cuckoo ck = new Cuckoo();
            int n = Convert.ToInt32(Console.ReadLine());
            int c = 0;
            
            
            if(n==1)
            {
                Console.WriteLine("0");
            }
            else if(n==2)
            {
                Console.WriteLine("1");

            }
            else if(n>2)
            {
                c = 1 * ck.coo(n-1) + 2 *ck.coo( n - 2) + 3 * 1;

                Console.WriteLine(c);
            }
        }
    }
    class AP
    {
        static void Main(string[] args)
        {
            int a2 = Convert.ToInt32(Console.ReadLine());
            int a3= Convert.ToInt32(Console.ReadLine());
            int n= Convert.ToInt32(Console.ReadLine());
            int diff = a3 - a2;
            
            for(int i=3;i<n;i++)
            {
                a3 = a3 + diff;
            }
            Console.WriteLine(a3);
        }
    }
    class TimeS
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] time = str.Split(":");
            Console.WriteLine(time[0]+" "+time[1]);
            int hr1 = Convert.ToInt32(time[0].Substring(0, 2));
            int hr2 = Convert.ToInt32(time[1].Substring(0, 2));
            int min1= Convert.ToInt32(time[0].Substring(3, 2));
            int min2=Convert.ToInt32(time[1].Substring(3, 2));
           // Console.WriteLine(min1);
           // Console.WriteLine(min2);
            int totalmin1 = 0,totalmin2 = 0;
            if((time[0].EndsWith("pm") || time[0].EndsWith("PM")) && (hr1>1 &&hr1<12))
            {
                totalmin1= (12*60) + (60*hr1) + min1;
            }
            else if ((time[0].EndsWith("pm") || time[0].EndsWith("PM")) && hr1==12)
            {
                totalmin1 = (60 * hr1) + min1;
            }
            else if ((time[0].EndsWith("am") || time[0].EndsWith("AM")) && hr1 == 12)
            {
                totalmin1 =+ min1;
            }

            else if ((time[0].EndsWith("am") || time[0].EndsWith("AM")) && hr1!=12)
            {
                totalmin1 = (60*hr1) + min1;
            }

            if ((time[1].EndsWith("pm") || time[1].EndsWith("PM")) && (hr2 > 1 && hr2 < 12))
            {
                totalmin2 = (60*12)+(60*hr2) + min2;
            }
            else if ((time[1].EndsWith("pm") || time[1].EndsWith("PM")) && hr2 == 12)
            {
                totalmin2 = (60 * hr2) + min2;
            }
            else if ((time[1].EndsWith("am") || time[1].EndsWith("AM")) && hr2 == 12)
            {
                totalmin2 = +min2;
            }
            else  if ((time[1].EndsWith("am") || time[1].EndsWith("AM")) && hr2 != 12)
            {
                totalmin2 = (60*hr2) + min2;
            }
            Console.WriteLine(totalmin1);
            Console.WriteLine(totalmin2);
            int diff = totalmin1 - totalmin2;
            if(diff<0)
            {
                Console.WriteLine(-1*diff);
            }
            else
                Console.WriteLine(diff);
        }
    }
    interface IAb
    {
        public const int c = 10;
        public  void  M1()
        {
            Console.WriteLine("IAB-m1");
        }
    }
    public class A:IAb
    {
        public  void M12()
        {
            Console.WriteLine("A-M1");
            Console.WriteLine(IAb.c);
        }
        public int M1(int a)
        { return a; }
       
    }
    class B : A
    {
        public  void M12()
        {
            Console.WriteLine("B-m1");
            Console.WriteLine(IAb.c);
        }
        static void Main(string[] args)
        {
            B b = new B();
            A bc=new A();
            
           
            
        }
    }
    class Frog
    {
        static void Main(string[] args)
        {
            
            int count = 0;
            for(int i=3;i<50;i=i+3)
            {
                count++;
                Console.Write($"day={count}, distance climb{i}");
                if (i>=49)
                {
                    
                    break;
                }
                i = i - 2;
                Console.Write($" Distance sleep down {i}");
                Console.WriteLine();

            }
        }
    }
    //Write a program in C# Sharp to separate the individual characters from a string.

    class SeprateChar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A String");
            String str = Console.ReadLine();
            char[] ch = new char[str.Length];
            int count = 0;
            for(int i=0;i<ch.Length;i++)
            {
               if(str[i]!=32)
                {
                    ch[count] = str[i];
                    count++;
                }
            }
            for(int i=0;i<ch.Length;i++)
            {
                Console.Write(ch[i]+" ");
            }
        }
    }
    //Write a program in C# Sharp to print individual characters of the string in reverse order.
    class RevChar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A String");
            String str = Console.ReadLine();
            string[] arr = str.Split(" ");
            for(int i=0;i<arr.Length;i++)
            {
                string pq = arr[i];
                for(int j=pq.Length-1;j>=0;j--)
                {
                    Console.Write(pq[j]);
                }
                Console.Write(" ");
            }
        }
    }
    class TwoDArray
    {//2 dimensional jagged Array
        static void Main(string[] args)
        {
            int[][] a = new int[3][];
            a[0] = new int[5];
            a[1] = new int[2];
            a[2] = new int[4];
            //Console.WriteLine(a.Length);
           // Console.WriteLine(a[0].GetLength(0)); 
            for(int i=0;i<a.Length;i++)
            {
                for(int j = 0; j <a[i].GetLength(0);j++)
                {
                    a[i][j]= Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].GetLength(0); j++)
                {
                    Console.Write(a[i][j]+" ");
                }
                Console.WriteLine();
            }

        }
    }
}

