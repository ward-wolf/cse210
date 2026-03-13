// Address class that includes the street address, city, state/province, and country. 

// Steve Ward CSE210 March 13, 2026

using System;

class Address
{

    // Create private member variables

    private string _StreetAddress;
    private string _City;
    private string _StateProvince;
    private string _Country;
    private Boolean _IsUSAddress;

    // Create constructor

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        _StreetAddress = streetAddress;
        _City = city;
        _StateProvince = stateProvince;
        _Country = country;
        _IsUSAddress = false;
    }

    // Method to return the address

    public string GetAddress()
    {
        string fullAddress = $"{_StreetAddress}\n{_City}, {_StateProvince}\n{_Country}";
        return fullAddress;
    }

    // Method to determine if the address is in the US or not.

    public Boolean IsUSAddress()
    {
        if (_Country == "United States" || _Country == "USA" || _Country == "US")
        {
            _IsUSAddress = true;
        }
        return _IsUSAddress;
    }
}
