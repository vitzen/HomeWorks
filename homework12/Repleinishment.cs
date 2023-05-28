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
        decimal cashbackAmount = _calculateCashback(_moneyBalance);
        _moneyBalance += cashbackAmount;

        //Вызов метода для получения супер кэшбэка
        var superCashback = AddExtraCashback.AddSuperCashback(_moneyBalance); 
        _moneyBalance += superCashback;

        ReplenishementEvent?.Invoke(addSomeCash,
            _moneyBalance,
            cashbackAmount);
    }
}