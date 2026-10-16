using System.Runtime.CompilerServices;

public class Fraction
{
    private int _top;
    private int _bottom;

    //initializes the numbers to 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    // changes whole number to x/1
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    // //two parameters
    public Fraction(int top, int bottom)
    {
        _top = top;
        SetBottom(bottom);
    }
    public void SetBottom(int bottom)
    {
        if (bottom != 0)
            {_bottom = bottom;}
        else 
            {_bottom = 1;}    
    }
    public void SetTop(int top)
    {
        _top = top;
    }
    public int GetTop()
    {
        return _top;
    }
    public int GetBottom()
    {
        return _bottom;
    }
    public string GetFractionString()
    {
        string fractionText = $"{_top}/{_bottom}";
        return fractionText;
    }
    public double GetDecimalValue()
    {
        return (double)_top/(double)_bottom;
    }
}

