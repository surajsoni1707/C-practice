using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment
{
    class IMEINumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 15 digit IMEI Number:");
            long imei = Convert.ToInt64(Console.ReadLine());
            long imei2 = imei;

            if (imei > 99999999999999 && imei <= 999999999999999)
            {
                //1st
                long first_digit = imei % 10;
                imei = imei / 10;
                // Right-most 2nd digit
                long second_digit = imei % 10;
                long second_digit1 = second_digit * 2;
                if (second_digit1 > 9)
                {
                    long a1 = second_digit1 % 10;
                    long a2 = second_digit1 / 10;
                    second_digit1 = a1 + a2;
                }
                imei = imei / 10;
                //3rd Digit
                long third_digit = imei % 10;
                imei = imei / 10;

                //4th digit
                long fourth_digit = imei % 10;
                long fourth_digit1 = fourth_digit * 2;
                if (fourth_digit1 > 9)
                {
                    long a1 = fourth_digit1 % 10;
                    long a2 = fourth_digit1 / 10;
                    fourth_digit1 = a1 + a2;
                }
                imei = imei / 10;

                //5th digit
                long fifth_digit = imei % 10;
                imei = imei / 10;

                //6th Digit
                long sixth_digit = imei % 10;
                long sixth_digit1 = sixth_digit * 2;
                if (sixth_digit1 > 9)
                {
                    long a1 = sixth_digit1 % 10;
                    long a2 = sixth_digit1 / 10;
                    sixth_digit1 = a1 + a2;
                }
                imei = imei / 10;

                //7th digit
                long seventh_digit = imei % 10;
                imei = imei / 10;

                //8th Digit
                long eighth_digit = imei % 10;
                long eighth_digit1 = eighth_digit * 2;
                if (eighth_digit1 > 9)
                {
                    long a1 = eighth_digit1 % 10;
                    long a2 = eighth_digit1 / 10;
                    eighth_digit1 = a1 + a2;
                }
                imei = imei / 10;

                //9th digit
                long nineth_digit = imei % 10;
                imei = imei / 10;

                //10th Digit
                long tenth_digit = imei % 10;
                long tenth_digit1 = tenth_digit * 2;
                if (tenth_digit1 > 9)
                {
                    long a1 = tenth_digit1 % 10;
                    long a2 = tenth_digit1 / 10;
                    tenth_digit1 = a1 + a2;
                }
                imei = imei / 10;

                //11th digit
                long eleventh_digit = imei % 10;
                imei = imei / 10;

                //12th Digit
                long twelfth_digit = imei % 10;
                long twelfth_digit1 = twelfth_digit * 2;
                if (twelfth_digit1 > 9)
                {
                    long a1 = twelfth_digit1 % 10;
                    long a2 = twelfth_digit1 / 10;
                    twelfth_digit1 = a1 + a2;
                }
                imei = imei / 10;

                //13th digit
                long thirteenth_digit = imei % 10;
                imei = imei / 10;
               

                //14th Digit
                long fourteenth_digit = imei % 10;
                
                long fourteenth_digit1 = fourteenth_digit * 2;
                if (fourteenth_digit1 > 9)
                {
                    long a1 = fourteenth_digit1 % 10;
                    long a2 = fourteenth_digit1 / 10;
                    fourteenth_digit1 = a1 + a2;
                    
                }
                imei = imei / 10;

                //15th digit
                long fifteenth_digit = imei % 10;
                

               
                long sum = first_digit + second_digit1 + third_digit + fourth_digit1 + fifth_digit + sixth_digit1 + seventh_digit + eighth_digit1 + nineth_digit + tenth_digit1 + eleventh_digit+ twelfth_digit1 + thirteenth_digit + fourteenth_digit1 + fifteenth_digit;
                Console.WriteLine("After Doubling every other digits:");
                Console.WriteLine("IMEI:{14}{13}{12}{11}{10}{9}{8}{7}{6}{5}{4}{3}{2}{1}{0}", first_digit, second_digit1, third_digit,fourth_digit1,fifth_digit,sixth_digit1,seventh_digit,eighth_digit1,nineth_digit,tenth_digit1,eleventh_digit, twelfth_digit1, thirteenth_digit, fourteenth_digit1,fifteenth_digit);
                if (sum % 10 == 0)
                    Console.WriteLine("{0} is valid IMEI Number", imei2);
                else
                    Console.WriteLine("{0} is not valid IMEI Number", imei2);
            }
            else
                Console.WriteLine("Enter 15 digit IMEI Number");

        }
    }
}
