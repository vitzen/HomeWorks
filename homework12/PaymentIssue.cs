namespace homework12;

public static class PaymentIssue
{
    public static void PaymentIssueExtended(this string str, decimal paymentLowBalance)
    {
        Console.WriteLine($"{str} " +
                          $"Баланс вашей карты составляет: " +
                          $"{paymentLowBalance} рублей, пополните счет\n");
    }
}