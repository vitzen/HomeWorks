namespace homework11;

public class SubscribtionClass //: EventArgs
{
    //Обработчик пополнения баланса
    public static void ReplenishmentSubscription(decimal replparam, decimal newBalance)
    {
        Console.WriteLine($"Пополнение вашего баланса на {replparam} сделано успешно !!!\n" +
                          $"Баланс вашей карты составляет: {newBalance}");
    }

    //Обработчик снятия денег
    public static void PaymentSubscription(decimal payparam, decimal newBalance)
    {
        Console.WriteLine($"Совершена оплата в размере {payparam} рублей !!!\n " +
                          $"Баланс вашей карты составляет: {newBalance} ");
    }

    // public static string
    //     PossibleToPayPredicate(decimal param, decimal newBalance) //Обработчик нехватки денег для оплаты
    // {
    //     return
    //         $"Невозможно оплатить проезд, так как денег на вашем балансе недостаточно\n" +
    //         $"Баланс вашей карты составляет: {newBalance} ";
    // }
}