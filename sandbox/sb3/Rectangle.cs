public class Rectangle
{
    // Attribute delcarations
    private double _width;
    private double _height;

    // Constructor declarations
    public Rectangle()
    {
        _width = 0;
        _height = 0;
    }

    public Rectangle(double width, double height)
    {
        _width = width;
        _height = height;
    }

    public void Display()
    {
        Console.WriteLine($"Rectangle: {_width}. {_height}");
    }
}