namespace homework12;

public static class AddExtraCashback
{
    /// <summary>
    /// Расширяющий метод: если баланс карты больше 500 рублей,
    /// то вовращается на баланс сумма равная стоимости одной поездки
    /// </summary>
    /// <param name="transportCard"></param>
    /// <param name="replenishSizeForExtraCashback"></param>
    public static decimal AddSuperCashback(this TransportCard transportCard, decimal moneyBalance)
    {
        if (moneyBalance > 500)
        {
            return TransportCard.ExtraCashback;
        }

        return 0;
    }
}