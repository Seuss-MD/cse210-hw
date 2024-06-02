using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order();
        order1.SetName("Paulo Cauas");
        order1.SetAddress("9th Street", "Nottingham", "New York", "USA");

        Product product1 = new Product("Cookie", "001", 4.50, 5);
        Product product2 = new Product("Pasta", "002", 8.93, 3);
        Product product3 = new Product("Shampoo", "003", 7.89, 1);

        order1.AddList(product1);
        order1.AddList(product2);
        order1.AddList(product3);

        Order order2 = new Order();
        order2.SetName("Steven Langston");
        order2.SetAddress("Copacabana Avenue", "Rio de Janeiro", "Rio de Janeiro", "Brazil");

        Product product4 = new Product("Laptop", "009", 2300.00, 1);
        Product product5 = new Product("Guitar", "015", 847.56, 1);
        Product product6 = new Product("Headphone", "007", 59.08, 1);

        order2.AddList(product4);
        order2.AddList(product5);
        order2.AddList(product6);

        Console.WriteLine("Order 1:");

        Console.WriteLine($"Packing Label\n{order1.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label:\n{order1.GetShippingLabel()}");
        Console.WriteLine($"\nTotal: ${order1.GetTotal()}");

        Console.WriteLine("Order 2:");

        Console.WriteLine($"Packing Label\n{order2.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label:\n{order2.GetShippingLabel()}");
        Console.WriteLine($"\nTotal: ${order2.GetTotal()}");


    }
}