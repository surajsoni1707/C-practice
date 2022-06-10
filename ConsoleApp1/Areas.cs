using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Areas
    {
        static void Main(string[] args)
        {
            float pi = 3.14f;
            int radius = 0;
            Console.WriteLine("1.To Calculate Area of Circle, Enter 1");
            Console.WriteLine("2.To Calculate Area of Square, Enter 2");
            Console.WriteLine("3.To Calculate Area of Right angle Triangle, Enter 3");
            Console.WriteLine("4.To Calculate Area of Rectangle, Enter 4");
            Console.WriteLine("5.To calculate Circumference, Enter 5");
            Console.WriteLine("6.To Calculate Perimeter of a Square, Enter 6");
            int ch = Convert.ToInt32(Console.ReadLine());
            
                switch(ch)
                {
                    case 1:
                        {
                            Console.WriteLine("ENter Radius:");
                            radius = Convert.ToInt32(Console.ReadLine());
                            float areaOfCircle = pi * radius * radius;
                            Console.WriteLine("Area Of Circle Is="+areaOfCircle);
                            break;

                        }
                    case 2:
                        {
                            Console.WriteLine("Enter Side Of A Square:");
                            int side = Convert.ToInt32(Console.ReadLine());
                            int areaOfSquare = side * side;
                            Console.WriteLine("Area OF A Square is="+areaOfSquare);
                            break;

                        }
                    case 3:
                        {
                            Console.WriteLine("Enter Base:");
                            int base1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Height:");
                            int height = Convert.ToInt32(Console.ReadLine());
                            float areaOfRightAngleTriangle = base1 * height / 2f;
                            Console.WriteLine("Area Of Right Angle Triangle Is="+areaOfRightAngleTriangle);
                            break;

                        }
                    case 4:
                        {
                            Console.WriteLine("Enter Width: ");
                            int width = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Length:");
                            int length = Convert.ToInt32(Console.ReadLine());
                            int areaOfRectangle = width * length;
                            Console.WriteLine("Area Of Rectangle is:"+areaOfRectangle);
                            break;
                        }
                     case 5:
                    {
                        Console.WriteLine("Enter Radius:");
                        radius = Convert.ToInt32(Console.ReadLine());
                        float circumference = 2 * pi * radius;
                        Console.WriteLine("Circumference of A Circle is:"+circumference);
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Enter A side Of Circle:");
                        int side = Convert.ToInt32(Console.ReadLine());
                        int perimeter = 4 * side;
                        Console.WriteLine("Perimeter Of A Square is:"+perimeter);
                        break;
                    }
                default:
                    Console.WriteLine("Enter A Valid Number");
                    break;
                }
            

        }
    }
}
