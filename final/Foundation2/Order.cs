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
        
    }
}

// Can return a string for the packing label. Can return a string for the shipping label.
// A packing label should list the name and product id of each product in the order.
// A shipping label should list the name and address of the customer