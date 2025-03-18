using System;

class Order
{
    // Attribute declaration
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    // Constructor declaration
    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    // Module declaration
    public float GetTotalCost()
    {
        float totalCost = 0;

        // Calculate product prices
        foreach (var product in _products)
        {
            totalCost += product.GetCost();
        }

        // Determine shipping cost
        if ( _customer.IsCustomerUSA() )
        {
            totalCost += 5;
        } else {
            totalCost += 35;
        }

        // Return totalCost
        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        packingLabel += _customer.GetName() + "\n";
        foreach ( var product in _products )
        {
            packingLabel += "Product ID: " + product.GetProductID() + "\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = "";
        shippingLabel += _customer.GetName() + "\n";
        shippingLabel += _customer.GetAddress();
        return shippingLabel;
    }
}
