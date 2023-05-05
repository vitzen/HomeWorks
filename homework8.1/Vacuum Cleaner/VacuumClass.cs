namespace homework8._1.Vacuum_Cleaner;

public class VacuumClass
{
    private string _model;

    public VacuumClass(string model)
    {
        _model = model;
    }

    public string Model
    {
        get { return _model; }
        set { _model = value; }
    }

    
    
    public virtual void StartCleaning()
    {
        Console.WriteLine("Началась уборка");
    }
}
