using ClassLibrary.Rooms;

namespace ClassLibrary.Vacuum_Cleaner;

public class ManualVacuum : VacuumClass
{
    public override string Model
    {
        get => "Manual Vacuum Toshiba XN-145";
    }

    public ManualVacuum(string model) : base(model)
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