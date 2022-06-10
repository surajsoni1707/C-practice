using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.pattern
{
    class Pattern3
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=9; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    
                    
                        Console.Write(j);
                    j++;
                }
                i++;
                Console.WriteLine("");
            }
        }
    }

    class Pattern4
    {/*
      * 1
      * 22
      * 333
      * 4444
      * 55555
      */
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
    class Pattern5
    {
        /* A
         * AB
         * ABC
         * ABCD
         * ABCDE
         * */
        static void Main(string[] args)
        {
            for (char i = 'A'; i <= 'E'; i++)
            {
                for (char j = 'A'; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

        }
    }
    class Pattern6
    {
        /* A
         * BB
         * CCC
         * DDDD
         * EEEEE
         */
        static void Main(string[] args)
        {
            for (char i = 'A'; i <= 'E'; i++)
            {
                for (char j = 'A'; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
    class Pattern7
    {
        /*
         *     *
         *    **
         *   ***
         *  ****
         * *****
         */
        static void Main(string[] args)
        {
            for (int i = 5; i>=1 ; i--)
            {
                for (int j =1; j<=5; j++)
                {
                    if(j>=i)
                    Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
    class Pattern8
    {
        /*    1
         *   1  2
         *  1  2  3
         * 1  2  3  4
         *1  2  3  4  5  */

        static void Main(string[] args)
        {
            
            for (int i = 1; i <= 5; i++)
            {
                
                for (int j = (5-i); j>=1; j--)
                {
                    Console.Write(" ");
                }
                for(int j=1;j<=i;j++)
                {
                    Console.Write(j);
                    Console.Write(" ");

                }
                Console.WriteLine();
            }
        }
    }
    class Pattern9
    {
        /*         5
         *        4 5
         *       3 4 5
         *      2 3 4 5
         *     1 2 3 4 5
         *     
         */
        static void Main(string[] args)
        {

            for (int i = 5; i >= 1; i--)
            {

                for (int j = i; j >= 1; j--)
                {
                    Console.Write(" ");
                }
                for (int j = i; j <= 5; j++)
                {
                    Console.Write(j);
                    Console.Write(" ");

                }
                Console.WriteLine();
            }

        }
    }
    class Pattern10
    {/*
      *        A
      *       A B
      *      A B C
      *     A B C D
      *    A B C D E 
      */ 
        static void Main(string[] args)
        {
           
            for (char i = 'A'; i <= 'E'; i++)
            {

                for (char j =(char)('E' -i); j >= 1; j--)
                {
                    Console.Write(" ");
                }
                for (char j = 'A'; j <= i; j++)
                {
                    Console.Write(j);
                    Console.Write(" ");

                }
                Console.WriteLine();
            }
        }
    }
    class Pattern11
    {
        /*
         *          E
         *         D E
         *        C D E
         *       B C D E
         *      A B C D E
         */
        static void Main(string[] args)
        {

            for (char i = 'E'; i >= 'A'; i--)
            {

                for (char j = i; j >= 1; j--)
                {
                    Console.Write(" ");
                }
                for (char j = i; j <='E' ; j++)
                {
                    Console.Write(j);
                    Console.Write(" ");

                }
                Console.WriteLine();
            }
        }
    }
    class Pattern12
    {
        /*            *
         *           ***
         *          *****
         *         *******
         *        *********
         */
        static void Main(string[] args)
        {

            for (int i = 9; i >=1 ;i= i-2)
            {

                for (int j = i; j >= 1; j--)
                {
                    Console.Write(" ");
                }
                for (int j = i; j <= 9;j++)
                {
                    Console.Write("*");
                    Console.Write(" ");

                }
                Console.WriteLine();
            }
        }
    }

    class Pattern13
    {
        /*       1
         *      2 2
         *     3 3 3
         *    4 4 4 4 
         *   5 5 5 5 5 
         */
        static void Main(string[] args)
        {

            for (int i = 1; i <= 5; i++)
            {

                for (int j = 5-i; j >= 1; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                    Console.Write(" ");

                }
                Console.WriteLine();
            }

        }

    }
    class Pattern14
    {
        /*      A
         *     B B
         *    C C C
         *   D D D D 
         *  C C C C C
         */
        static void Main(string[] args)
        {

            for (char i = 'A'; i <= 'E'; i++)
            {

                for (char j = (char)('E'-i); j >=1; j--)
                {
                    Console.Write(" ");
                }
                for (char j = 'A'; j <= i; j++)
                {
                    Console.Write(i);
                    Console.Write(" ");

                }
                Console.WriteLine();
            }

        }

    }
    class Pattern15
    {
        /*      1
         *      2 3
         *      4 5 6
         *      7 8 9 10
         *      11 12 13 14 15
         */
        static void Main(string[] args)
        {

            int count = 1;
                
                
            for (int i = 1; i<=5;i++)
            {

                
                for(int j=1;j<=i; j++)
                {
                   
                    
                    
                        
                        Console.Write(count);
                        Console.Write(" ");
                        count++;
                        
                    
                    
                        

                }
                
                
                Console.WriteLine();
            }
        }
    }
    class Pattern16
    {    /*
          *           6
          *          56
          *         456
          *        3456
          *       23456
          *      123456
          */      


        static void Main(string[] args)
        {
            for (int i = 6; i >= 1; i--)
            {
                for (int j = 1; j <= 6; j++)
                {
                    if (j >= i)
                        Console.Write(j);
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

    }
    class Pattern17
    {
        /*
         *         1
         *        12
         *       123
         *      1234
         *     12345
         */     
        static void Main(string[] args)
        {
            int count = 4;
            for (int i = 1; i<= 5; i++)
            {
             
                for(int space=1;space<=count;space++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <=i; j++)
                {
                    Console.Write(j);  
                    
                }
                
                Console.WriteLine();
                count--;
            }
        }
    }
    class Pattern18
    {
        /* 
          *********
           *******
            *****
             ***
              *
         */
        static void Main(string[] args)
        {

            for (int i = 1; i<= 9; i = i+2)
            {

                for (int j = 1; j <=i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = i; j <= 9; j++)
                {
                    Console.Write("*");
                    Console.Write(" ");

                }
                Console.WriteLine();
            }
        }
    }
}


