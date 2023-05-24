namespace homework11;

//Делегаты


public class TransportCard
{
    public delegate string ReplenishmentDelegate(decimal replParam);
    public delegate string PaymentDelegate(decimal payParam);

    //public Predicate<decimal> _possibleToPayPredicate;
    
    private readonly string _cardName;
    private decimal _moneyBalance = 0;

    public TransportCard(string cardName, decimal moneyBalance)
    {
        _cardName = cardName;
        _moneyBalance = moneyBalance;
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

//Создаем события
    public event ReplenishmentDelegate? ReplenishementEvent;
    public event PaymentDelegate? PaymentEvent;
    //public event _possibleToPayPredicate? PossibleToPayEvent;

//Методы
    /// <summary>
    /// Метод для пополнения карты деньгами
    /// </summary>
    /// <param name="???"></param>
    public void Replenishment(decimal addSomeCash)
    {
        _moneyBalance += addSomeCash;
        ReplenishementEvent?.Invoke(addSomeCash);
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
        PaymentEvent?.Invoke(spendingCash);
    }

    public override string ToString()
    {
        return $"{_cardName}, {_moneyBalance}";
    }
}