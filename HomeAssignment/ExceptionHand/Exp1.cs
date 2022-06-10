using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.ExceptionHand
{
    class Exp1
    {
        static string s=null;
        static void Main(string[] args)
        {
            

           
            
            try
            { 
                Console.WriteLine(Exp1.s.Substring(0,2));
                                  
            }
            catch(ArithmeticException e)
            {
                Console.WriteLine(e.Message) ;
            }
            catch( NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Hello");
        }
    }
    class InvalidMobException : ApplicationException
    {
        public InvalidMobException(string m):base(m)
        { }

    }
    class MobExcep
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Mobile Name:");
            long mob = Convert.ToInt64(Console.ReadLine());
            if(mob==8149881587)
            {
                Console.WriteLine("Valid Mobile Number");
            }
            else
            {
                try
                {
                    throw new InvalidMobException("Enter Valid Mobile Number");
                }
                catch(InvalidMobException e)
                {
                    Console.WriteLine(e.Message);
                }

            }
            Console.WriteLine("Hello");

        }
    }
    //WAP to use catch / handle NullReferenceRange exception. 
    class NullRefRange
    {
        static void Main(string[] args)
        {
            string s = null;
            try
            {
                string s1 = s.Substring(5, 4);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Hello");
        }
    }
    //WAP to catch multiple exceptions. i. IndexOutOfRangeException and DivideByZeroException
    class mulExcep
    {
        
        public static int Divide()
        {
            Console.WriteLine("Enter Two Values");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            return a / b;
        }
        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine(Divide());
            }
            catch(ArithmeticException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(Divide());
            }

            int[] a = new int[5];
            Console.WriteLine($"Enter {a.Length} Elements");
            try
            {
                for (int i = 0; i <= 5; i++)
                {
                    a[i] = Convert.ToInt32(Console.ReadLine());

                }
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                for(int i=0;i<a.Length;i++)
                {
                    Console.Write(a[i]+" ");
                }
            }

        }
    }
    // WAP to show use of multiple catch block with universal Exception handler.
    class UniExceptionHandler
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Two Values:");
            try
            {
                sbyte a = Convert.ToSByte(Console.ReadLine());
                sbyte b = Convert.ToSByte(Console.ReadLine());
                Console.WriteLine(a / b);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Enter Integer Value:");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

        //WAP to create user defined Exception  and raise and catch the exception.
      class UnderAgeException : ApplicationException
        {
            public UnderAgeException(String m) : base(m)
            { }
        }
    class OverAgeException:ApplicationException
    {
        public OverAgeException(string m):base(m)
        { }

    }
    class Matrimony
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Age");
            int age = int.Parse(Console.ReadLine());
            if(age<18)
            {
                try
                {
                    throw new UnderAgeException("Yu Are Under Age To Get Married.");
                }
                catch(UnderAgeException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else if(age>60)
            {
                try
                {
                   
                        throw new OverAgeException("You Are over age To Get Married.");
                }
                catch(OverAgeException e)
                {
                    Console.WriteLine(e.Message);
                }

            }
            else
            {
                Console.WriteLine("You Will Get Matched Profiles Soon.");
            }
        }
    }
    class Exp
    {
        static void Main(string[] args)
        {
            string s = "ALL MEN ARE CREATED EQUAL";
            string str = s.Substring(12, 3);
            Console.WriteLine(str);
        }
    }
}
