// Program to run the OnlineOrdering program. Creates two orders, one for an address in the US 
// and one in the United Arab Emirates. 
// Each order has 3 products.
// Produces the packing label, shipping label, total price of the order including shipping.
// Uses the Order, Product, Customer, and Address classes.

// Steve Ward CSE210 March 13, 2026

using System;

class Program
{
    static void Main(string[] args)
    {

        // Create two orders and display them in the terminal

        Order order1 = new Order(new Customer("Jon Colvin", new Address("123 Main St", "Manti", "UT", "USA")));
        order1.AddProduct(new Product("Milk", "D001", 5.0, 1));
        order1.AddProduct(new Product("Bread", "B001", 4.0, 2));
        order1.AddProduct(new Product("Eggs", "E001", 3.0, 3));

        Console.WriteLine("Order 1 Packing Label:");
        order1.DisplayPackingLabel();
        Console.WriteLine("Order 1 Shipping Label:");
        order1.DisplayShippingLabel();
        Console.WriteLine("Total Cost: $" + order1.GetTotalCost());
        Console.WriteLine();

        Order order2 = new Order(new Customer("Jaron Briggs", new Address("Rolex Tower 42B, Shaikh Zayed Road", "Dubai", "Dubai", "United Arab Emirates")));
        order2.AddProduct(new Product("Chocolate", "C001", 15.0, 1));
        order2.AddProduct(new Product("Dates", "F004", 15.5, 2));
        order2.AddProduct(new Product("Cheese", "D003", 11.0, 3));   

        Console.WriteLine("Order 2 Packing Label:");
        order2.DisplayPackingLabel();
        Console.WriteLine("Order 2 Shipping Label:");
        order2.DisplayShippingLabel();
        Console.WriteLine("Total Cost: $" + order2.GetTotalCost());
    }
}