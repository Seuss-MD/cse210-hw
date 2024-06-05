using System;

public class Lectures : Event 
{
    private string _speaker;
    private int _capacity;

    public Lectures(string speaker, int capacity, string title, string description, string date, string time) : base(title, description, date, time)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetInformation()
    {
        return($"Speaker: {_speaker} - Capacity: {_capacity} places");
    }

    public void GetFullInformation()
    {
        Console.WriteLine($"\nType of Event: Lectures");
        Console.WriteLine(GetInformation());
        Console.WriteLine(GetStandardDetails());
    }
}