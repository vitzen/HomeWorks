namespace homework6._8;

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
    public int[] CalculateMethod(int[] array_B)
    {
        int indexOfNewArray = 0;
        int newArrayElementsCount = 0;


        for (int i = 0;
             i < array_B.Length;
             i++) //Цикл подсчета количества положительных элементов в новом массиве
        {
            if (array_B[i] > 0)
            {
                newArrayElementsCount++;
            }
        }

        int[] array_C =
            new int[newArrayElementsCount]; //Инициализация нового массива с новым количеством элементов
        for (int j = 0; j < array_B.Length; j++) //Цикл для заполнения нового массива положительными элементами
        {
            int currentNumber = array_B[j];
            if (currentNumber > 0)
            {
                array_C[indexOfNewArray++] = currentNumber;
            }
        }

        return array_C;
    }

    /// Метод для вывода решения
    public void PrintResultMethod(int[] printResult)
    {
        Console.WriteLine($"Элементы нового массива: {string.Join(" ", printResult)}");
    }
}