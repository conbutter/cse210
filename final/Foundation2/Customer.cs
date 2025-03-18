using System;

class Customer
{
    // Attribute declaration
    private string _name;
    private Address _address;

    // Constructor declaration
    public Customer(string name, Address address)
    {
        _name = name;
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