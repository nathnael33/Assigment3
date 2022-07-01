using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice;
            int c;
            string rad;
            double rad1;
            double w;
            string wi;
            double l;
            string li;

            Cirlce obj = new Cirlce();
            Rectangle rect = new Rectangle();   
            Console.WriteLine("Press 1 if you want to calculate the area and perimeter of Cirlce");
            Console.WriteLine();
            Console.WriteLine("Press 2 if you want to calculate the area and perimeter of Rectangle");
            choice=Console.ReadLine();
            c = Convert.ToInt32(choice);

            switch (c)
            {
                case 1: { Console.WriteLine("Please Enter the radius of the cirlce");
                        rad=Console.ReadLine();
                        rad1 = Convert.ToDouble(rad);
                        obj.Raduis = rad1;
                        Console.WriteLine("The Area of the Circle is=" + obj.calculate_Area());
                        Console.WriteLine("The Perimeter of the Cirlce is="+obj.calculate_perimeter());
                        Console.ReadKey();
                        
                        break; }
                case 2: {

                        Console.WriteLine("Please Enter the width of the rectangle");
                        wi=Console.ReadLine();
                        w=Convert.ToDouble(wi);
                        Console.WriteLine("Please Enter the Lenght of the Rectangle");
                        li=Console.ReadLine();
                        l=Convert.ToDouble(li);
                        rect.Lenght= l;
                        rect.Width= w;
                        Console.WriteLine("The Area of the Rectangle is=" + rect.calculate_Area());
                        Console.WriteLine("The Perimeter of the Rectabgle is=" + rect.calculate_perimeter());
                        Console.ReadKey();

                        break; }


            }







        }
    }
}
