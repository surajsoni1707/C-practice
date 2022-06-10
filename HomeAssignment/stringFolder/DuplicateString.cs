using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.stringFolder
{
    //Write a  program to find the duplicate words and their number of occurrences in a string
    class DuplicateString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A String");
            String str = Console.ReadLine();
            string[] arr = str.Split(" ");
            int count = 0;
            int count1 = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                count1 = 0;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (arr[i] == arr[k])
                    {
                        count1++;
                        break;
                    }
                }
                if (count1 > 0)
                {
                    continue;
                }
                count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {

                        count++;
                    }



                }

                Console.WriteLine($"{arr[i]} occured {count} times:");
            }
        }
    }
    //Write a program to count the number of words in a string
    class NumberOfWords
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A String:");
            string str = Console.ReadLine();
            string[] arr = str.Split(" ");
            int num = arr.Length;
            Console.WriteLine("Given String Contains {0} words",num);
        }
    }
    //Create an array of 10 names sort in descending order
    class NamesInDesOrder
    {
        static void Main(string[] args)
        {
            string[] str = new string[10];

            Console.WriteLine($"Enter {str.Length} words");
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = Console.ReadLine();
            }
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i; j < str.Length; j++)
                {
                    string m = "";
                    if ((str[j].CompareTo(str[i]) == 1))
                    {
                        m = str[i];
                        str[i] = str[j];
                        str[j] = m;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }

        }
    }
    //Write a program to find total number of alphabets, digits or special character in a string.
    class Ads
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char[] arr = new char[str.Length];
            int num = 0, alpha =0, spclc = 0;
            for(int i=0;i<str.Length;i++)
            {
                arr[i] =Convert.ToChar( str[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i]>=47 && arr[i]<=58)
                {
                    num++;
                }
                else if((arr[i] >= 65 && arr[i] <= 90) || arr[i] >= 97 && arr[i] <= 122)
                {
                    alpha++;
                }
                else
                {
                    spclc++;
                }
            }
            Console.WriteLine($"String Contains {alpha} alphabets, {num} numbers and {spclc} special charachters.");

        }
    }
    //program to reverse an array
    class RevArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 7 array elements");
            int[] arr = new int[7];
            for(int i=0; i<arr.Length;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Reverse Array");
            int m = arr.Length-1;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[m - i]);
            }
        }
    }
    //WAP to merge 2 arrays to 3rd array. 3rd array should not have elements of same value
    class Merge2Arrays
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5];
            int[] arr2 = new int[5];
            int[] arr3 = new int[arr1.Length + arr2.Length];
            int count = 0,count1 = 0;
            Console.WriteLine("Enter Elements for First Array");
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter Elements for Second Array");
            for (int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0,m=0;i<arr3.Length;i++)
            {
                count = 0;
                for(int k=i-1;k>=0;k--)
                {
                    if((i<5 && arr3[k]==arr1[i]) ||(i>=5 && arr3[k]==arr2[i-5]))
                    {
                        count++;
                        break;
                    }
                }
                if(count>0)
                {
                    
                    continue;
                }
                if (count1 < arr1.Length)
                {
                    arr3[m] = arr1[i];
                    m++;
                    count1++;
                    
                }
                else
                {
                    arr3[m] = arr2[i - count1];
                    m++;
                    
                }
            }

            Console.WriteLine("3rd array");
            for (int i = 0; i < arr3.Length; i++)
            {
               if(arr3[i]>0)
                Console.WriteLine(arr3[i] + " "); 
            }

        }
    }
    class Abc
    {   
        public static int Freq(String str,char c1)
        {
            int c = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if(str[i]==c1)
                {
                    c++;
                }
            }
                return c;
        }
        static void Main(string[] args)
        {
            string str = "thinkquotient";
            Console.WriteLine("Enter A Word:");
            String str2 = Console.ReadLine();
            bool isFoud = true;
            
            foreach(char c in str2)
            {
               int c1= Abc.Freq(str2, c);
               int c2=Abc.Freq(str, c);
                if(c2<c1)
                {
                    isFoud = false;
                    break;
                }

            }
            if(isFoud==true)
            {
                Console.WriteLine("String Can Be Formed");
            }
            else
                Console.WriteLine("String Cannot be firmed");
            

        }
    }
}
