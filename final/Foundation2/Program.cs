using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> _orders = new List<Order>();
        CreateOrders();
        foreach ( Order order in _orders )
        {
            // Display contents here
        }
    }

    static void CreateOrders()
    {
        // Create customers w/ addresses
        Customer customer1 = new Customer("Bob Hale", "593 London Parkway", "London", "NW1 6XE", "UK");
        Customer customer2 = new Customer("Harmond Row", "1975 Tomorrow Way", "Tampa", "FL", "USA");

        // Create products
        Product product1 = new Product("Zorbeez", 100, 7, 30);
        Product product2 = new Product("Lysol Wipes", 101, 5, 55);
        Product product3 = new Product("Nintendo Switch", 102, 300, 3);

        // Create two orders
        Order order1 = new Order(customer1, new List<Product> { product1, product2 });
        Order order2 = new Order(customer2, new List<Product> { product1, product3 });
    }
}