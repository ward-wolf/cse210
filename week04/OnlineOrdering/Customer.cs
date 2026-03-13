// A Customer class which includes a name and an address

// Steve Ward CSE210 March 13, 2026

using System;

class Customer
{

    // Create private member variables

    private string _Name;
    private Address _Address;

    // Create constructor

    public Customer(string name, Address address)
    {
        _Name = name;
        _Address = address;
    }

    // Methods to return name and address

    public string GetName()
    {
        return _Name;
    }

    public Address GetAddress()
    {
        return _Address;
    }

    // Method to determine if the address is in the US or not.

    public Boolean IsUSAddress()
    {
        return _Address.IsUSAddress();
    }

}