namespace homework7._2;

public class Circle : Figures
{
    private readonly string _name = "myCircle";
    private double _radius;
    private double _diametr;
    private ColorState _myCircleColor;

    public Circle(double radius, double diametr, ColorState myCircleColor)
    {
        _radius = radius;
        _diametr = diametr;
        _myCircleColor = myCircleColor;
    }

    public string GetCircleName
    {
        get { return _name; }
    }

    public double GetLengthOfCircle
    {
        get { return 2 * Math.PI * _radius; }
        set { _radius = value; }
    }

    public ColorState GetColorOfCircle
    {
        get { return _myCircleColor; }
        set { _myCircleColor = value; }
    }
}