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

    public virtual string StartCleaning(RoomClass targetRoom, SuperVacuum targetVacuum)
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
    public string CalculateMaxDustVolumeOfRoom(RoomClass targetRoom, SuperVacuum targetVacuum)
    {
        var maxDustVolumeOfRoom = (targetRoom.Perimetr * 18) / targetRoom.Area;
        if (maxDustVolumeOfRoom > Double.MaxValue)
        {
            throw new Exception("Объема резервуара не достаточно чтобы убрать эту комнату!!!");
        }

        return $"В комнате: {targetRoom} максимальный объем пыли равен: {maxDustVolumeOfRoom} куб/м.\t\n" +
               $"Максимальный лимит объема резервуара для сбора пыли у пылесоса {targetVacuum}: {_maxVolume}куб/м\t\n" +
               $"Объема резервуара пылесоса достаточно для работы с этой комнатой\n";
    }
}