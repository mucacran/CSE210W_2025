using System;

class Entry
{
    public string _prompt { get; set; }
    public string _text { get; set; }
    public DateTime _date { get; set; }

    public Entry(){
    }

    public Entry(string prompt, string text)
    {
        _prompt = prompt;
        _text = text;
        _date = DateTime.Now; // The current date is assigned
    }

    public string GetDetails()
    {
        return $"Date: {_date.ToShortDateString()} - Prompt: {_prompt}\n{_text}";
    }
}