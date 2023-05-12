using System.Collections.Generic;
using ClassLibrary.Rooms;

namespace ClassLibrary.Vacuum_Cleaner;

public class VacuumClass : SuperVacuum
{
    public VacuumClass(double maxVolume, string model) : base(maxVolume, model)
    {
    }

    public override string Model { get; set; }
    public override double MaxVolume { get; set; }

    public override void StartCleaning()
    {
        Console.WriteLine("Началась уборка");
    }

    public override string StartCleaning(RoomClass targetRoom)
    {
        return $"Началась уборка в комнате: {targetRoom}";
    }
}