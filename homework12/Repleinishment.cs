namespace homework12;

public partial class TransportCard
{
    /// <summary>
    /// Метод для пополнения карты деньгами
    /// </summary>
    /// <param name="???"></param>
    public void Replenishment(decimal addSomeCash)
    {
        _moneyBalance += addSomeCash;
        _moneyBalance = ReplenishmentExtensionClass.ReplenishmentExtensionMethod(addSomeCash);
        decimal cashbackAmount = _calculateCashback(_moneyBalance);
        _moneyBalance += cashbackAmount;

        ReplenishementEvent?.Invoke(addSomeCash,
            _moneyBalance,
            cashbackAmount);
    }
}