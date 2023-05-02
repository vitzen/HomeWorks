namespace homework6._8;

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
    public static int[] CalculateMethod(int[] array_B)
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

    // Метод для вывода решения
    public static void PrintResultMethod(int[] printResult)
    {
        Console.WriteLine($"Элементы нового массива: {string.Join(" ", printResult)}");
    }
}