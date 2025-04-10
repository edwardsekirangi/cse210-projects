using System;

class Program
{

    static void Main(string[] args)
    {
        Address address1 = new Address("123 Elm St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("USB Cable", "A1001", 5.99, 3));
        order1.AddProduct(new Product("Wireless Mouse", "A1002", 15.49, 1));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.GetTotalPrice());

        Address address2 = new Address("88 Baker St", "London", "England", "UK");
        Customer customer2 = new Customer("Emily Clark", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Notebook", "B2001", 3.99, 5));
        order2.AddProduct(new Product("Pen Set", "B2002", 7.25, 2));

        Console.WriteLine("\n" + order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.GetTotalPrice());
    }
    
}