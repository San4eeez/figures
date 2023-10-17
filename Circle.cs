using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mihail
{
    internal class Circle
    {
        private float r;
        public void Perimetr(float r)
        {
            this.r += r;
            double p = 2 * Math.PI * r;
            Console.WriteLine($"Радиус {r}, а его периметр: {p}");
        }

        public void Ploshad(float r)
        {
            this.r += r;
            double s = Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"Радиус {r}, а его площадь: {s}");
        }
    }
}

//Владимирский централ, ветер северный...
