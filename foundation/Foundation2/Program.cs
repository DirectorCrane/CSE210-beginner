using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");
        
        Address address1 = new Address ("123 Epsilon St","SaltLake", "UTAH", "USA");
       Address address2 = new Address ("5th Ave","SaintPeter", "Toronto", "Canada");
       
       
        Customer customer1 = new Customer ("Peter James", address1);
        Customer customer2 = new Customer ("Luke Izaaks", address2);

        Product product1 = new Product("iPhone 20 Pro Max", "IP20", 2499m, 3);
        Product product2 = new Product("PlayStation 5", "PS5", 2499m, 3);
        Product product3 = new Product("Samsung A32", "A32", 199m, 1);
        Product product4 = new Product("Apple Watch", "AW", 150, 2);



        List<Product> products1 = new List<Product>{product1, product2 };
        Order order1 = new Order (customer1, products1);
        List<Product> products2 = new List<Product>{product3, product4 };
        Order order2 = new Order (customer2, products2);

        Console.WriteLine("Order 1: ");
   
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price:${order1.CalculateTotalPrice()}\n ");

          Console.WriteLine("Order 2: ");
   
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price:${order2.CalculateTotalPrice()}\n ");
        
   
   
   
   
   
   
    }

}