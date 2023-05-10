using ClassLibrary.Rooms;

namespace ClassLibrary.Vacuum_Cleaner;

public class Metla
{
    private double _maxVolume; //поле максимальный объем

    public virtual void StartCleaning()
    {
        Console.WriteLine("Началась уборка");
    }

    public virtual string StartCleaning(RoomClass targetRoom)
    {
        return $"Началась уборка в комнате: {targetRoom}";
    }
    public virtual string CalculateMaxDustVolumeOfRoom(RoomClass targetRoom)
    {
        var maxDustVolumeOfRoom = (targetRoom.Perimetr * 18) / targetRoom.Area;
        if (maxDustVolumeOfRoom > _maxVolume)
        {
            throw new Exception("Ей, остановись, твой пылесос не сможет сожрать столько пыли");
        }
        else
        {
            Console.WriteLine("Все отлично, предельно допустимый объем резервуара для пыли не превышен");
        }

        return "Что будем делать дальше?";
    }
}

public class VacuumClass<T> : Metla
{
    private T _model;
    private double _maxVolume;


    public VacuumClass(T model, double maxVolume)
    {
        _model = model;
        _maxVolume = maxVolume;
    }

    public virtual T Model
    {
        get => _model;
    }

    //Максимальный объем пыли, обрабатываемый пылесосом
    public virtual double MaxVolume
    {
        get { return _maxVolume; }
        set => _maxVolume = value;
    }


    public override void StartCleaning()
    {
        Console.WriteLine("Началась уборка");
    }

    public override string StartCleaning(RoomClass targetRoom)
    {
        return $"Началась уборка в комнате: {targetRoom}";
    }

    /// <summary>
    /// Метод для подсчета максимального объема пыли в комнате
    /// </summary>
    /// <returns></returns>
    public override string CalculateMaxDustVolumeOfRoom(RoomClass targetRoom)
    {
        var maxDustVolumeOfRoom = (targetRoom.Perimetr * 18) / targetRoom.Area;
        if (maxDustVolumeOfRoom > _maxVolume)
        {
            throw new Exception("Ей, остановись, твой пылесос не сможет сожрать столько пыли");
        }
        else
        {
            Console.WriteLine("Все отлично, предельно допустимый объем резервуара для пыли не превышен");
        }

        return "Что будем делать дальше?";
    }

    // public override string ToString()
    // {
    //     return $"{_model}, {CalculateMaxDustVolumeOfRoom()}";
    // }
}