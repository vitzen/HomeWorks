using NewClassLibrary.Rooms;

namespace NewClassLibrary.Vacuum_Cleaner;

public class SuperVacuum
{
    private double _maxVolume;

    public double MaxVolume
    {
        get => _maxVolume;
        set => _maxVolume = value;
    }

    public virtual void StartCleaning()
    {
        Console.WriteLine("Началась уборка");
    }

    public string StartCleaning(RoomClass targetRoom, SuperVacuum targetVacuum)
    {
        return $"Пылесос: {targetVacuum} начал уборку в комнате: {targetRoom}";
    }

    /// <summary>
    /// Метод для подсчета вместимости пылесоса в зависимости от комнаты.
    /// Если не выполняются требования по вместимости бросать EXCEPTION
    /// </summary>
    /// <param name="targetRoom"></param>
    /// <param name="targetVacuum"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public virtual string CalculateMaxDustVolumeOfRoom(RoomClass targetRoom, SuperVacuum targetVacuum)
    {
        return $"";
    }
}