using System;

public class Address
{
    private string _streetAddress;
    private string _city;

    private string _stateOrProvince;
    private string _country;

// Method returns true of the country is in the USA
    public bool IsUSA()
    {
        if(_country.ToLower() == "usa")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

// Method returns the full address in a string
    public string FullAddress()
    {
        string fullAddress = $"{_streetAddress} \n{_city}, {_stateOrProvince} {_country}";
        return fullAddress;
    }

    public Address(string street, string city, string state, string country)
    {
        _streetAddress = street;
        _city = city;
        _stateOrProvince = state;
        _country = country;
    }
    public Address()
    {
        _city = "";
        _country = "";
        _streetAddress = "";
        _stateOrProvince = "";
    }

    public void SetAddress(string street, string city, string state, string country)
    {
        _streetAddress = street;
        _city = city;
        _stateOrProvince = state;
        _country = country;
    }

    
}