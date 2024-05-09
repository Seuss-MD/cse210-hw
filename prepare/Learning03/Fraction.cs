using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetTop()
    {
        string top = $"{_top}";
        return top;
    }
    public string GetBottom()
    {
        string bottom = $"{_bottom}";
        return bottom;
    }
    public string GetFraction()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimal()
    {
        return (double)_top/(double)_bottom;
    }

    public void SetTop(int top)
    {
        _top = top;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
    
}