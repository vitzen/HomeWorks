using System.Collections.Generic;
using ClassLibrary.Rooms;

namespace ClassLibrary.Vacuum_Cleaner;

public class ManualVacuum : VacuumClass<string>
{
    public ManualVacuum(string model, double maxVolume) : base(model, maxVolume)
    {
        MaxVolume = maxVolume;
    }

    public override string Model
    {
        get => "Manual Vacuum Toshiba XN-145";
    }

    public override double MaxVolume { get; set; }

    public override string StartCleaning(RoomClass targetRoom)
    {
        return $"{Model}, {base.StartCleaning(targetRoom)}";
    }
    
    public override string ToString()
    {
        return $"{_model}";
    }
}