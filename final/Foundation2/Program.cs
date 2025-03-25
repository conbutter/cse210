using System;

class Program
{
    private static List<Order> _orders = new List<Order>();

    static void Main(string[] args)
    {
        Console.Clear();
        CreateOrders();
        DisplayOrders();
    }

    static void CreateOrders()
    {
        Customer customer1 = new Customer("Harmond Row", "1975 Tomorrow Way", "Tampa", "FL", "USA");
        Customer customer2 = new Customer("Bob Hale", "593 London Parkway", "London", "NW1 6XE", "UK");
        Customer customer3 = new Customer("Connor Butterfield", "1994 Sunset Boulevard", "Lake Buena Vista", "FL", "USA");

        Product product1 = new Product("Zorbeez", 100, 7, 30);
        Product product2 = new Product("Lysol Wipes", 101, 5, 55);
        Product product3 = new Product("Nintendo Switch", 102, 300, 3);
        Product product4 = new Product("Gala Apple", 103, 0.5f, 20);

        Order order1 = new Order(customer1, new List<Product> { product1, product2 });
        _orders.Add(order1);
        Order order2 = new Order(customer2, new List<Product> { product1, product2, product3 });
        _orders.Add(order2);
        Order order3 = new Order(customer3, new List<Product> { product4, product3 } );
        _orders.Add(order3);
    }

    static void DisplayOrders()
    {
        foreach ( Order order in _orders )
        {
            Console.WriteLine($"Order #{_orders.IndexOf(order) + 1}");
            Console.WriteLine($"PACKING LABEL: {order.GetPackingLabel()}");
            Console.WriteLine($"SHIPPING LABEL: {order.GetShippingLabel()}");
            Console.WriteLine($"Total Order Cost: ${order.GetTotalCost()}\n");
        }
    }
}