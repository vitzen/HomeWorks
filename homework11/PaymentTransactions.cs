namespace homework11;

public static class PaymentTransactions
{
    /// <summary>
    /// Метод для пополнения карты деньгами
    /// </summary>
    /// <param name="???"></param>
    public static decimal Replenishment(decimal balance, decimal addSomeCash)
    {
        balance += addSomeCash;
        return balance;
    }

    public static decimal Payment(decimal balance, decimal spendingCash)
    {
        balance -= spendingCash;
        return balance;
    }
    
}