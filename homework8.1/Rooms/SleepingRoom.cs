namespace homework8._1.Rooms;

public class SleepingRoom : RoomClass
{
    private double _sleepingRoomLength;
    private double _sleepingRoomWidth;

    public SleepingRoom(double area, double perimetr, double sleepingRoomLength, double sleepingRoomWidth) : base(area,
        perimetr)
    {
        _sleepingRoomLength = sleepingRoomLength;
        _sleepingRoomWidth = sleepingRoomWidth;
    }

    public override double Area
    {
        get => _sleepingRoomLength * _sleepingRoomWidth;
    }

    public override double Perimetr
    {
        get => (2 * _sleepingRoomLength) + (2 * _sleepingRoomWidth);
    }
}