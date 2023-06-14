namespace homework17;

public partial class TransportCard
{
    public delegate void _addPaymentIntoHystory();

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
            Console.WriteLine($"Недостаточно денег для оплаты проезда, " +
                              $"так как баланс вашей карты составляет: " +
                              $"{_moneyBalance} рублей");
        }

        void AddPaymentIntoHystoryList()
        {
            lock (Program._sync)
            {
                historyOfTransactions.Add(spendingCash);
            }
        }
    }
}