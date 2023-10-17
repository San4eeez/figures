using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shifr
{
    internal class Bill
    {
        private float a;
        private float b;
        private float c;

        public void Perimetr(float a, float b, float c)
        {

            this.a = a;
            this.b = b;
            this.c = c;
            float p;
            p = a + b + c;
            Console.WriteLine($"Для треугольника(Билла Шифра) со сторонами {a},{b},{c}. Периметр равен {p}");

        }

        public void Ploshad(float a, float b, float c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            float pp;
            float s;

            pp = (a + b + c)/2;

            s = (float)Math.Sqrt(pp * (pp - a) * (pp - b) * (pp - c));
            Console.WriteLine($"Для треугольника(Билла Шифра) со сторонами {a},{b},{c}. Площадь равна {s}");

        }
        


    }
}
