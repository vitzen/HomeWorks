namespace homework6._11;

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
    public static (int, int) CalculateMethod(int[] newArray)
    {
        int[] evenOddArray = newArray;
        int evenCounter = 0;
        int oddCounter = 0;
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


    // Метод для вывода решения
    public static void PrintResultMethod(int even, int odd)
    {
        Console.WriteLine($"Количество Четных чисел вашего массива: {even}");
        Console.WriteLine($"Количество Нечетных чисел вашего массива: {odd}");
    }
}