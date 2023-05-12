using NewClassLibrary.Rooms;

namespace NewClassLibrary.Vacuum_Cleaner;

public class SuperVacuum
{
    public virtual void StartCleaning()
    {
        Console.WriteLine("Началась уборка");
    }

    public virtual string StartCleaning(RoomClass targetRoom, SuperVacuum targetVacuum)
    {
        return $"Пылесос: {targetVacuum} начал уборку в комнате: {targetRoom}";
    }
    
    // public override string ToString()
    // {
    //     return $"*{targetRoom}*";
    // }
}