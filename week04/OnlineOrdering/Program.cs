using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 (USA)
        Address a1 = new Address("123 Main St", "Los Angeles", "CA", "USA");
        Customer c1 = new Customer("John Smith", a1);

        Order o1 = new Order(c1);
        o1.AddProduct(new Product("Keyboard", 101, 25.50, 2));
        o1.AddProduct(new Product("Mouse", 102, 10.00, 1));

        // Order 2 (International)
        Address a2 = new Address("45 Queen St", "Toronto", "ON", "Canada");
        Customer c2 = new Customer("Emily Clark", a2);

        Order o2 = new Order(c2);
        o2.AddProduct(new Product("Monitor", 201, 120.00, 1));
        o2.AddProduct(new Product("USB Cable", 202, 5.00, 3));

        // Display Order 1
        Console.WriteLine("=== ORDER 1 ===");
        Console.WriteLine(o1.GetPackingLabel());
        Console.WriteLine(o1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + o1.GetTotalPrice());
        Console.WriteLine();

        // Display Order 2
        Console.WriteLine("=== ORDER 2 ===");
        Console.WriteLine(o2.GetPackingLabel());
        Console.WriteLine(o2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + o2.GetTotalPrice());
    }
}