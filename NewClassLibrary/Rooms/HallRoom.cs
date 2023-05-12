namespace NewClassLibrary.Rooms;

//Класс, который описывает гостинную комнату, имеющую форму прямоугольника
public class HallRoom : RoomClass
{
    private readonly string _nameOfRoom = "Hall Room";
    private double _hallRoomLength; //Длина комнаты
    private double _hallRoomWidth; //Ширина комнаты

    public HallRoom(double hallRoomLength, double hallRoomWidth)
    {
        _hallRoomLength = hallRoomLength;
        _hallRoomWidth = hallRoomWidth;
    }

    public string Model //Свойство - получить название комнаты
    {
        get => _nameOfRoom;
    }

    public double HallRoomLength
    {
        get => _hallRoomLength;
        set => _hallRoomLength = value;
    }

    public double HallRoomWidth
    {
        get => _hallRoomWidth;
        set => _hallRoomWidth = value;
    }

    public override double Area
    {
        get => _hallRoomLength * _hallRoomWidth;
    }

    public override double Perimetr
    {
        get => (2 * _hallRoomLength) + (2 * _hallRoomWidth);
    }

    public override string ToString()
    {
        return _nameOfRoom;
    }
}