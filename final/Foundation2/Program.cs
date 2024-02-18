using System;


class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("*** WELCOME TO THE ONLINE ORDERING PROGRAM ***\n");
        Console.WriteLine("Here are the current orders:");
        Console.WriteLine("=====================================================\n");
        
        Address address1 = new Address("Nancholi Street", "Blantyre", "Southern Region", "Malawi");
        Customer customer1 = new Customer("Moffat Katopola", address1);

        List<Product> productList1 = new List<Product>();
        Product product1 = new Product("Bicycle", "0001", 80, 2);
        productList1.Add(product1);
        Product product2 = new Product("Motorcycle", "0002", 300, 1);
        productList1.Add(product2);

        Order order1 = new Order(productList1, customer1);
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine(order1.LabelPacket());
        Console.WriteLine($"Total Price: ${order1.TotalCost()}\n");
        
        Console.WriteLine("=====================================================\n");
        
        Address address2 = new Address("Kenson Street", "Downey", "California", "United States");
        Customer customer2 = new Customer("Brian Johnson", address2);

        List<Product> productList2 = new List<Product>();
        Product product4 = new Product("Bicycle", "0001", 80, 2);
        productList2.Add(product4);
        Product product5 = new Product("Motorcycle", "0002", 300, 1);
        productList2.Add(product5);

        Order order2 = new Order(productList2, customer2);
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine(order2.LabelPacket());
        Console.WriteLine($"Total Price: ${order2.TotalCost()} \n");
        
        Console.WriteLine("=====================================================\n");

    }
}
