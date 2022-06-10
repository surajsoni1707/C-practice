using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class AlphabetDigitSpecialChar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter char or number or special character:");
            string s = Console.ReadLine();
            if (s == "a" || s == "A" || s == "b"|| s == "B"|| s == "c"|| s == "C"|| s == "d"|| s == "D"|| s == "e"|| s == "E"||
                s == "f"|| s == "F"|| s == "g"|| s == "G"| s == "h"|| s == "H"|| s == "i"|| s == "I" || s == "J" || s == "j" ||
                s == "k" || s == "K" || s == "L" || s == "l"||s == "m" || s == "M" || s == "n" || s == "N" ||
                s == "o" || s == "O" || s == "p" || s == "P" || s == "q" || s == "Q" || s == "r" || s == "R" || s == "s" || s == "S" || s == "t" || s == "T" || s == "u" || s == "U" ||
                s == "v" || s == "V" || s == "w" || s == "W" | s == "x" || s == "X" || s == "y" || s == "Y" || s == "z" || s == "Z" )
            
                Console.WriteLine("{0} is character", s);
            else if(s == "1" || s == "2" || s == "3" || s == "4" || s == "5" || s == "6" || s == "7" || s == "8" || s == "9" || s == "0")
                Console.WriteLine("{0} is a digit",s);
            else
                Console.WriteLine("{0} is special character",s);
             
            

        }
    }
}
