namespace homework6._10;

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
            Console.WriteLine("Введите число (количество элементов) ряда Фибоначчи");
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

    // Метод арифметических операций
    public static int[] CalculateMethod(int countOfArray)
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

    // Метод для вывода решения
    public static void PrintResultMethod(int[] newArray)
    {
        Console.WriteLine($"Ряд чисел Фибоначчи начиная с нуля --> {String.Join(" | ", newArray)}");
    }
}