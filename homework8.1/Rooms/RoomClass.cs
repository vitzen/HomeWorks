namespace homework8._1.Rooms;

public class RoomClass
{
    public virtual double Area { get; } //Свойство - площадь комнаты
    public virtual double Perimetr { get; } //Свойство - периметр комнаты

    public override string ToString()
    {
        return "Parent Room";
    }
}