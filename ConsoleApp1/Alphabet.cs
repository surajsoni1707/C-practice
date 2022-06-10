using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Alphabet
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any alphabet:");
            char alphabet = Convert.ToChar(Console.Read());
            if(alphabet=='a' || alphabet == 'A' || alphabet == 'e' || alphabet == 'E' || alphabet == 'i' || alphabet == 'I' || alphabet == 'o' || alphabet == 'O' || alphabet == 'u' || alphabet == 'U')
                Console.WriteLine("{0} is Vowel",alphabet);
            else
                Console.WriteLine("{0} is Consonant",alphabet);
        }
    }
}
