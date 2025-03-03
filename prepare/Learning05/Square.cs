using System;

class Square : Shape
{
    // Attribute declaration
    private double _side;

    // Constructor declaration
    public Square(string color, double side) : base(color)
    {
       _side = side;
    }

    // Module declaration

    public override double GetArea()
    {
        return _side * _side;
    }
    
}