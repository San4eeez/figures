using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figures
{
   
        class CirclePiramida : Circle
        {
            private double h;

            public CirclePiramida(double radius, double h) : base(radius)
            {
                this.h = h;
            }


            private double total_surface_area()
            {
                double l = Math.Sqrt(Math.Pow(radius, 2) + Math.Pow(h, 2));
                double x = Math.PI * radius * l;

                return area() + x;
            }

            private double volume()
            {
                return (1.0 / 3) * area() * h;
            }

            public new void Out()
            {
                Console.WriteLine("Радиус Михаила(Круга) " + radius);
                Console.WriteLine($"Полная площадь поверхности конуса: {total_surface_area():f3}");
                Console.WriteLine($"Периметр основания конуса {perimeter():f3}");
                Console.WriteLine($"Объем конуса: {volume():f3}");
            }
        }
}
