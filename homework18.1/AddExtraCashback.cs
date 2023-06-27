namespace homework18._1;

public static class AddExtraCashback
{
    /// <summary>
    /// Расширяющий метод: если баланс карты больше 500 рублей,
    /// то вовращается на баланс сумма равная стоимости одной поездки
    /// </summary>
    /// <param name="transportCard"></param>
    /// <param name="replenishSizeForExtraCashback"></param>
    public static void AddSuperCashback(this TransportCard transportCard)
    {
        if (transportCard.MoneyBalance > 500)
        {
            transportCard.MoneyBalance += TransportCard.ExtraCashback;
            Console.WriteLine("Вы получили бесплатную поездку в транспорте");
        }
    }

    public static string AddNewNotification(this string str)
    {
        return str + "!!!";
    }
    
}