namespace homework9._1;

public class Triangle : IFigures
{
    private readonly string _name = "myTriangle";
    private double _baseSideOfTriangle;
    private double _secondSideOfTriangle;
    private double _thirdSideOfTriangle;
    private double _perpendicular;
    private IFigures.ColorState _myTriangleColor;

    public Triangle(double baseSideOfTriangle, double secondSideOfTriangle, double thirdSideOfTriangle,
        double perpendicular, IFigures.ColorState myTriangleColor)
    {
        _baseSideOfTriangle = baseSideOfTriangle;
        _secondSideOfTriangle = secondSideOfTriangle;
        _thirdSideOfTriangle = thirdSideOfTriangle;
        _perpendicular = perpendicular;
        _myTriangleColor = myTriangleColor;
    }

    public string SetTriangleName
    {
        get { return _name; }
    }


    public IFigures.ColorState GetColorOfTriangle
    {
        get { return _myTriangleColor; }
        set { _myTriangleColor = value; }
    }


    /// <summary>
    /// Переопределяем физическое свойство Площадь из интерфейса IPhysical
    /// </summary>
    public double Area
    {
        get { return (_baseSideOfTriangle * _perpendicular / 2); }
    }


    /// <summary>
    /// Переопределяем физическое свойство Периметр из интерфейса IPhysical
    /// </summary>
    public double Perimetr
    {
        get => _baseSideOfTriangle + _secondSideOfTriangle + _thirdSideOfTriangle;
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
        return
            $"Name: {_name}, " +
            $"BaseSideOfTriangle: {_baseSideOfTriangle}, " +
            $"SecondSideOfTriangle: {_secondSideOfTriangle}, " +
            $"ThirdSideOfTriangle: {_thirdSideOfTriangle}, " +
            $"Perpendicular: {_perpendicular}, " +
            $"MyTriangleColor: {_myTriangleColor}\t" +
            $"|||\t" +
            $"Area: {Area:F}\t" +
            $"Perimetr: {Perimetr:F}";
    }
}