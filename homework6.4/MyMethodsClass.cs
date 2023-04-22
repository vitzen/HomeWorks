namespace homework6._4;

public class MyMethodsClass
{
    /// Метод парсинга размера массива
    static int InputArrayCountMethod(string inputFromConsole)
    {
        bool consoleInput = Int32.TryParse(inputFromConsole, out int arrayElementsCount);
        if (!consoleInput)
        {
            Console.WriteLine($"Введите корректное значение");
        }

        return arrayElementsCount;
    }

    /// Метод парсинга вводимых значений эелемнтов массива
    static int InputArrayElementsMethod(string number)
    {
        bool numberInput = Int32.TryParse(number, out int num);
        if (!numberInput)
        {
            Console.WriteLine($"Введите корректное значение");
        }

        return num;
    }

    /// Метод для решения арифметических задач
    static int CalculateMethod(int[] newArray)
    {
        int sumOfArrayElements = newArray.Sum();
        return sumOfArrayElements;
    }

    /// Метод для вывода решения
    static void PrintResultMethod(int[] newArray, int sumOfArrayElements)
    {
        Console.WriteLine($"Элементы вашего массива: {string.Join(" ", newArray)}");
        Console.WriteLine($"Сумма всех элементов в массиве равна = {sumOfArrayElements} ");
    }

}