using System;
using System.Dynamic;
using System.Runtime.CompilerServices;

public class Customer
{
    private string _name;
    private Address _address = new Address();

    public bool USA(Address a)
    {
        if (a.IsUSA() == true)
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }

    public string GetName()
    {
        return _name;
    }
    public Address GetAddress()
    {
        return _address;
    }

    public Customer(string name)
    {
        _name = name;
    }

    public void SetAddress(Address address)
    {
        _address = address;
    }
    
}