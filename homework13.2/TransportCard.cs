namespace homework13._2;

public partial class TransportCard
{
    public delegate void ReplenishmentDelegate(decimal replParam,
        decimal balanceAfterReplenishement, decimal balanceAfterCashbackGift);

    public delegate void PaymentDelegate(decimal payParam, decimal balanceAfterPayment);

    public Predicate<decimal> _possibleToPayPredicate; //Предикат проверки возможности оплаты
    public Func<decimal, decimal> _calculateCashback; //Func для расчета кэшбека при каждом пополнении карты

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

    public static List<decimal> historyOfTransactions = new List<decimal>(); //Создаем историю платежей

    public List<decimal> HistoryOfTransactions
    {
        get => historyOfTransactions;
        set => historyOfTransactions = value ?? throw new ArgumentNullException(nameof(value));
    }

    //Создаем события
    public event ReplenishmentDelegate? ReplenishementEvent;
    public event PaymentDelegate? PaymentEvent;

    protected bool Equals(TransportCard other)
    {
        return _cardName == other._cardName && _moneyBalance == other._moneyBalance;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((TransportCard)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(_cardName, _moneyBalance);
    }

    public override string ToString()
    {
        return $"CardName: {CardName}, MoneyBalance: {MoneyBalance}";
    }
}