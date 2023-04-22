namespace homework6._10;

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

    public int[] CalculateMethod(int countOfArray)
    {
        int[] fibonachyArray = new int[countOfArray];

        for (int i = 0; i < fibonachyArray.Length; i++)
        {
            if (i == 0)
            {
                fibonachyArray[i] = 0;
            }
            else if (i == 1)

            {
                fibonachyArray[i] = 1;
            }
            else
            {
                fibonachyArray[i] = fibonachyArray[i - 1] + fibonachyArray[i - 2];
            }
        }

        return fibonachyArray;
    }

    /// Метод для вывода решения
    public void PrintResultMethod(int[] newArray)
    {
        Console.WriteLine($"Ряд чисел Фибоначчи начиная с нуля --> {String.Join(" | ", newArray)}");
    }
}