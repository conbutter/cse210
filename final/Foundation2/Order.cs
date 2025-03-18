using System;

class Order
{
    // Attribute declaration
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    // Constructor declaration
    public Order(Customer customer, List<Product> products)
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

        // Add shipping cost
        totalCost += ShippingCost();

        // Return totalCost
        return totalCost;
    }

    public int ShippingCost()
    {
        if ( _customer.IsCustomerUSA() )
        {
            return 5;
        } else {
            return 35;
        }
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        packingLabel += _customer.GetName() + " | Product IDs: ";
        foreach ( var product in _products )
        {
            if ( _products.IndexOf(product) == _products.Count - 1) {
                packingLabel += + product.GetProductID();
            } else {
                packingLabel += + product.GetProductID() + ", ";
            }
            
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = "";
        shippingLabel += _customer.GetName() + " | Address: ";
        shippingLabel += _customer.GetAddress();
        return shippingLabel;
    }
}
