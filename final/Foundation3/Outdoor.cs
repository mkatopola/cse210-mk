using System;


class Outdoor : Event
{
    private string _weather;


    public Outdoor(string weather, string title, string description, string date, string time, Address address) : base(title, description, date, time, address)
    {
        _weather = weather;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _eventType = "Outdoor";
    }

    public string FullDetails()
    {
        return $"Event: {_eventType}\nTitle: {_title}\nWeather: {_weather}\nDescription: {_description}\ndate: {_date}\nTime: {_time}\nAddress: {_address.GetAddress()}";
    }















}