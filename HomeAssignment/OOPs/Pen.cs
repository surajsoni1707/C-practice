using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.OOPs
{
    class Pen
    {
        Refill r;
        int capLength;
        String brand;

        public int CapLength { get => capLength; set => capLength = value; }
        public string Brand { get => brand; set => brand = value; }
        internal Refill R { get => r; set => r = value; }
    }
    class Refill
    {
        String inkColor;
        int length;
        Nib n;

        public string InkColor { get => inkColor; set => inkColor = value; }
        public int Length { get => length; set => length = value; }
        internal Nib N { get => n; set => n = value; }
    }
    class Nib
    {
        String materialType;
        int width;

        public string MaterialType { get => materialType; set => materialType = value; }
        public int Width { get => width; set => width = value; }
    }
    class Pen2
    {
        static void Main(string[] args)
        {
            Pen p = new Pen();
            p.CapLength = 20;
            p.Brand = "Raynolds";
            p.R = new Refill();
            p.R.InkColor = "Black";
            p.R.Length = 10;
            p.R.N = new Nib();
            p.R.N.MaterialType = "Steel";
            p.R.N.Width = 5;

            Console.WriteLine("Pen Brand:" + p.Brand);
            Console.WriteLine("Cap Length:" + p.CapLength);
            Console.WriteLine("Ink Color:"+ p.R.InkColor);
            Console.WriteLine("Refill Length:"+ p.R.Length);
            Console.WriteLine("Nib Material:"+ p.R.N.MaterialType);
            Console.WriteLine("Nib Width:" +p.R.N.Width);


        }
    }

        
}
