namespace homework6._9;

public class MyMethodsClass
{
    // Метод, отвечающий за ввод строки с клавиатуры от пользователя,
    // и осуществляющий дальнейший парсинг в int число
    public static int InputArrayCountMethod()
    {
        bool inputFromUser = false;
        int arrayElementsCount = 0;

        do
        {
            Console.WriteLine("Введите число (количество элементов) массива");
            string inputSymbol = Console.ReadLine();
            bool input = Int32.TryParse(inputSymbol, out int outputElement);
            if (input == false)
            {
                Console.WriteLine("Введенное вами число с клавиатуры неверно, попробуйте заново");
            }
            else
            {
                arrayElementsCount = outputElement;
                inputFromUser = true;
                break;
            }
        } while (inputFromUser == false);

        return arrayElementsCount;
    }

    // Метод, отвечающий за ввод строки с клавиатуры от пользователя,
    // и осуществляющий дальнейший парсинг в int числа
    // Сбор чисел в массив
    public static int[] InputArrayElementsMethod(int number)
    {
        int[] myArray = new int[number];
        for (int i = 0; i < myArray.Length; i++)
        {
            bool inputFromUser = false;

            do
            {
                Console.WriteLine("Введите целое число");
                string inputSymbol = Console.ReadLine();
                bool input = Int32.TryParse(inputSymbol, out int outputElement);
                if (input == false)
                {
                    Console.WriteLine("Введенное вами число с клавиатуры неверно, попробуйте заново");
                }
                else
                {
                    myArray[i] = outputElement;
                    inputFromUser = true;
                    break;
                }
            } while (inputFromUser == false);
        }

        return myArray;
    }

    // Метод для решения арифметических задач
    public static (int, int[]) CalculateMethod(int[] newArray, int myCount)
    {
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

    // Метод для вывода решения
    public static void PrintResultMethod(int counter, int[] ourArray)
    {
        Console.WriteLine($"Элементы вашего массива: {string.Join(" ", ourArray)}\n");
        Console.WriteLine($"Количество простых чисел равно: {counter}");
    }
}