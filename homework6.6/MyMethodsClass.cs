namespace homework6._6;

public class MyMethodsClass
{
    /// Метод парсинга размера массива
    public int InputArrayCountMethod(string inputFromConsole)
    {
        bool consoleInput = Int32.TryParse(inputFromConsole, out int arrayElementsCount);
        if (!consoleInput)
        {
            Console.WriteLine($"Введите корректное значение");
        }

        return arrayElementsCount;
    }

    /// Метод парсинга вводимых значений эелемнтов массива
    public int InputArrayElementsMethod(string number)
    {
        bool numberInput = Int32.TryParse(number, out int num);
        if (!numberInput)
        {
            Console.WriteLine($"Введите корректное значение");
        }

        return num;
    }

    /// Метод для решения арифметических задач
    public int CalculateMethod(int[] newArray)
    {
        int minNumber = newArray[0];
        for (int i = 1; i < newArray.Length; i++)
        {
            if (newArray[i] < minNumber)
            {
                minNumber = newArray[i];
            }
        }

        return minNumber;
    }

    /// Метод для вывода решения
    public void PrintResultMethod(int[] newArray, int result)
    {
        Console.WriteLine($"Элементы вашего массива: {string.Join(" ", newArray)}");
        Console.WriteLine($"Наименьший элемент в массиве равен = {result} ");
    }
}