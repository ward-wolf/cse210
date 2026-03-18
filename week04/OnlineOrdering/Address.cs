// Address class that includes the street address, city, state/province, and country. 

// Steve Ward CSE210 March 13, 2026

using System;

class Address
{

    // Create private member variables

    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;
    private Boolean _isUSAddress;

    // Create constructor

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
        _isUSAddress = false;
    }

    // Method to return the address

    public string GetAddress()
    {
        string fullAddress = $"{_streetAddress}\n{_city}, {_stateProvince}\n{_country}";
        return fullAddress;
    }

    // Method to determine if the address is in the US or not.

    public Boolean IsUSAddress()
    {
        if (_country == "United States" || _country == "USA" || _country == "US")
        {
            _isUSAddress = true;
        }
        return _isUSAddress;
    }
}
