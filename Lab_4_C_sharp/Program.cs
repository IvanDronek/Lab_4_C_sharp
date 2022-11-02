using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    static void Main(string[] args)
    {
        Circle circle1 = new Circle(5);
        Circle circle2 = new Circle(25);

        Console.WriteLine("Площа кола:" + circle1.Area());
        Console.WriteLine("Площа кола:" + circle2.Area());
        Console.WriteLine("Периметр кола:" + circle1.Perimeter());
        Console.WriteLine("Периметр кола:" + circle2.Perimeter());

        Square square1 = new Square(5);
        Square square2 = new Square(25);

        Console.WriteLine("Площа квадрату:" + square1.Area());
        Console.WriteLine("Площа квадрату:" + square2.Area());
        Console.WriteLine("Периметр квадрвту:" + square1.Perimeter());
        Console.WriteLine("Периметр квадрвту:" + square2.Perimeter());






        Console.ReadKey();
    }
}
