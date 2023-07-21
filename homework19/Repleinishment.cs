namespace homework19;

public partial class TransportCard
{
    /// <summary>
    /// Метод для пополнения карты деньгами
    /// </summary>
    /// <param name="???"></param>
    public void Replenishment(decimal addSomeCash)
    {
        if (_moneyBalance < _maximalBalance)
        {
            _moneyBalance += addSomeCash;

            if (_moneyBalance < _maximalBalance)
            {
                decimal cashbackAmount = _calculateCashback(_moneyBalance);
                _moneyBalance += cashbackAmount;

                this.AddSuperCashback(); //Вызываем метод расширения

                ReplenishementEvent?.Invoke(addSomeCash,
                    _moneyBalance,
                    cashbackAmount);
            }
            else
            {
                throw new Exception($"Превышен максимальный лимит вместимости карты" +
                                    $"Карта не может быть пополнена больше чем на {_maximalBalance} рублей");
            }
        }
        else
        {
            throw new Exception($"Превышен максимальный лимит вместимоти карты" +
                                $"{_moneyBalance} рублей");
        }
    }
}