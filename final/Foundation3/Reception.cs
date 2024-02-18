using System;


class Receptions : Event
{
    private string _email;

    public Receptions(string email, string title, string description, string date, string time, Address address) : base(title, description, date, time, address)
    {
        _email = email;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _eventType = "Reception";
    }

    public string FullDetails()
    {
        return $"Event: {_eventType}\nTitle: {_title}\nRSVP Email: {_email}\nDescription: {_description}\ndate: {_date}\nTime: {_time}\nAddress: {_address.GetAddress()}";
    }
} 
