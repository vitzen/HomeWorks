namespace homework17;

public partial class TransportCard
{
    public delegate void ReplenishmentDelegate(decimal replParam,
        decimal balanceAfterReplenishement, decimal balanceAfterCashbackGift);

    public delegate void PaymentDelegate(decimal payParam, decimal balanceAfterPayment);

    //Предикат проверки возможности оплаты
    public Predicate<decimal> _possibleToPayPredicate; 
    
    //Func для расчета кэшбека при каждом пополнении карты
    public Func<decimal, decimal> _calculateCashback; 

    private readonly string _cardName;
    private decimal _moneyBalance = 0;
    private static decimal _extraCashback;

    public TransportCard(string cardName, decimal moneyBalance, decimal minBalance, decimal calculateCashback,
        decimal extraCashback)
    {
        _cardName = cardName;
        _moneyBalance = moneyBalance;
        _extraCashback = extraCashback;
        _possibleToPayPredicate = (balance) => balance > minBalance;
        _calculateCashback = (balance) => { return balance *= calculateCashback; };
    }

    public string CardName
    {
        get => _cardName;
    }

    public decimal MoneyBalance
    {
        get => _moneyBalance;
        set => _moneyBalance = value;
    }

    public static decimal ExtraCashback
    {
        get => _extraCashback;
        set => _extraCashback = value;
    }

    //Создаем события
    public event ReplenishmentDelegate? ReplenishementEvent;
    public event PaymentDelegate? PaymentEvent;

    public override string ToString()
    {
        return $"CardName: {CardName}, MoneyBalance: {MoneyBalance}";
    }
}