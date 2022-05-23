using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Assignment3
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black; //used for better view 
            Console.BackgroundColor = ConsoleColor.White;
            double height, width;
            Values(out height, out width);
            double area = MathArea(height, width);
            double perimeter = MathPerimeter(height, width);
            Results(height, width, area, perimeter);
            Console.ReadKey();

        }
        //method to get the values
        static void Values(out double height, out double width) 
        {
            Console.Write("Enter the height of the rectangle: ");
            height = double.Parse(Console.ReadLine());
            Console.Write("Enter the width of the rectangle: ");
            width = double.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        //method for area
        static double MathArea(double height, double width)
        {
            return height * width;
        }
        //method for perimeter
        static double MathPerimeter(double height, double width)
        {
            return (height + width) * 2.0;
        }
        //result method provides table 
        static void Results(double height, double width, double area, double perimeter)
        {
            Console.WriteLine("Rectangle    Measurements:");
            Console.WriteLine("Height:        : {0,9:F2}", height);
            Console.WriteLine("Width:         : {0,9:F2}", width);
            Console.WriteLine("Area           : {0,9:F2}", area);
            Console.WriteLine("Perimeter      : {0,9:F2}", perimeter);
        
        }
    }
}
