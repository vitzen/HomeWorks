using System.Collections.Generic;
using ClassLibrary.Rooms;

namespace ClassLibrary.Vacuum_Cleaner;

public class WhashingVacuum : VacuumClass<int>
{
    public WhashingVacuum(double maxVolume, int model) : base(maxVolume, model)
    {
    }

    public override string Model
    {
        get => 1599702178;
        set => _model = value;
    }

    public override double MaxVolume { get; set; }

    


///////////////////////////////////////////////////////////////////////////////////////////////////////////////
    public override string StartCleaning(RoomClass targetRoom)
    {
        return $"{Model}, {base.StartCleaning(targetRoom)}";
    }
}