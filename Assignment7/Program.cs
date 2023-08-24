using System;

// Abstract base class
abstract class Shape
{
    public abstract double CalculateArea(); // Abstract method for calculating area
}

// Derived class Circle
class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius; // Area of a circle: π * r^2
    }
}

// Derived class Rectangle
class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea()
    {
        return Width * Height; // Area of a rectangle: width * height
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(5);
        double circleArea = circle.CalculateArea();
        Console.WriteLine($"Circle Area: {circleArea}");

        Rectangle rectangle = new Rectangle(4, 6);
        double rectangleArea = rectangle.CalculateArea();
        Console.WriteLine($"Rectangle Area: {rectangleArea}");
    }
}
