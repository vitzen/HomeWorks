namespace NewClassLibrary;

public class OutOfDustVolumeException : Exception
{
    private readonly object _modelVacuum;

    public OutOfDustVolumeException(object modelVacuum)
    {
        _modelVacuum = modelVacuum;
    }

    public override string ToString()
    {
        return $"У пылесоса: {_modelVacuum} объема резервуара не достаточно чтобы убрать эту комнату!!!";
    }
}