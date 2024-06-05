using System;

public class Swimming : Activity 
{
    private float _laps;

    public Swimming()
    {

    }

    public Swimming(float laps, int year, int month, int day, float lenght): base(year, month, day, lenght)
    {
        _laps = laps;
    }

    public override float GetDistance()
    {
        return _laps * 50 / 1000;
    }

    public override float GetSpeed()
    {
        return GetDistance() * 60 / GetLenght();
    }

    public override float GetPace()
    {
        return GetLenght() / GetDistance();
    }

     public override string GetActivity()
    {
        return "Swimming";
    }
}