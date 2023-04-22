namespace homework6._5;

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
    public double CalculateMethod(int[] newArray, int inputElementsCount)
    {
        double result = (double)(newArray.Sum()) / inputElementsCount;
        return result;
    }

    /// Метод для вывода решения
    public void PrintResultMethod(int[] newArray, double result)
    {
        Console.WriteLine($"Элементы вашего массива: {string.Join(" ", newArray)}");
        Console.WriteLine($"Среднее арифметическое2 всех элементов в массиве равна = {result} ");
    }
}