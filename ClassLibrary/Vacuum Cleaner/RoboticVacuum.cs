using ClassLibrary.Rooms;

namespace ClassLibrary.Vacuum_Cleaner;

public class RoboticVacuum : VacuumClass<string>
{
    public RoboticVacuum(string model, double maxVolume) : base(model, maxVolume)
    {
    }

    public override string Model
    {
        get => "Robotic Vacuum Xiaomi CZ18";
    }

    public override double MaxVolume { get; set; }

    public override void StartCleaning()
    {
        base.StartCleaning();
    }


    public override string StartCleaning(RoomClass targetRoom)
    {
        return $"{Model}, {base.StartCleaning(targetRoom)}";
    }
}