namespace homework7._2;

public class Square : Figures
{
    private readonly string _name = "mySquare";
    private double _sideLength;
    private ColorState _mySquareColor;

    public Square(double sideLength, ColorState mySquareColor)
    {
        _sideLength = sideLength;
        _mySquareColor = mySquareColor;
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

    public ColorState GetColorOfCSquare
    {
        get { return _mySquareColor; }
        set { _mySquareColor = value; }
    }
}