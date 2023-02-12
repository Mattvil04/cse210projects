using System;

class Program
{
    static void Main(string[] args)
    {
     List<Product> products1 = new List<Product>
        {
            new Product("Product A", 1, 10, 2),
            new Product("Product B", 2, 20, 1)
        };

        Customer customer1 = new Customer("John Doe", new Address("123 Main St", "New York", "NY", "USA"));

        Order order1 = new Order(products1, customer1);

        Console.WriteLine("Order 1");
        Console.WriteLine("Packing Label");
        Console.WriteLine(order1.PackingLabel);
        Console.WriteLine("Shipping Label");
        Console.WriteLine(order1.ShippingLabel);
        Console.WriteLine("Total Cost: $" + order1.TotalCost);

        List<Product> products2 = new List<Product>
        {
            new Product("Product C", 3, 15, 3),
            new Product("Product D", 4, 25, 2),
            new Product("Product E", 5, 30, 1)
        };

        Customer customer2 = new Customer("Jane Doe", new Address("456 Main St", "Toronto", "ON", "Canada"));

        Order order2 = new Order(products2, customer2);

        Console.WriteLine("\nOrder 2");
        Console.WriteLine("Packing Label");
        Console.WriteLine(order2.PackingLabel);
        Console.WriteLine("Shipping Label");
        Console.WriteLine(order2.ShippingLabel);
        Console.WriteLine("Total Cost: $" + order2.TotalCost);

        Console.ReadLine();
    }
}