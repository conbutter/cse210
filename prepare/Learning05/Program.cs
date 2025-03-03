using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> _shapes = new List<Shape>();

        Square square = new Square("white", 5);
        Rectangle rectangle = new Rectangle("red", 3, 7);
        Circle circle = new Circle("blue", 5);

        _shapes.Add(square);
        _shapes.Add(rectangle);
        _shapes.Add(circle);

        for (int i = 0; i < _shapes.Count; i++)
        {
            Shape shape = _shapes[i];
            Console.WriteLine($"Shape number {i + 1}, which is {shape.GetShapeColor()}, has an area of {shape.GetArea()}.");
        }
    }
}