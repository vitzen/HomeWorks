using homework8._1.Rooms;

namespace homework8._1.Vacuum_Cleaner;

public class ManualVacuum : VacuumClass
{
    public override string Model { get; set; }
    public override void StartCleaning(RoomClass targetRoom)
    {
        base.StartCleaning(targetRoom);
    }
}