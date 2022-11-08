using System;

namespace Lab4_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;


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
            Console.WriteLine("Периметр квадрату:" + square1.Perimeter());
            Console.WriteLine("Периметр квадрату:" + square2.Perimeter());

            if (square1.Perimeter() > square2.Perimeter())
            {
                Console.WriteLine("Більшим периметром квадрату є " + square1.Area());
            }
            else
            {
                Console.WriteLine("Більшим периметром квадрату є " + square2.Area());
            }


            if (circle1.Perimeter() > circle2.Perimeter())
            {
                Console.WriteLine("Більшим периметром кола є " + circle1.Area());
            }
            else
            {
                Console.WriteLine("Більшим периметром кола є " + circle2.Area());
            }

            Console.ReadKey();
        }
    }
}
