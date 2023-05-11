using homework8._1.Rooms;

namespace homework8._1.Vacuum_Cleaner;

public class ManualVacuum : VacuumClass
{
    public override string Model
    {
        get => "Manual Vacuum Toshiba XN-145";
    }

    public ManualVacuum(string model) : base(model)
    {
    }

    /// <summary>
    /// Реализация сокрытия метода по условию домашенго задания!!!
    /// На практике быть с этим нужно осторожно, так как в коде потом сложно будет отловить ошибку,
    /// почему метод вызывает неправильный параметр
    /// </summary>
    /// <param name="targetRoom"></param>
    /// <returns></returns>
    public string StartCleaning(RoomClass targetRoom)
    {
        return $"{Model}, {base.StartCleaning(targetRoom)}";
    }
}