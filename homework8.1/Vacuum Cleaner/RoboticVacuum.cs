using homework8._1.Rooms;

namespace homework8._1.Vacuum_Cleaner;

public class RoboticVacuum : VacuumClass
{
    public override string Model
    {
        get => "Robotic Vacuum Xiaomi CZ18";
    }

    public RoboticVacuum(string model) : base(model)
    {
    }

    public override void StartCleaning()
    {
        base.StartCleaning();
    }

    public override string StartCleaning(RoomClass targetRoom)
    {
        return $"{Model}, {base.StartCleaning(targetRoom)}";
    }
}