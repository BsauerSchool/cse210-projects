using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 -------------
        // Customer1 information
        Customer customer1 = new Customer("Tessa Sauer");
        Address address1 = new Address("132 Sierra Way", "Layton", "UT", "USA");
        customer1.SetAddress(address1);
        Order order1 = new Order(customer1);
        Product product1 = new Product();
        product1.SetProduct("Twinkie",123, 1.75, 25);
        Product product2 = new Product();
        product2.SetProduct("Twonkie", 132, 2.50, 300);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        // Order 1 Display --------
        Display(order1.PackingLabel(), order1.ShippingLabel(), order1.TotalOrder());


        // Order 2
        Customer customer2 = new Customer("Brendin Sauer");
        Address address2 = new Address("1041 SW 20th St", "Chehalis", "WA", "Not-USA");
        customer2.SetAddress(address2);
        Order order2 = new Order(customer2);
        Product product3 = new Product();
        product3.SetProduct("Twinkie",123, 1.75, 25);
        Product product4 = new Product();
        product4.SetProduct("Twonkie", 132, 2.50, 300);
        Product product5 = new Product();
        product5.SetProduct("Twoonkie", 144, 4.00, 43);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Order 2 Display-----------
         Display(order2.PackingLabel(), order2.ShippingLabel(), order2.TotalOrder());
    }

    public static void Display(List<string> pack, string ship, double total)
    {
        Console.WriteLine($"Packing Label: ");
        Console.WriteLine("----------");
        foreach(string item in pack)
        {
            Console.WriteLine(item);
        } 
        Console.WriteLine();
        Console.WriteLine($"Shipping Label ");
        Console.WriteLine("----------");
        Console.WriteLine($"{ship}");

        Console.WriteLine($"Total Price: {total}");
        Console.WriteLine();
    }
}