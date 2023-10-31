using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figures
{
    class Circle
    {
        protected double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        protected double perimeter()
        { return (2 * 3.14 * radius); }

        protected double area()
        { return (3.14 * (radius * radius)); }

        public void Out()
        {
            Console.WriteLine($"Михаил с радиусом {radius}");
            Console.WriteLine($"Площадь Михаила: {area():f3}");
            Console.WriteLine($"Периметр Михаила: {perimeter():f3}");
        }
    }
}
//Владимирский централ, ветер северный...
