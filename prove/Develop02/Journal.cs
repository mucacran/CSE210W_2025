using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry.GetDetails() + "\n");
        }
    }

    public void SaveEntries(){
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                string prompt = entry._prompt;
                string text = entry._text;
                string date = entry._date.ToShortDateString();

                //writer.WriteLine(entry.GetDetails());
                writer.WriteLine($"{date}~~{prompt}~~{text}");
            }
        }
    }

    public void LoadEntries(){
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();

        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] part = line.Split("~~");
                Entry newEntry = new Entry();

                newEntry._date = DateTime.Parse(part[0]);
                newEntry._prompt = part[1];
                newEntry._text = part[2];

                _entries.Add(newEntry);
            }
        }
    }

    public void RemoveEntry(int index)
    {
        if (index >= 0 && index < _entries.Count)
        {
            _entries.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("Índice no válido.");
        }
    }
}