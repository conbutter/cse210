using System;

class Customer
{
    // Attribute declaration
    private string _name;
    private Address _address;

    // Constructor declaration
    public Customer(string name, string streetAddress, string city, string state, string country)
    {
        _name = name;
        Address address = new Address(streetAddress, city, state, country);
        _address = address;
    }

    // Module declaration
    public bool IsCustomerUSA()
    {
        if ( _address.IsCountryUSA() )
        {   
            return true;
        } else {
            return false;
        }
    }

    public string GetAddress()
    {
        return _address.GetAddress();
    }


    public string GetName()
    {
        return _name;
    }
}