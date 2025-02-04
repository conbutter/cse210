public class Measurement
{
    // Attribute delcarations
    private double _value;  // inches!!!
    private bool _metric;   // displaying and get()s

    // Constructor declarations
    public Measurement()
    {
        _value = 0;
        _metric = false;
    }

    public Measurement(double value)
    {
        _value = value;
        _metric = false;
    }

    public void SetMetric(bool flag)
    {
        _metric = flag;
    }

    public double GetValue()
    {
        if (_metric)
            return _value * 2.54;
        else
            return _value;
    }

    public void SetValue(double value)
    {
        if (_metric)
           _value = value / 2.54;
        else
            _value = value;
    }

    void Display()
    {
        if (_metric)
            Console.WriteLine($"Measurement: {_value * 2.54} CM");
        else
            Console.WriteLine($"Measurement: {_value} inches");
    }
}