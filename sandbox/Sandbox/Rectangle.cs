public class Rectangle
{
    // Attribute delcarations
    private Measurement _width;
    private Measurement _height;

    // Constructor declarations
    public Rectangle()
    {
        _initialize();
        _width.SetValue(0);
        _height.SetValue(0);
    }

    public Rectangle(double width, double height)
    {
        _initialize();
        _width.SetValue(width);
        _height.SetValue(height);
    }
    
    // Module declarations

    public void SetWidth(double width)
    {
        if (width < 0)
        {
            Console.WriteLine("Unacceptable width value");
            return;
        }
        _width.SetValue(width);
    }

        public void SetHeight(double height)
    {
        if (height < 0)
        {
            Console.WriteLine("Unacceptable height value");
            return;
        }
        _height.SetValue(height);
    }

    public void Display()
    {
        Console.WriteLine($"Rectangle: {_width}, {_height}");
    }

    private void _initialize()
    {
        _width = new Measurement();
        _height = new Measurement();
    }

    public void SetMetric(bool flag)
    {
        _width.SetMetric(flag);
        _height.SetMetric(flag);
    }
}