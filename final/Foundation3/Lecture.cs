using System;


class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string speaker, int capacity, string title, string description, string date, string time, Address address) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _eventType = "Lecture";
    }

    public string FullDetails()
    {
        return $"Event: {_eventType}\nTitle: {_title}\nSpeaker: {_speaker}\nCapacity: {_capacity}\nDescription: {_description}\ndate: {_date}\nTime: {_time}\nAddress: {_address.GetAddress()}";
    }
} 
