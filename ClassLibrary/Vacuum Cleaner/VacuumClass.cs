using System.Collections.Generic;
using ClassLibrary.Rooms;

namespace ClassLibrary.Vacuum_Cleaner;

public class VacuumClass<T> : SuperVacuum
{
    protected T _model;
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
    
    public override string ToString()
    {
        return $"{_model}";
    }
}