namespace homework11;

public static class SubscribtionClass
{
    public static string ReplenishmentSubscription(decimal replparam)
    {
        return $"Пополнение вашего баланса на {replparam} сделано успешно !!!\n";
        //$"Баланс вашей карты составляет: {moneyBalance}";
    }

    public static string PaymentSubscription(decimal payparam)
    {
        return $"Совершена оплата в размере {payparam} рублей !!!\n ";
        //$"Баланс вашей карты составляет: {moneyBalance} ";
    }

    public static string PossibleToPayPredicate(decimal param)
    {
        return $"Невозможно оплатить проезд, так как денег на вашем балансе недостаточно\n";
        //$"Баланс вашей карты составляет: {moneyBalance} ";
    }
}