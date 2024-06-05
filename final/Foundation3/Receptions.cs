using System;

public class Receptions : Event
{
    private string _email;

    public Receptions(string email, string title, string description, string date, string time) : base(title, description, date, time)
    {
        _email = email;
    }

    public string GetEmail()
    {
        return _email;
    }

     public void GetFullInformation()
    {
        Console.WriteLine($"\nType of Event: Receptions");
        Console.WriteLine($"RVSP email:{GetEmail()}");
        Console.WriteLine(GetStandardDetails());
    }
}