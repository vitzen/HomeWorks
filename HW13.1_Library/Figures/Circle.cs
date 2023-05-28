namespace HW13._1_Library.Figures;

public class Circle : IFigures
{
    private readonly string _name = "myCircle";
    private double _radius;
    private double _diametr;
    private IFigures.ColorState _myCircleColor;

    public Circle(double radius, double diametr, IFigures.ColorState myCircleColor)
    {
        _radius = radius;
        _diametr = diametr;
        _myCircleColor = myCircleColor;
    }


    public IFigures.ColorState GetColorOfCircle
    {
        get { return _myCircleColor; }
        set { _myCircleColor = value; }
    }

    /// <summary>
    /// Переопределяем физическое свойство Площадь из интерфейса IPhysical
    /// </summary>
    public double Area
    {
        get { return 2 * Math.PI * _radius; }
    }

    /// <summary>
    /// Переопределяем физическое свойство Периметр из интерфейса IPhysical
    /// </summary>
    public double Perimetr
    {
        get { return Math.PI * Math.Pow(_radius, 2); }
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
               $"Radius: {_radius}, " +
               $"Diametr: {_diametr}, " +
               $"MyCircleColor: {_myCircleColor}\t" +
               $"|||\t" +
               $"Area: {Area:F}\t" +
               $"Perimetr: {Perimetr:F}";
    }
}