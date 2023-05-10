using ClassLibrary.Rooms;

namespace ClassLibrary.Vacuum_Cleaner;

public class VacuumClass
{
    private string _model;
    private double _maxVolume;


    public VacuumClass(string model, double maxVolume)
    {
        _model = model;
        _maxVolume = maxVolume;
    }

    public virtual string Model
    {
        get => _model;
    }

    //Максимальный объем пыли, обрабатываемый пылесосом
    public virtual double MaxVolume
    {
        get { return _maxVolume; }
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
}