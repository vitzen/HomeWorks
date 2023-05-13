using NewClassLibrary.Rooms;

namespace NewClassLibrary.Vacuum_Cleaner;

public class RoboticVacuum : VacuumClass<string>
{
    public RoboticVacuum(string model, double maxVolume) : base(model, maxVolume)
    {
    }

    public override string Model
    {
        get => "Robotic Vacuum Xiaomi CZ18";
        set => _model = value;
    }

    public override double MaxVolume { get; set; }
}