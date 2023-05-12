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
    
    public override string ToString()
    {
        return $"*{_model}*";
    }
}