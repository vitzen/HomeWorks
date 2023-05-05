namespace homework8._1.Rooms;

public class RoomClass
{
    private double _area;
    private double _perimetr;
    

    public RoomClass(double area, double perimetr)
    {
        _area = area;
        _perimetr = perimetr;
    }

    public virtual double Area
    {
        get => _area;
        set => _area = value;
    }

    public virtual double Perimetr
    {
        get => _perimetr;
        set => _perimetr = value;
    }

    
    
}


