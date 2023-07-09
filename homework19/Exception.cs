namespace homework19;

public class BalanceRangeException : Exception
{
    private decimal _modelVacuum;

    public BalanceRangeException(decimal modelVacuum)
    {
        _modelVacuum = modelVacuum;
    }

    public override string ToString()
    {
        return $"У пылесоса: {_modelVacuum} объема резервуара не достаточно чтобы убрать эту комнату!!!";
    }
}