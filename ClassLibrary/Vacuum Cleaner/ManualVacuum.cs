using ClassLibrary.Rooms;

namespace ClassLibrary.Vacuum_Cleaner;

public class ManualVacuum : VacuumClass<string>
{
    public ManualVacuum(string model, double maxVolume) : base(model, maxVolume)
    {
    }

    public override string Model
    {
        get => "Manual Vacuum Toshiba XN-145";
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

public class T
{
}