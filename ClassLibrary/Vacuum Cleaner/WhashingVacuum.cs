using ClassLibrary.Rooms;

namespace ClassLibrary.Vacuum_Cleaner;

public class WhashingVacuum : VacuumClass
{
    public WhashingVacuum(string model, double maxVolume) : base(model, maxVolume)
    {
    }

    public override string Model
    {
        get => "Washing Vacuum Panasonic rz246";
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