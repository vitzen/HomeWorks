namespace homework12;

// Создаем экстеншен класс для обработчика ReplenishmentSubscription
public static class ReplenishmentExtensionClass
{
    public static decimal ReplenishmentExtensionMethod(this decimal replenishmentAmount)
    {
        decimal oneDriveAsGift = 30M; // Подарок размере одного бесплатного проезда на транспорте
        
        
        if (replenishmentAmount > extraReplenishmentAmount)
        {
            return replenishmentAmount + oneDriveAsGift;
        }

        return replenishmentAmount;
    }
}