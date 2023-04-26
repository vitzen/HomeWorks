namespace homework7._2;

public class Square : Figures
{
    private readonly string _name = "mySquare";
    private double _sideLength;

    public Square(double sideLength)
    {
        _sideLength = sideLength;
    }

    public string SetSquareName
    {
        get { return _name; }
    }

    public double GetSquareArea
    {
        get { return Math.Pow(_sideLength, 2); }
        set { _sideLength = value; }
    }
}