using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Denomination
    {
        static void Main(string[] args)
        {
            int notes_2000=0;
            int notes_500=0;
            int notes_200=0;
            int notes_100=0;
            int notes_50=0;
            int notes_20=0;
            int notes_10=0;
            int coin_1=0;
            Console.WriteLine("Enter Amount:");
            int amount = Convert.ToInt32(Console.ReadLine());
            //while(amount>0)
           // {
                if (amount >= 2000)
                {
                    notes_2000 = amount / 2000;
                    amount = amount % 2000;

                }
                if (amount < 2000 && amount >= 500)
                {
                    notes_500 = amount / 500;
                    amount = amount % 500;

                }
                 if (amount < 500 && amount >= 200)
                {
                    notes_200 = amount / 200;
                    amount = amount % 200;

                }
               if (amount < 200 && amount >= 100)
                {
                    notes_100 = amount / 100;
                    amount = amount % 100;
                }
                  if (amount < 100 && amount >= 50)
                {
                    notes_50 = amount / 50;
                    amount = amount % 50;
                }
                if (amount < 50 && amount >= 20)
                {
                    notes_20 = amount / 20;
                    amount = amount % 20;
                }
                 if (amount < 20 && amount >= 10)
                {
                    notes_10 = amount / 10;
                    amount = amount % 10;
                }
                if(amount>0 &&amount<10)
                {
                    coin_1 = amount / 1;
                    amount = amount % 1;
                
                }
                else
                Console.WriteLine( "Enter Valid Amount");
            //}
            Console.WriteLine("Denomination is:");
            Console.WriteLine("Total No. of 2000 Rupees Notes:"+notes_2000);
            Console.WriteLine("Total No. of 500 Rupees Notes::" + notes_500);
            Console.WriteLine("Total No. of 200 Rupees Notes:" + notes_200);
            Console.WriteLine("Total No. of 100 Rupees Notes:" + notes_100);
            Console.WriteLine("Total No. of 50 Rupees Notes:" + notes_50);
            Console.WriteLine("Total No. of 20 Rupees Notes:" + notes_20);
            Console.WriteLine("Total No. of 10 Rupees Notes:" + notes_10);
            Console.WriteLine("Total No. of 1 Rupee coin:"+coin_1);
            int total= notes_2000 + notes_500 +notes_200+ notes_100+ notes_50+ notes_20+ notes_10;
            Console.WriteLine("Total number of notes and coins are: {0} notes & {1} coin(s)",total,coin_1);


        }
    }
}
