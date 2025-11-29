using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Verifica se vive nos EUA chamando o método da classe Address
    public bool LiveInUSA()
    {
        return _address.IsUSA();
    }

    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }
}