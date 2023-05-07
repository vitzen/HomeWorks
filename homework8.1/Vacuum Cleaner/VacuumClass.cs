using homework8._1.Rooms;

namespace homework8._1.Vacuum_Cleaner;

public class VacuumClass
{
    private string _model;

    public VacuumClass(string model)
    {
        _model = model;
    }

    public virtual string Model
    {
        get => _model;
    }

    public virtual void StartCleaning()
    {
        Console.WriteLine("Началась уборка");
    }

    public virtual void StartCleaning(RoomClass targetRoom)
    {
        Console.WriteLine($"Началась уборка в комнате: {targetRoom}");
    }

    // public void GetModel()
    // {
    //     ToString();
    // }
}