using System;

public class Running : Activity 
{
    private float _distance;

    public Running()
    {

    }

    public Running(float distance, int year, int month, int day, float lenght): base(year, month, day, lenght)
    {
        _distance = distance;
    }

    public override float GetSpeed()
    {
        return _distance *60 / GetLenght();
    }

    public override float GetPace()
    {
        return GetLenght() / _distance;
    }

    public override float GetDistance()
    {
        return _distance;
    }

    public override string GetActivity()
    {
        return "Running";
    }
}