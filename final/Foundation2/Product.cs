using System;

class Product
{
    // Attribute declaration
    private string _name;
    private int _productID;
    private float _pricePerUnit;
    private int _quantity;

    // Constructor declaration
    public Product(string name, int productID, float pricePerUnit, int quantity)
    {
        _name = name;
        _productID = productID;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    // Module declaration
    public float GetCost()
    {
        return _pricePerUnit * _quantity;
    }
}