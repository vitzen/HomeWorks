using homework8._1.Rooms;

namespace homework8._1.Vacuum_Cleaner;

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

    public override void StartCleaning(RoomClass targetRoom)
    {
        base.StartCleaning(targetRoom);
    }
}