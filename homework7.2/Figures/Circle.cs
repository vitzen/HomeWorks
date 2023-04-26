namespace homework7._2;

public class Circle : Figures
{
    private readonly string _name = "myCircle";
    private double _radius;
    private double _diametr;

    public Circle(double radius, double diametr)
    {
        _radius = radius;
        _diametr = diametr;
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
}