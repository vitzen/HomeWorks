namespace homework18._1;

public class SubscribtionClass
{
    //Обработчик пополнения баланса
    public static void ReplenishmentSubscription(decimal replparam, decimal newBalance, decimal cashback)
    {
        Console.WriteLine($"Пополнение вашего баланса на {replparam} рублей выполнено успешно!\n" +
                          $"Вам начислен кэшбэк за пополнение в размере: {cashback} рублей\n" +
                          $"Баланс вашей карты составляет: {newBalance} рублей\n");
    }

    //Обработчик снятия денег
    public static void PaymentSubscription(decimal payparam, decimal newBalance)
    {
        Console.WriteLine($"Совершена оплата проезда в размере {payparam} рублей!\n" +
                          $"Баланс вашей карты составляет: {newBalance} рублей\n");
    }
}