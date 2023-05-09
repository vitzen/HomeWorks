namespace homework9._1;

public class Square : IFigures
{
    private readonly string _name = "mySquare";
    private double _sideLength;
    private IFigures.ColorState _mySquareColor;

    public Square(double sideLength, IFigures.ColorState mySquareColor)
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

    public IFigures.ColorState GetColorOfCSquare
    {
        get { return _mySquareColor; }
        set { _mySquareColor = value; }
    }

    /// <summary>
    /// Переопределение ToString
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return $"Name: {_name}, SideLength: {_sideLength}, MySquareColor: {_mySquareColor}";
    }

    public double Area { get; set; }
    public double Perimetr { get; set; }
}