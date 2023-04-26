namespace homework7._2;

public class Triangle : Figures
{
    private readonly string _name = "myTriangle";
    private double _baseSideOfTriangle;
    private double _secondSideOfTriangle;
    private double _thirdSideOfTriangle;
    private double _perpendicular;


    public Triangle(double baseSideOfTriangle, double secondSideOfTriangle, double thirdSideOfTriangle,
        double perpendicular)
    {
        _baseSideOfTriangle = baseSideOfTriangle;
        _secondSideOfTriangle = secondSideOfTriangle;
        _thirdSideOfTriangle = thirdSideOfTriangle;
        _perpendicular = perpendicular;
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
}