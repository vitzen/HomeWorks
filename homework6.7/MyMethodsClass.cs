namespace homework6._7;

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
        int sum = 0;
        for (int j = 0; j < newArray.Length; j++)
        {
            if (newArray[j] % 2 == 0)
            {
                sum += newArray[j];
            }
        }

        return sum;
    }

    /// Метод для вывода решения
    public void PrintResultMethod(int[] newArray, int finishResult)
    {
        Console.WriteLine($"Элементы вашего массива: {string.Join(" ", newArray)}");
        Console.WriteLine($"Сумма четных лементов массива равна = {finishResult} ");
    }
}