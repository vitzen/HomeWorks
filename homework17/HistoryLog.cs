namespace homework17;

public static class HistoryLog
{
    //Создаем историю платежей
    public static List<decimal> historyOfTransactions = new List<decimal>(); 
    
    /// <summary>
    /// Метод записи в историю платежей
    /// </summary>
    /// <param name="spendingcash"></param>
    public static void WritePaymentHistory(decimal spendingcash)
    {
        lock (Program._sync)
        {
            historyOfTransactions.Add(spendingcash);
        }
    }
    
    /// <summary>
    /// Метод чтения из истории платежей
    /// </summary>
    public static void ReadPaymentHystory()
    {
        lock (Program._sync)
        {
            historyOfTransactions.ToList();
        }
    }

    // public static void WritePaymentHistory(object? obj)
    // {
    //     historyOfTransactions.Add(spendingcash);
    // }
}

public class A
{
    
}