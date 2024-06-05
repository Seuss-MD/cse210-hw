using System;

public class Outdoor : Event
{
    private string _statement;


    public Outdoor(string statement, string title, string description, string date, string time) : base(title, description, date, time)
    {
        _statement = statement;
    }

    public string GetStatement()
    {
        return _statement;
    }

     public void GetFullInformation()
    {
        Console.WriteLine($"\nType of Event: Outdoor");
        Console.WriteLine($"Forecast:{GetStatement()}");
        Console.WriteLine(GetStandardDetails());
    }
}