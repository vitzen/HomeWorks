namespace homework9._1;

public class Triangle : Figures
{
    private readonly string _name = "myTriangle";
    private double _baseSideOfTriangle;
    private double _secondSideOfTriangle;
    private double _thirdSideOfTriangle;
    private double _perpendicular;
    private ColorState _myTriangleColor;

    public Triangle(double baseSideOfTriangle, double secondSideOfTriangle, double thirdSideOfTriangle,
        double perpendicular, ColorState myTriangleColor)
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

    public double GetAreaOfTriangle
    {
        get { return (_baseSideOfTriangle * _perpendicular) / 2; }
        set
        {
            _baseSideOfTriangle = value;
            _perpendicular = value;
        }
    }

    public ColorState GetColorOfTriangle
    {
        get { return _myTriangleColor; }
        set { _myTriangleColor = value; }
    }

    public override string ToString()
    {
        return $"Name: {_name}, BaseSideOfTriangle: {_baseSideOfTriangle}, SecondSideOfTriangle: {_secondSideOfTriangle}, ThirdSideOfTriangle: {_thirdSideOfTriangle}, Perpendicular: {_perpendicular}, MyTriangleColor: {_myTriangleColor}";
    }
}