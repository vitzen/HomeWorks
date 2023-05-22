namespace homework11;

public static class SubscribtionClass
{
    public static string ReplenishmentSubscription(decimal moneyBalance, decimal newReplenishment)
    {
        return $"Пополнение вашего баланса на {newReplenishment} сделано успешно !!!\n" +
               $"Баланс вашей карты составляет: {moneyBalance}";
    }

    public static string PaymentSubscription(decimal moneyBalance, decimal newPayment)
    {
        return $"Совершена оплата в размере {newPayment} рублей !!!\n " +
               $"Баланс вашей карты составляет: {moneyBalance} ";
    }
}