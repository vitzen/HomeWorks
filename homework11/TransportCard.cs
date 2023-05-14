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

    public delegate void OperationStatus(string notification);


    public void Replenishment(amount)
    {
        
    }
}

