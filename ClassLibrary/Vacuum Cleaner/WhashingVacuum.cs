using ClassLibrary.Rooms;

namespace ClassLibrary.Vacuum_Cleaner;

public class WhashingVacuum : VacuumClass
{
    public override string Model
    {
        get => "Washing Vacuum Panasonic rz246";
    }

    public WhashingVacuum(string model) : base(model)
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