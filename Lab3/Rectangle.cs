using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Rectangle : Shape
    {

        public double Lenght{ get; set; }
        public double Width{ get; set; }
        public double calculate_Area()
        {
            double Area = 0;
            Area=Lenght*Width;
            return Area;
        }

        public double calculate_perimeter()
        {
            double Perimeter = 0;
            Perimeter = 2*(Lenght * Width);
            return Perimeter;
       }
    }
}
