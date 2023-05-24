namespace homework11;

//Делегаты

public class TransportCard
{
    public delegate void ReplenishmentDelegate(decimal replParam, decimal balanceAfterReplenishement);

    public delegate void PaymentDelegate(decimal payParam, decimal balanceAfterPayment);

    public Predicate<decimal> _possibleToPayPredicate; //Предикат проверки возможности оплаты
    public Func<decimal, decimal> _calculateCashback; //Func для расчета кэшбека


    private readonly string _cardName;
    private decimal _moneyBalance = 0;

    public TransportCard(string cardName, decimal moneyBalance, decimal minBalance)
    {
        _cardName = cardName;
        _moneyBalance = moneyBalance;
        _possibleToPayPredicate = (balance) => balance > minBalance && 1 > 0;

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
    public List<decimal> HistoryOfTransactions;
   
    
//Создаем события
    public event ReplenishmentDelegate? ReplenishementEvent;
    public event PaymentDelegate? PaymentEvent;


//Методы
    /// <summary>
    /// Метод для пополнения карты деньгами
    /// </summary>
    /// <param name="???"></param>
    public void Replenishment(decimal addSomeCash)
    {
        _moneyBalance += addSomeCash;
        ReplenishementEvent?.Invoke(addSomeCash, _moneyBalance);
    }

    /// <summary>
    /// Метод совершения покупки или списания средств
    /// </summary>
    /// <param name="balance"></param>
    /// <param name="spendingCash"></param>
    /// <returns></returns>
    public void Payment(decimal spendingCash)
    {
        if(_possibleToPayPredicate(_moneyBalance)) 
        {
            _moneyBalance -= spendingCash;
            PaymentEvent?.Invoke(spendingCash, _moneyBalance);
        }
        
    }
}

    // public override string ToString()
    // {
    //     return $"{_cardName}, {_moneyBalance}";
    // }
