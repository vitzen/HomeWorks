namespace homework18._1;

public partial class TransportCard
{
    /// <summary>
    /// Метод для пополнения карты деньгами
    /// </summary>
    /// <param name="???"></param>
    public void Replenishment(decimal addSomeCash)
    {
        _moneyBalance += addSomeCash;
        decimal cashbackAmount = _calculateCashback(_moneyBalance);
        _moneyBalance += cashbackAmount;

        this.AddSuperCashback(); //Вызываем метод расширения

        ReplenishementEvent?.Invoke(addSomeCash,
            _moneyBalance,
            cashbackAmount);
    }
}