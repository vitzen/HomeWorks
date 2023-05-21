namespace homework11;

public class Subscribe
{
    public static string ReplenishmentNotifications(decimal newReplenishment)
    {
        return $"Пополнение вашего баланса на {newReplenishment} сделано успешно !!!";
    }

    public static string PaymentNotifications(decimal moneyBalance, decimal newPayment)
    {
        return $"Совершена оплата в размере {newPayment} рублей !!!\n " +
               $"Ваш баланс {moneyBalance} ";
    }
}