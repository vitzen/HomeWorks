using NewClassLibrary.Rooms;

namespace NewClassLibrary.Vacuum_Cleaner;

public class ManualVacuum : VacuumClass<string>
{
    public ManualVacuum(string model, double maxVolume) : base(model, maxVolume)
    {
    }

    public override string Model
    {
        get => "Manual Vacuum Toshiba XN-145";
        set => _model = value;
    }

    public override double MaxVolume { get; set; }
    
    // public override string StartCleaning(RoomClass targetRoom)
    // {
    //     return $"{Model}, {base.StartCleaning(targetRoom)}";
    // }

    // public override string ToString()
    // {
    //     return $"*{_model}*";
    // }
}