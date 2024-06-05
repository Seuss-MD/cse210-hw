using System;

public abstract class Activity 
{

        private DateTime _date;
        private float _lenght;


    public Activity()
    {

    }

    public Activity(int year, int month, int day, float lenght)
    {
        _date = new DateTime(year, month, day);

        _lenght = lenght;
    }
    public abstract float GetDistance();

    public abstract float GetSpeed();

    public abstract float GetPace();

    public string GetSummary()
    {
    
        return($"Date: {GetDate()} - {GetActivity()} ({Math.Round(GetLenght(),2)} min) - Distance: {Math.Round(GetDistance(), 2)} kilometers, Speed: {Math.Round(GetSpeed(),2)}km/hour, Pace: {Math.Round(GetPace(),2)} min/km.");
    
    }

    public float GetLenght()
    {
        return _lenght;
    }

    public string GetDate()
    {   
        DateTime dateOnly = _date.Date;
        return dateOnly.ToString("dd/MM/yyyy");
    }

    public abstract string GetActivity();

}