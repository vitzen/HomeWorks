using NewClassLibrary.Rooms;

namespace NewClassLibrary.Vacuum_Cleaner;

public class SuperVacuum
{
    protected string _model;
    private double _maxVolume; //поле максимальный объем

    public SuperVacuum(double maxVolume, string model) //конструктор
    {
        _maxVolume = maxVolume;
        _model = model;
    }

    public virtual string Model //свойство для поля _model
    {
        get => _model;
        set => _model = value;
    }

    public virtual double MaxVolume //свойство для поля _model
    {
        get => _maxVolume;
        set => _maxVolume = value;
    }

    public virtual void StartCleaning()
    {
        Console.WriteLine("Началась уборка");
    }

    public virtual string StartCleaning(RoomClass targetRoom)
    {
        return $"Началась уборка в комнате: {targetRoom}";
    }

    /// <summary>
    /// Метод для подсчета максимального количества в комнате пыли (в зависимости от комнаты)
    /// </summary>
    /// <param name="targetRoom"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public string CalculateMaxDustVolumeOfRoom(RoomClass targetRoom, SuperVacuum targetVacuum)
    {
        var maxDustVolumeOfRoom = (targetRoom.Perimetr * 18) / targetRoom.Area;
        if (maxDustVolumeOfRoom > _maxVolume)
        {
            throw new Exception("Объема резервуара не достаточно чтобы убрать эту комнату!!!");
        }

        return $"В комнате: {targetRoom} максимальный объем пыли равен: {maxDustVolumeOfRoom} куб/м.\t\n" +
               $"Максимальный лимит объема резервуара для сбора пыли у пылесоса {targetVacuum}: {_maxVolume}куб/м\t\n" +
               $"Объема резервуара пылесоса достаточно для работы с этой комнатой\n";
    }

    public override string ToString()
    {
        return $"*{Model}*";
    }
}