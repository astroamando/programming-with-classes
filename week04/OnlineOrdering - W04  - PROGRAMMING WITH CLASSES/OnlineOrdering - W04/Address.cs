using System;

public class Address
{
    // Atributos privados (Encapsulamento: usar _underscoreCamelCase)
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    // Construtor
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // Método para verificar se está nos EUA
    public bool IsUSA()
    {
        // Retorna verdadeiro se o país for USA (ignorando maiúsculas/minúsculas)
        return _country.Trim().ToLower() == "usa";
    }

    // Método para retornar o endereço completo formatado
    public string GetDisplayText()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}