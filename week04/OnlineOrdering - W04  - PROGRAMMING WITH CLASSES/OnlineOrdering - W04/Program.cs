// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // --- ORDER 1 (USA Customer) ---
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", "L100", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "M200", 25.50, 2));

        // --- ORDER 2 (International Customer) ---
        Address address2 = new Address("Rua Augusta, 500", "São Paulo", "SP", "Brazil");
        Customer customer2 = new Customer("Roberto Silva", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Smartphone", "S500", 800.00, 1));
        order2.AddProduct(new Product("Case", "C100", 15.00, 3));
        order2.AddProduct(new Product("Headphones", "H300", 50.00, 1));

        // --- DISPLAY RESULTS ---
        
        // Display Order 1
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("ORDER 1 DETAILS");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("\nTotal Price: $" + order1.CalculateTotalCost().ToString("F2")); // F2 formats to 2 decimal places

        // Display Order 2
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("ORDER 2 DETAILS");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("\nTotal Price: $" + order2.CalculateTotalCost().ToString("F2"));
        Console.WriteLine("------------------------------------------");
    }
}