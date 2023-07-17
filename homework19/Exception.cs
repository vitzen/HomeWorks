namespace homework19;

public class LowBalanceException : Exception
{
    //Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
    
    public override string ToString()
    {
        return $"ДЕНЕГ НЕТ, НО ВЫ ДЕРЖИТЕСЬ!!!";
    }
}