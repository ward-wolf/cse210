// A Product class that contains the nme, product ID, price, and quantity of each product

// Steve Ward CSE210 March 13, 2026

using System;

class Product
{

    // Create private member variables

    private string _Name;
    private string _ProductID;
    private double _Price;
    private int _Quantity;

    // Create constructor

    public Product(string name, string productID, double price, int quantity)
    {
        _Name = name;
        _ProductID = productID;
        _Price = price;
        _Quantity = quantity;
    }

    // Methods to return each variable

    public string GetName()
    {
        return _Name;
    }   

    public string GetProductID()
    {
        return _ProductID;
    }

    public double GetPrice()
    {
        return _Price;
    }

    public int GetQuantity()
    {
        return _Quantity;
    }

    // Method to find total cost

    public double GetTotalCost()
    {
        return _Price * _Quantity;
    }
}