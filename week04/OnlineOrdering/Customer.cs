// A Customer class which includes a name and an address

// Steve Ward CSE210 March 13, 2026

using System;

class Customer
{

    // Create private member variables

    private string _name;
    private Address _address;

    // Create constructor

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Methods to return name and address

    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }

    // Method to determine if the address is in the US or not.

    public Boolean IsUSAddress()
    {
        return _address.IsUSAddress();
    }

}