using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Cirlce   : Shape
    {
        public double Raduis { get; set; }
        static readonly Double pi = 3.14;

        public double calculate_Area()
        {
            double area = 0;

            area = pi * Raduis * Raduis;
            return area;
           
            
        }

        public  double calculate_perimeter()
        {
            double perimeter = 0;
            perimeter = 2 * pi * Raduis;
           return perimeter;
        }
    }
}
