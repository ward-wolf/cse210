// A Product class that contains the nme, product ID, price, and quantity of each product

// Steve Ward CSE210 March 13, 2026

using System;

class Product
{

    // Create private member variables

    private string _name;
    private string _productID;
    private double _price;
    private int _quantity;

    // Create constructor

    public Product(string name, string productID, double price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    // Methods to return each variable

    public string GetName()
    {
        return _name;
    }   

    public string GetProductID()
    {
        return _productID;
    }

    public double GetPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    // Method to find total cost

    public double GetTotalCost()
    {
        return _price * _quantity;
    }
}