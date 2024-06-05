using System;

public class Cycling : Activity 
{

    private float _speed;

    public Cycling()
    {

    }

    public Cycling(float speed, int year, int month, int day, float lenght): base(year, month, day, lenght)
    {
        _speed = speed;

    }

    public override float GetDistance()
    {
        return _speed * GetLenght()/60;
    }

    public override float GetPace()
    {
        return GetLenght()/ GetDistance();
    }

    public override float GetSpeed()
    {
        return _speed;
    }
    public override string GetActivity()
    {
        return "Cycling";
    }   

}