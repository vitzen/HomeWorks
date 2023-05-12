using NewClassLibrary.Rooms;

namespace NewClassLibrary.Vacuum_Cleaner;

public class RoboticVacuum : VacuumClass
{
    public RoboticVacuum(double maxVolume, string model) : base(maxVolume, model)
    {
    }

    public override string Model
    {
        get => "Robotic Vacuum Xiaomi CZ18";
        set => _model = value;
    }

    public override double MaxVolume { get; set; }

    public override string StartCleaning(RoomClass targetRoom)
    {
        return $"{Model}, {base.StartCleaning(targetRoom)}";
    }
}