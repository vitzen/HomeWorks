namespace homework6._9;

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
    public (int, int[]) CalculateMethod(int[] newArray, int myCount)
    {
        //var myArray = newArray;
        int countOfEasyNumbers = myCount;


        for (int i = 0; i < newArray.Length; i++)
        {
            if (newArray[i] == 0 || newArray[i] == 1)
            {
                countOfEasyNumbers--;
            }

            else if (newArray[i] > 1)
            {
                for (int j = 2; j < newArray[i]; j++)
                {
                    if (newArray[i] % j == 0)
                    {
                        countOfEasyNumbers--;
                        break;
                    }
                }
            }
        }

        return (countOfEasyNumbers, newArray);
    }

    /// Метод для вывода решения
    public void PrintResultMethod(int counter, int[] ourArray)
    {
        Console.WriteLine($"Элементы вашего массива: {string.Join(" ", ourArray)}");
        Console.WriteLine($"Количество простых чисел в массиве = {counter} ");
    }
}