using Pramo;
using Kvadratik;
using Mihail;
using Shifr;

Rectangle rectangle = new Rectangle();
Square square = new Square();
Circle circle = new Circle();
Bill bill = new Bill();


Console.WriteLine("Добро пожаловать в курс математики за 7й класс!");

while (true)
{
    Console.WriteLine("\n\nУкажите какую фигуру будем оформлять.\n1 - Квадрат\n2 - Прямоугольник\n3 - Михаил Круг\n4 - Треугольник");
    Console.WriteLine("Ввод: ");
    int what = int.Parse(Console.ReadLine());
    Console.Clear();
    if (what == 1)
    {
        Console.WriteLine("Квадрат\n\n");
        Console.Write("Введи сторону квадрата: ");
        float s = float.Parse(Console.ReadLine());
        Console.Clear();
        square.Perimetr(s);
        square.Ploshad(s);
    }
    if (what == 2)
    {
        Console.WriteLine("Прямоугольник\n\n");
        Console.Write("Введи 1 сторону прямоугольника: ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Введи 2 сторону прямоугольника: ");
        float b = float.Parse(Console.ReadLine());
        Console.Clear();
        rectangle.Perimetr(a,b);
        rectangle.Ploshad(a,b);
    }
    if (what == 3)
    {
        Console.WriteLine("Михаил Круг");
        Console.Write("Введи радиус Михаила Круга: ");
        float r = float.Parse(Console.ReadLine());
        circle.Perimetr(r);
        circle.Ploshad(r);
    }
    if (what == 4)
    {
        Console.WriteLine("Билл Шифр (треугольник)");

        Console.Write("Сторона a(катет): ");
        float a = float.Parse(Console.ReadLine());

        Console.Write("Сторона b(катет): ");
        float b = float.Parse(Console.ReadLine());

        Console.Write("Сторона c(гипотенузавр): ");
        float c = float.Parse(Console.ReadLine());

        bill.Perimetr(a, b, c);
        bill.Ploshad(a, b, c);
       
    }
}