using System;
using System.IO;
using System.Text;

public class Journal
{
    public List<Entry> _entries;

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    
    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile()
    {
        Console.Write("Enter a filename: ");
        string file = Console.ReadLine();

        if (!file.EndsWith(".csv"))
        {
            file += ".csv";
        }

        StringBuilder content = new StringBuilder();
        foreach (var entry in _entries)
        {
            content.AppendLine($"{entry._date},{entry._promptText},{entry._entryText}");
        }
        File.WriteAllText(file, content.ToString());
    }

    public void LoadFromFile()
    {
        string file;
        while (true)
        {
            Console.Write("Enter a filename to load: ");
            file = Console.ReadLine();

            if (!file.EndsWith(".csv"))
            {
                file += ".csv";
            }

            if (File.Exists(file))
            {
                break;
            }
            else
            {
                Console.WriteLine($"File {file} does not exist. Please enter a valid filename.");
            }
        }

        string[] lines = File.ReadAllLines(file);

        Console.WriteLine("");
        foreach (var line in lines)
        {
            Console.WriteLine(line);
        }

        _entries = new List<Entry>();
        foreach (var line in lines)
        {
            string[] fields = line.Split(',');
            if (fields.Length >= 3)
            {
                _entries.Add(new Entry(fields[0], fields[1], fields[2]));
            }
        }
    }

}

