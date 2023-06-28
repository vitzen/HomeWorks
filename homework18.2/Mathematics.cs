namespace homework18._2;

class Mathematics
{
    /// <summary>
    /// Метод получения массива из рандомных чисел
    /// </summary>
    /// <returns></returns>
    public static int[] GetCollectionOfNumbers(int newArrayLength)
    {
        Random random = new Random(100);
        var collectionOfNumbers = new int[newArrayLength];
        for (int i = 0; i < newArrayLength; i++)
        {
            collectionOfNumbers[i] = random.Next(1, 7);
        }

        return collectionOfNumbers;
    }

    /// <summary>
    /// метод расчета факториала числа
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public static int GetFactorialFromNumbers(int number)
    {
        if (number == 1) return 1;

        return number * GetFactorialFromNumbers(number - 1);
    }
}