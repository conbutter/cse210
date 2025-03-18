using System;

class Product
{
    // Attribute declaration
    private string _name;
    private int _productID;
    private double _pricePerUnit;
    private int _quantity;

    // Constructor declaration


    // Module declaration
    public int GetCost()
    {
        return _pricePerUnit * double.Parse(_quantity);
    }
}