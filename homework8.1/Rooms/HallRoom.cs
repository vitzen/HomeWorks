namespace homework8._1.Rooms;

public class HallRoom : RoomClass
{
    private double _hallRoomLength;
    private double _hallRoomWidth;

    public HallRoom(double area, double perimetr, double hallRoomLength, double hallRoomWidth) : base(area, perimetr)
    {
        _hallRoomLength = hallRoomLength;
        _hallRoomWidth = hallRoomWidth;
    }
    
    public override double Area
    {
        get => _hallRoomLength * _hallRoomWidth;
    }

    public override double Perimetr
    {
        get => (2 * _hallRoomLength) + (2 * _hallRoomWidth);
    }
}