using System;
using System.Globalization;

/* There is no Exceeding Requirements, but I've added the price of the unit and
    the quantity of each product in the packing label.
*/
class Program
{
    static void Main(string[] args)
    {
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
        CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;
    
        Address address1 = new Address("321 Yellow Brick Road", "Neverland", "CA", "USA");
        Customer customer1 = new Customer("Michael Jackson", address1);

        Order order1 = new Order(customer1);

        Product product1 = new Product("1. Rollercoaster", 610, 925545.43, 1);
        Product product2 = new Product("2. Complete Zoo", 202, 58678000.73, 1);
        Product product3 = new Product("3. Watermellon", 501, 35.00, 50);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Console.WriteLine("\nOrder 1:");
        Console.WriteLine($"\nShipping Label: \n{order1.GetShippingLabel()}");
        Console.WriteLine($"\nPacking Label: \n{order1.GetPackingLabel()}");
        Console.WriteLine($"Total: $ {order1.CalculateCustOrder().ToString("0.00")}");
        Console.WriteLine();

        Address address2 = new Address("123 Strawberry Field", "Liverpool", "England", "UK");
        Customer customer2 = new Customer("Eleanor Rigby", address2);

        Order order2 = new Order(customer2);
        
        Product product4 = new Product("1. Jar of Faces", 803, 275.00, 1);
        Product product5 = new Product("2. Bag of Rice", 010, 1.75, 5);
        Product product6 = new Product("3. Church Pew Polish", 301, 1850.00, 30);

        
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        Console.Write("\nOrder 2:");
        Console.WriteLine($"\nShipping Label: \n{order2.GetShippingLabel()}");
        Console.WriteLine($"\nPacking Label: \n{order2.GetPackingLabel()}");
        Console.WriteLine($"Total: $ {order2.CalculateCustOrder().ToString("0.00")}");


    }

}