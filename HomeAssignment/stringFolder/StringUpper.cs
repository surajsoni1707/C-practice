using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.stringFolder
{
    class StringUpper
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A String");
            String s1 = Console.ReadLine();
            s1 = s1.ToUpper();
            for(int i=0;i<s1.Length;i++)
            {
                Console.WriteLine(s1[i]);
            }
            Console.WriteLine();
            for (int i = s1.Length-1; i >=0; i--)
            {
                Console.WriteLine(s1[i]);
            }
        }
    }
    class stringPal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A String");
            String s1 = Console.ReadLine();
            bool b=true;
            
            
            
            for (int i = 0,j=s1.Length-1; i <= s1.Length/2; i++,j--)
            {
                if(s1[i]==s1[j])
                {
                    b = true;
                }
                else
                {
                    b = false;
                    break;
                }
            }
            if(b==true)
            {
                Console.WriteLine("String is Palindrome");
            }
            else
                Console.WriteLine("String is not Palindrome");
        }
    }
    class MyExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A string:");
            String s1 = Console.ReadLine();
            string[] s2 = s1.Split(" ");
            string sm = "";
            foreach(string wrd in s2 )
            {
                string fwrd = wrd.Substring(0, 1);
                string rem = wrd.Substring(1);
                Console.Write(fwrd.ToUpper()+rem+" ");
            }
            Console.WriteLine();
            foreach (string wrd in s2)
            {
                for(int i=wrd.Length-1;i>=0;i--)
                {
                    Console.Write(wrd[i]);
                }
                Console.Write(" ");
            }


        }
    }
    class String11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A Values");
            int[] str = new int[8];
            int[] arr = new int[str.Length];
            
           
           
           
            
            for (int i=0;i<str.Length;i++)
            {
                str[i] = Convert.ToInt32(Console.ReadLine());
            }

            int c = 0;
            for(int i=0;i<str.Length;i++)
            {
               for(int j=i;j<str.Length;j++)
                {
                    if(str[j]>str[i])
                    {
                        c = str[i];
                        str[i] = str[j];
                        str[j] = c;

                    }
                }
            }

            Console.WriteLine("Sorted Array:");
            for(int i=0;i<str.Length;i++)
            {
                Console.Write(str[i]+" ");
            }
            

            
        }
    }
    class Strbuilder
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("Enter A String");
            sb.Append(Console.ReadLine());
            Console.WriteLine(sb);
            sb.Remove(2, 5);
            Console.WriteLine(sb);
            sb.Replace('o', 'm');
            Console.WriteLine(sb);
            Console.WriteLine("Enter A Position:");
            int n = int.Parse(Console.ReadLine());
            sb.Insert(n, Console.ReadLine());
            Console.WriteLine(sb);
            
        }
    }
    class MinArray
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6];
            Console.WriteLine("Enter Elements in Array:");
            
            

            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int min = arr[0];
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]<min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Min="+min);

        }
    }
    class OddArray
    {
        static void Main(string[] args)
        {

            int[] arr = new int[6];
            int count = 0;

            Console.WriteLine("Enter Elements in Array:");



            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                if(arr[i]%2!=0)
                {
                    count++;
                }
            }
            Console.WriteLine("No.Of Odd elements in An Array:"+count);
        }
    }
    class GE
    {
        static void Main(string[] args)
        {
            char[] c = new char[10];
            int count = 0;
            Console.WriteLine("Enter Charachters:");
            for (int i = 0; i < c.Length; i++)
            {
                c[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("Enetr A character to search in a array:");
            char c1 = Convert.ToChar(Console.Read());
            for (int i = 0; i < c.Length; i++)
            {
                if (c1 == c[i])
                {
                    count++;
                }
            }
            if (count > 0)
            {
                Console.WriteLine("{0} is prent in the Array", c1);

            }
            else
                Console.WriteLine("{0} is not present in Array", c1);
        }

    }    
    class LongWordInString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A string of Words:");
            string str = Console.ReadLine();
            string[] arr = str.Split(" ");
            string word = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length > word.Length)
                {
                    word = arr[i];
                }
            }

            Console.WriteLine("Longest word is:" + word);
        }

    }
    class AvgOfDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A number");
            String str = Console.ReadLine();
            int length = str.Length;
            int number1 = Convert.ToInt32(str);
            int sum = 0;
            while(number1>0)
            {
                int rem = number1 % 10;
                sum = sum + rem;
                number1 = number1 / 10;
            }
            float avg = (float)sum / length;
            Console.WriteLine("Avg Of Digits= "+avg);
        }
    }
    class Occur
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            String str = Console.ReadLine();
            int count = 0;
            int count1 = 0;
            for( int i=0;i<str.Length;i++)
            {
                count1 = 0;
                for(int k=i-1;k>=0;k--)
                {
                    if(str[i]==str[k])
                    {
                        count1++;
                        break;
                    }
                }
                if(count1>0)
                {
                    continue;
                }
                count = 0;
                for(int j=0;j<str.Length;j++)
                {
                    if (str[i] == str[j] )
                    {

                        count++;
                    }
                   
                    
                        
                }

                Console.WriteLine($"{str[i]} occured {count} times:");
            }
        }
    }
    class StringOrder
    {
        static void Main(string[] args)
        {
            string[] str = new string[10];
            
            Console.WriteLine($"Enter {str.Length} words");
            for(int i=0;i<str.Length;i++)
            {
                str[i] = Console.ReadLine();
            }
            for(int i=0;i<str.Length;i++)
            {
                for(int j=i;j<str.Length;j++)
                {
                    string m = "";
                    if((str[j].CompareTo(str[i])==-1))
                    {
                        m = str[i];
                        str[i] = str[j];
                        str[j] = m;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            for(int i=0;i<str.Length;i++)
            {
                Console.WriteLine(str[i]);
            }

        }
    }
        
}
