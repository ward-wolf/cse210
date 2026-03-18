// An Order class contains the list of products and a customer. Includes a method to find the total
// cost of the order, a method to create a packing label, and a method to create a shipping label.

// Steve Ward CSE210 March 13, 2026

using System;

class Order
{

    // Create private member variables

    private List<Product> _products;
    private Customer _customer;

    // Create constructor

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    // Method to add product

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }   

    // Method to find total cost

    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.GetTotalCost();
        }
        if (_customer.IsUSAddress())
        {
            totalCost += 5;
        }   
        else
        {
            totalCost += 35;
        }

        return totalCost;
    }

    // Method to create the packing label

    public string CreatePackingLabel()
    {
        string packingLabel = "";  
        packingLabel += "Products:\n";
        foreach (Product product in _products)
        {
            packingLabel += product.GetName();
            packingLabel += " - ";
            packingLabel += product.GetProductID();
            packingLabel += "\n";
        }
        return packingLabel;
    }

    // Method to create the shipping label

    public string CreateShippingLabel()
    {
        string shippingLabel = "";
        shippingLabel += _customer.GetName();
        shippingLabel += "\n";
        shippingLabel += _customer.GetAddress().GetAddress();
        shippingLabel += "\n";

        return shippingLabel;
    }

    // Methods to display the packing and shipping labels

    public void DisplayPackingLabel()
    {
        Console.WriteLine(CreatePackingLabel());
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine(CreateShippingLabel());
    }
}