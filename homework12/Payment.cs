namespace homework12;

public partial class TransportCard
{
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
            PaymentIssue.PaymentIssueExtended($"Недостаточно денег для оплаты проезда ", _moneyBalance);
        }

        historyOfTransactions.Add(spendingCash);
    }
}