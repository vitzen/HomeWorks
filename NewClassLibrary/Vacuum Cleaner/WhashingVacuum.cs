using NewClassLibrary.Rooms;

namespace NewClassLibrary.Vacuum_Cleaner;

public class WhashingVacuum : VacuumClass<int>
{
    public WhashingVacuum(int model, double maxVolume) : base(model, maxVolume)
    {
    }

    public override int Model
    {
        get => 19826432;
        set => _model = value;
    }

    public override double MaxVolume { get; set; }
    
    // public override string StartCleaning(RoomClass targetRoom)
    // {
    //     return $"{Model}, {base.StartCleaning(targetRoom)}";
    // }
}