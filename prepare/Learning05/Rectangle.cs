using System;

class Rectangle : Shape
{
    // Attribute declaration
    private double _side_1;
    private double _side_2;

    // Constructor declaration
    public Rectangle(string color, double side_1, double side_2) : base(color)
    {
       _side_1 = side_1;
       _side_2 = side_2;
    }

    // Module declaration

    public override double GetArea()
    {
        return _side_1 * _side_2;
    }
    
}