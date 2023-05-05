namespace homework8._1.Rooms;

public class KitchenRoom : RoomClass
{
    private double _kitchenRoomLength;
    private double _kitchenRoomWidth;

    public KitchenRoom(double area, double perimetr, double kitchenRoomLength, double kitchenRoomWidth) : base(area,
        perimetr)
    {
        _kitchenRoomLength = kitchenRoomLength;
        _kitchenRoomWidth = kitchenRoomWidth;
    }

    public override double Area
    {
        get => _kitchenRoomLength * _kitchenRoomWidth;
    }

    public override double Perimetr
    {
        get => (2 * _kitchenRoomLength) + (2 * _kitchenRoomWidth);
    }
}