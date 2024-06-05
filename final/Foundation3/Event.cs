using System;

public class Event 
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address = new Address();

    public Event(string title, string description, string date, string time)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
       

    }

    public string GetStandardDetails()
    {
        return($"Event: {_title}\nDescription:{_description} - Date/time : {_date} - {_time}\n{_address.GetAddress()}");

    }

    public string GetShortDescription()
    {
        return($"Event: {_title} - Date:{_date}");
    }

    public void GetEventType(Event type)
    {
        Console.WriteLine("The type of Event  {0}" , type.GetType());
    }

    public void SetAddress(string address, string city, string state, string country)
    {
        _address.SetAddress(address, city, state, country);
    }

    

}