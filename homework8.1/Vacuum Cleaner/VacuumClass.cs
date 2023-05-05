namespace homework8._1.Vacuum_Cleaner;

public class VacuumClass
{
    public virtual string Model { get; }


    public virtual void StartCleaning()
    {
        Console.WriteLine("Началась уборка");
    }
}