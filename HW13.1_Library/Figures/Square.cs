namespace HW13._1_Library.Figures;

[AuthorAttribute("Vitalii Zenkov", "29.05.2023")]
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


    public IFigures.ColorState GetColorOfCSquare
    {
        get { return _mySquareColor; }
        set { _mySquareColor = value; }
    }


    /// <summary>
    /// Переопределяем физическое свойство Площадь из интерфейса IPhysical
    /// </summary>
    public double Area
    {
        get { return Math.Pow(_sideLength, 2); }
    }

    /// <summary>
    /// Переопределяем физическое свойство Периметр из интерфейса IPhysical
    /// </summary>
    public double Perimetr
    {
        get { return _sideLength * 4; }
    }

    /// <summary>
    /// Переопределяем описательное свойство из интерфейса IDescriptive
    /// </summary>
    public string GetTitle
    {
        get { return _name; }
    }


    /// <summary>
    /// Переопределение ToString
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return $"Name: {_name}, " +
               $"SideLength: {_sideLength}, " +
               $"MySquareColor: {_mySquareColor}\t" +
               $"|||\t" +
               $"Area: {Area:F}\t" +
               $"Perimetr: {Perimetr:F}";
    }
}