using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    // Add a constructor to parse the date and remove the time
    public Entry(string date, string promptText, string entryText)
    {
        DateTime parsedDate;
        if (DateTime.TryParse(date, out parsedDate))
        {
            // Store the date as a string in the format "yyyy-MM-dd"
            _date = parsedDate.ToString("yyyy-MM-dd");
        }
        else
        {
            _date = date;
        }

        _promptText = promptText;
        _entryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine(_entryText);
    }
}
