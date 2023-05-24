namespace homework11;

public class SubscribtionClass// : EventArgs
{
    public static string ReplenishmentSubscription(decimal replparam) //Обработчик пополнения баланса
    {
        return $"Пополнение вашего баланса на {replparam} сделано успешно !!!\n";
        //$"Баланс вашей карты составляет: {moneyBalance}";
    }

    public static string PaymentSubscription(decimal payparam) //Обработчик снятия денег
    {
        return $"Совершена оплата в размере {payparam} рублей !!!\n ";
        //$"Баланс вашей карты составляет: {moneyBalance} ";
    }

    public static string PossibleToPayPredicate(decimal param) //Обработчик нехватки денег для оплаты
    {
        return $"Невозможно оплатить проезд, так как денег на вашем балансе недостаточно\n";
        //$"Баланс вашей карты составляет: {moneyBalance} ";
    }
}