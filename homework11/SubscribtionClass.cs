namespace homework11;

public class SubscribtionClass //: EventArgs
{
    //Обработчик пополнения баланса
    public static void ReplenishmentSubscription(decimal replparam, decimal newBalance)
    {
        Console.WriteLine($"Пополнение вашего баланса на {replparam} рублей выполнено успешно!\n" +
                          $"Баланс вашей карты составляет: {newBalance} рублей");
    }

    //Обработчик снятия денег
    public static void PaymentSubscription(decimal payparam, decimal newBalance)
    {
        Console.WriteLine($"Совершена оплата проезда в размере {payparam} рублей!\n" +
                          $"Баланс вашей карты составляет: {newBalance} рублей\n ");
    }
}