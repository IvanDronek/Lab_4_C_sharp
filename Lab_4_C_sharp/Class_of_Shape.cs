using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

abstract public class Shape
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public void Figure(string Name)
    {
        Console.WriteLine($"Це {this.Name}");
    }

    public abstract double Area();

    public abstract double Perimeter();
}

public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double Area()
    {
        double area;
        area = Math.PI * this.radius;
        return area;
    }

    public override double Perimeter()
    {
        double perimeter;
        perimeter = 2 * Math.PI * this.radius;
        return perimeter;
    }
}

public class Square : Shape
{
    private double side;

    public Square(double side)
    {
        this.side = side;
    }

    public override double Area()
    {
        double area;
        area = 4 * this.side;
        return area;
    }

    public override double Perimeter()
    {
        double perimeter;
        perimeter = this.side * this.side;
        return perimeter;
    }

}