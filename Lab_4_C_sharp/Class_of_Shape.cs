using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
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
        area = Math.Round(Math.PI * this.radius, 2);
        return area;
    }
 

    public override double Perimeter()
    {
        double perimeter;
        perimeter = Math.Round(2 * Math.PI * this.radius, 2);
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
        area = Math.Round(4 * this.side, 2);
        return area;
    }

    public override double Perimeter()
    {
        double perimeter;
        perimeter = Math.Round(this.side * this.side, 2);
        return perimeter;
    }
}