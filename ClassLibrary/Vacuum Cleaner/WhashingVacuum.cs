using ClassLibrary.Rooms;

namespace ClassLibrary.Vacuum_Cleaner;

public class WhashingVacuum : VacuumClass<int>
{
    public WhashingVacuum(int model, double maxVolume) : base(model, maxVolume)
    {
    }

    public override int Model
    {
        get => 1599702178;
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