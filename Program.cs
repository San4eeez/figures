
using figures;





Console.WriteLine("Добро пожаловать в курс математики за 7й класс!");

while (true)
{
    Console.WriteLine("\n\nУкажите какую фигуру будем оформлять.\n1 - Квадрат\n2 - Прямоугольник\n3 - Михаил Круг\n4 - Треугольник\n5 - Пирамидки");
    Console.WriteLine("Ввод: ");
    int what = int.Parse(Console.ReadLine());
    Console.Clear();
    if (what == 1)
    {
        Console.Write("Введите сторону квадрата: ");
        double a = double.Parse(Console.ReadLine());
        Square square = new Square(a);
        Console.Clear();
        square.Out();
        Console.WriteLine();
    }
    if (what == 2)
    {
        Console.Write("Введите ширину прямоугольника: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введите длину прямоугольника: ");
        double b = double.Parse(Console.ReadLine());
        Rectangle rectangle = new Rectangle(a, b);
        Console.Clear();
        rectangle.Out();
        Console.WriteLine();

    }
    if (what == 3)
    {
        Console.Write("Введите радиус круга: ");
        double a = double.Parse(Console.ReadLine());
        Circle circle = new Circle(a);
        Console.Clear();
        circle.Out();
        Console.WriteLine();
    }
    if (what == 4)
    {
        Console.WriteLine("ОДНА СТОРОНА НЕ МОЖЕТ БЫТЬ БОЛЬШЕ СУММЫ ДВУХ ДРУГИХ");
        Console.Write("Введите сторону А: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введите сторону B: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Введите сторону C: ");
        double c = double.Parse(Console.ReadLine());
        Bill triangle = new Bill(a, b, c);
        Console.Clear();
        triangle.Out();
        Console.WriteLine();
    }
    if (what == 5)
    {
        Console.Clear();
        Console.WriteLine("Пирамидки");
        Console.WriteLine("1 - Квадрат\n2 - Прямоугольник\n3 - Михаил(Круг)\n4 - Билл Шифр (треугольник)");
        Console.Write("Выбери основание: ");
        int what2 = int.Parse(Console.ReadLine());
        if (what2 == 1)
        {
            Console.Clear();
            Console.WriteLine("Квадратик пирамидка");
            Console.Write("Введите сторону квадрата для основания пирамидки: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите высоту: ");
            double h = double.Parse(Console.ReadLine());
            square_pyramid pyramid = new square_pyramid(a, h);
            Console.Clear();
            pyramid.Out();
            Console.WriteLine();
        }
        if (what2 == 2)
        {
            Console.Clear();
            Console.WriteLine("Прямоугольник пирамидка");
            Console.Write("Введите длину прямоугольника основания пирамиды: ");
            double  a = double.Parse(Console.ReadLine());
            Console.Write("Введите ширину прямоугольника основания пирамиды: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите высоту пирамиды: ");
            double h = double.Parse(Console.ReadLine());
            RectPiramida pyramid = new RectPiramida(a, b, h);
            Console.Clear();
            pyramid.Out();
            Console.WriteLine();
        }
        if(what2 == 3) 
        {
            Console.Clear();
            Console.WriteLine("Михаил Круг пирамидка");
            Console.Write("Введите радиус круга основания конуса: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите высоту конуса: ");
            double h = double.Parse(Console.ReadLine());
            CirclePiramida pyramid = new CirclePiramida(a, h);
            Console.Clear();
            pyramid.Out();
            Console.WriteLine();
        }
        if (what2 == 4)
        {
            Console.Clear();
            Console.WriteLine("ОДНА СТОРОНА НЕ МОЖЕТ БЫТЬ БОЛЬШЕ СУММЫ ДВУХ ДРУГИХ");
            Console.WriteLine("Билл Шифр (треугольник) пирамидка");
            Console.Write("Введите сторону A: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите сторону B: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите сторону C: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Введите высоту: ");
            double h = double.Parse(Console.ReadLine());
            BillPiramida pyramid = new BillPiramida(a, b, c, h);
            Console.Clear();
            pyramid.Out();
            Console.WriteLine();
        }
    }
}