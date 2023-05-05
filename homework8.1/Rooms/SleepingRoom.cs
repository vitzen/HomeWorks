namespace homework8._1.Rooms;

//Класс, который описывает спальную комнату, имеющую форму прямоугольника
public class SleepingRoom : RoomClass
{
    private double _sleepingRoomLength; //Длина комнаты
    private double _sleepingRoomWidth; //Ширина комнаты

    public SleepingRoom(double sleepingRoomLength, double sleepingRoomWidth)
    {
        _sleepingRoomLength = sleepingRoomLength;
        _sleepingRoomWidth = sleepingRoomWidth;
    }

    public double SleepingRoomLength
    {
        get => _sleepingRoomLength;
        set => _sleepingRoomLength = value;
    }

    public double SleepingRoomWidth
    {
        get => _sleepingRoomWidth;
        set => _sleepingRoomWidth = value;
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