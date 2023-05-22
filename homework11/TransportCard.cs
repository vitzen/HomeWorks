namespace homework11;

public class TransportCard
{
    private string _cardName;
    private decimal _moneyBalance = 0;

    public TransportCard(string cardName, decimal moneyBalance)
    {
        _cardName = cardName;
        _moneyBalance = moneyBalance;
    }

    public string CardName
    {
        get => _cardName;
        set => _cardName = value;
    }

    public decimal MoneyBalance
    {
        get => _moneyBalance;
        set => _moneyBalance = value;
    }

    ///////////////////////////////////////////////////////////////////
//События
    public event Program.ReplenishmentDelegate? ReplenishementEvent;
    public event Program.PaymentDelegate? PaymentEvent;

    ///////////////////////////////////////////////////////////////////

    /// <summary>
    /// Метод для пополнения карты деньгами
    /// </summary>
    /// <param name="???"></param>
    public void Replenishment(decimal addSomeCash)
    {
        _moneyBalance += addSomeCash;
        ReplenishementEvent.Invoke(_moneyBalance);
    }

    /// <summary>
    /// Метод совершения покупки или списания средств
    /// </summary>
    /// <param name="balance"></param>
    /// <param name="spendingCash"></param>
    /// <returns></returns>
    public void Payment(decimal spendingCash)
    {
        _moneyBalance -= spendingCash;
        PaymentEvent.Invoke(_moneyBalance);
    }


    public override string ToString()
    {
        return $"{_cardName}, {_moneyBalance}";
    }
}