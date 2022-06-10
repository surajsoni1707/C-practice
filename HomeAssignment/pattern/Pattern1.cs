using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.pattern
{
    class Pattern1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter No. Of Rows");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter No. Of Columns");
            int col = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<row;i++)
            {
                Console.WriteLine();
                for(int j=0; j<col;j++)
                {
                    Console.Write("*");
                }
            }
        }
    }
}
