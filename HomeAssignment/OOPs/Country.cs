using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.OOPs
{
    class Country
    {
       /* string countryName;
        int noOfState;
        int noOfLang;
        string capital;*/

        public string CountryName
        {
            get; set;
           
        }
        public int NoOfLang
        {
            get; set;
        }
        public int NoOfStates
        {
            get;set;
        }
        public string Capital
        {
            get;set;
        }
        static void Main(string[] args)
        {
            Country c = new Country();
            Console.WriteLine( c.CountryName = "India");
            Console.WriteLine( c.NoOfLang = 5);
            Console.WriteLine(c.NoOfStates = 36);
            Console.WriteLine(c.Capital = "Delhi");
        }

    }
}
