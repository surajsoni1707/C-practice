using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch
{
    class Toggle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Character");
            char ch = Convert.ToChar(Console.Read());
            char rr;
            if(ch>='A' && ch<='Z')
            {
                rr =(char) (ch + 32);
                Console.WriteLine(rr);
            }
            else if(ch>='a' && ch<='z')
            {
                rr = (char)(ch - 32);
                Console.WriteLine(rr);

            }
            else
                Console.WriteLine("Enter Valid Character");


        } 
    }
}
