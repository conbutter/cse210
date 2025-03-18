using System;

class Address
{
    // Attribute declaration
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    // Constructor declaration
    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    // Module declaration
    public bool IsCountryUSA()
    {
        if ( _country == "USA" )
        {
            return true;
        } else {
            return false;
        }
    }

    public void Display()
    {
        Console.WriteLine($"Address: {_streetAddress}, {_city}, {_state} {_country}");
    }
}