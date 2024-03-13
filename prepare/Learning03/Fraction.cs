



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


    public void setTop(int top)
    {
        _top = top;
    }

    public void setBottom(int bottom)
    {
        _bottom = bottom;
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
    {   /*
        string numerator = GetTop().ToString();
        string denominator = GetBottom().ToString();

        return $"{numerator}/{denominator}"; */

        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }





}