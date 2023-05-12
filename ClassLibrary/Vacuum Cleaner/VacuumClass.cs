using System.Collections.Generic;
using ClassLibrary.Rooms;

namespace ClassLibrary.Vacuum_Cleaner;

public class VacuumClass<T>: SuperVacuum
{
    public VacuumClass(double maxVolume, T model) : base(maxVolume, model)
    {
    }

    public override T Model { get; set; }
    public override double MaxVolume { get; set; }


    //////////////////////////////////////////////////////////////////////////////////////////////////////////
    public override void StartCleaning()
    {
        Console.WriteLine("Началась уборка");
    }

    public override string StartCleaning(RoomClass targetRoom)
    {
        return $"Началась уборка в комнате: {targetRoom}";
    }
}