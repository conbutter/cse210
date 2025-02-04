class Fraction
{
    // ATTRIBUTE DECLARATION
    private int _top;
    private int _bottom;

    // MODULE DECLARATION
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int topNumber)
    {
        _top = topNumber;
        _bottom = 1;
    }

    public Fraction(int topNumber, int bottomNumber)
    {
        _top = topNumber;
        _bottom = bottomNumber;
    }

    public int GetTopNumber()
    {
        return _top;
    }

    public int GetBottomNumber()
    {
        return _bottom;
    }

    public void SetTopNumber(int newTop)
    {
        _top = newTop;
    }

    public void SetBottomNumber(int newBottom)
    {
        _bottom = newBottom;
    }

    public void GetFractionString()
    {
        Console.WriteLine($"{_top}/{_bottom}");
    }

    public double GetDecimalValue()
    {
        double _fracDecimal = (double)_top / (double)_bottom;
        return _fracDecimal;
    }
}