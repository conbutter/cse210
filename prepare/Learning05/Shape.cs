using System;

abstract class Shape
{
    // Attribute declaration
    private string _color;

    // Constructor declaration
    public Shape(string color)
    {
        _color = color;
    }

    // Module declaration

    public abstract double GetArea(); // Instead of "abstract", could also be "virtual" for default body. If any abstract functions, must include abstract in class declaration

    public string GetShapeColor()
    {
        return _color;
    }

    public void GetShapeColor(string new_color)
    {
        _color = new_color;
    }
    
}