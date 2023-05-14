using NewClassLibrary.Rooms;


namespace NewClassLibrary.Vacuum_Cleaner;

public class VacuumClass<T> : SuperVacuum
{
    protected T _model;
    private double _maxVolume; //поле максимальный объем

    public VacuumClass(T model, double maxVolume)
    {
        _model = model;
        _maxVolume = maxVolume;
    }

    public virtual T Model
    {
        get => _model;
        set => _model = value;
    }

    public virtual double MaxVolume
    {
        get => _maxVolume;
        set => _maxVolume = value;
    }

    public override string CalculateMaxDustVolumeOfRoom(RoomClass targetRoom, SuperVacuum targetVacuum)
    {
        var maxDustVolumeOfRoom = (targetRoom.Perimetr * 18) / targetRoom.Area;

        if (!(maxDustVolumeOfRoom > _maxVolume))
        {
            throw new OutOfDustVolumeException(Model);
        }

        return $"В комнате: {targetRoom} максимальный объем пыли равен: {maxDustVolumeOfRoom} куб/м.\t\n" +
               $"Максимальный лимит объема резервуара для сбора пыли у пылесоса {targetVacuum}: {_maxVolume}куб/м\t\n" +
               $"Объема резервуара пылесоса достаточно для работы с этой комнатой\n";
    }
}