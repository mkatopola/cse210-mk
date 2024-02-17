using System;


class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUSA()
    {
        if (_country.ToUpper() == "USA" || _country.ToUpper() == "UNITED STATES")
        {
            return true;
        }
        else
            return false;
    }

    public string FullAddress()
    {
        string fullAddress = $"Street : {_street}\nCity : {_city}\nState : {_state}\nCountry : {_country}";
        return fullAddress;
    }
}

