namespace homework8._1.Rooms;

//Класс, который описывает кухонную комнату, имеющую форму квадрата
public class KitchenRoom : RoomClass
{
    private readonly string _nameOfRoom = "Kitchen Room";
    private double _kitchenRoomSide; //Сторона комнаты

    public KitchenRoom(double kitchenRoomSide)
    {
        _kitchenRoomSide = kitchenRoomSide;
    }

    public string Model //Свойство - получить название комнаты
    {
        get => _nameOfRoom;
    }

    public double KitchenRoomSide
    {
        get => _kitchenRoomSide;
        set => _kitchenRoomSide = value;
    }

    public override double Area
    {
        get => Math.Pow(_kitchenRoomSide, 2);
    }

    public override double Perimetr
    {
        get => 4 * _kitchenRoomSide;
    }

    public override string ToString()
    {
        return _nameOfRoom;
    }
}