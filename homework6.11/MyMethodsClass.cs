namespace homework6._11;

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
    public (double, double) CalculateMethod(double[] newArray)
    {
        double[] evenOddArray = newArray;
        double evenCounter = 0;
        double oddCounter = 0;
        for (int i = 0; i < evenOddArray.Length; i++)
        {
            if (evenOddArray[i] > 0 && (evenOddArray[i] % 2 == 0))
            {
                evenCounter++;
            }
            else if ((evenOddArray[i] > 0 && (evenOddArray[i] % 2 == 1)))

            {
                oddCounter++;
            }
        }

        return (evenCounter, oddCounter);
    }


    /// Метод для вывода решения
    public void PrintResultMethod(double even, double odd)
    {
        Console.WriteLine($"Количество Четных чисел вашего массива: {even}");
        Console.WriteLine($"Количество Нечетных чисел вашего массива: {odd}");
    }
}