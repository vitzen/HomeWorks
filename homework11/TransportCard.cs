using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Collections.Generic;

namespace homework11;

//Делегаты

public class TransportCard
{
    public delegate void ReplenishmentDelegate(decimal replParam,
        decimal balanceAfterReplenishement, decimal balanceAfterCashbackGift);

    public delegate void PaymentDelegate(decimal payParam, decimal balanceAfterPayment);

    public Predicate<decimal> _possibleToPayPredicate; //Предикат проверки возможности оплаты
    public Func<decimal, decimal> _calculateCashback; //Func для расчета кэшбека при каждом пополнении карты

    private readonly string _cardName;
    private decimal _moneyBalance = 0;

    public TransportCard(string cardName, decimal moneyBalance, decimal minBalance, decimal calculateCashback)
    {
        _cardName = cardName;
        _moneyBalance = moneyBalance;
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

    public static List<decimal> historyOfTransactions = new List<decimal>(); //Создаем историю платежей

    public static List<decimal> HistoryOfTransactions
    {
        get => historyOfTransactions;
        set => historyOfTransactions = value ?? throw new ArgumentNullException(nameof(value));
    }

//Создаем события
    public event ReplenishmentDelegate? ReplenishementEvent;
    public event PaymentDelegate? PaymentEvent;

    /// <summary>
    /// Метод для пополнения карты деньгами
    /// </summary>
    /// <param name="???"></param>
    public void Replenishment(decimal addSomeCash)
    {
        _moneyBalance += addSomeCash;
        decimal cashbackAmount = _calculateCashback(_moneyBalance);
        _moneyBalance += cashbackAmount;

        ReplenishementEvent?.Invoke(addSomeCash,
            _moneyBalance,
            cashbackAmount);
    }

    /// <summary>
    /// Метод совершения покупки или списания средств
    /// </summary>
    /// <param name="balance"></param>
    /// <param name="spendingCash"></param>
    /// <returns></returns>
    public void Payment(decimal spendingCash)
    {
        if (_possibleToPayPredicate(_moneyBalance))
        {
            _moneyBalance -= spendingCash;
            PaymentEvent?.Invoke(spendingCash, _moneyBalance);
        }
        else
        {
            Console.WriteLine($"Недостаточно денег для оплаты проезда, так как баланс вашей карты составляет: " +
                              $"{_moneyBalance} рублей");
        }

        historyOfTransactions.Add(spendingCash);
    }

    public override string ToString()
    {
        return $"{historyOfTransactions}";
    }
}