using static homework11.Notifications;

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
        set => _cardName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public decimal MoneyBalance
    {
        get => _moneyBalance;
        set => _moneyBalance = value;
    }

    /// <summary>
    /// Метод для пополнения карты деньгами
    /// </summary>
    /// <param name="???"></param>
    public string Replenishment(decimal addSomeCash)
    {
        _moneyBalance += addSomeCash;
        return $"{ReplenishmentNotifications(_moneyBalance)}";
    }
    
    /// <summary>
    /// Метод совершения покупки или списания средств
    /// </summary>
    /// <param name="balance"></param>
    /// <param name="spendingCash"></param>
    /// <returns></returns>
    public string Payment(decimal spendingCash)
    {
        _moneyBalance -= spendingCash;
        return $"{PaymentNotifications(_moneyBalance)}";
    }

    public delegate string ReplenishmentDelegate(decimal param);

    public delegate string PaymentDelegate(decimal param);

    public override string ToString()
    {
        return $"{_cardName}, {_moneyBalance}";
    }
}