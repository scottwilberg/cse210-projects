using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        // create order 1
        Address address1 = new Address("1987 N Yellow St", "Anyberg", "MN", "USA");
        Customer customer1 = new Customer("Joe Bird", address1);
        Order order1 = new Order(customer1);
        Product product1 = new Product("Phone", "D546FG", 249.99, 3);
        Product product2 = new Product("Case", "F174BG", 19.99, 5);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        // create order 2
        Address address2 = new Address("256 E Blue St", "Iceburg", "SP", "Spain");
        Customer customer2 = new Customer("Jane Dog", address2);
        Order order2 = new Order(customer2);
        Product product3 = new Product("TV", "D546FG", 549.99, 3);
        Product product4 = new Product("TV Stand", "F174BG", 49.99, 1);
        Product product5 = new Product("Wall Mount Bracket", "F174BG", 59.99, 2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // print the required information
        Console.Clear();
        Console.WriteLine(new string('*',50));
        Console.WriteLine("Order 1\nPacking Label: ");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(new string('-',50));
        Console.WriteLine("Order 1\nShipping Label: ");
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine();
        Console.WriteLine(new string('-',50));
        Console.WriteLine($"Order 1 {order1.ToString()}");
        Console.WriteLine();
        Console.WriteLine(new string('*',50));
        Console.WriteLine("Order 2\nPacking Label: ");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(new string('-',50));
        Console.WriteLine("Order 2\nShipping Label: ");
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine();
        Console.WriteLine(new string('-',50));
        Console.WriteLine($"Order 2 {order2.ToString()}");
    }
}