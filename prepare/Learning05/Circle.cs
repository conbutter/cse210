using System;

class Circle : Shape
{
    // Attribute declaration
    private double _radius;

    // Constructor declaration
    public Circle(string color, double radius) : base(color)
    {
       _radius = radius;
    }

    // Module declaration

    public override double GetArea()
    {
        return Math.PI * (_radius * _radius);
    }
    
}