namespace homework6._4;

public class MyMethodsClass
{
    // Метод, отвечающий за ввод строки с клавиатуры от пользователя,
    // и осуществляющий дальнейший парсинг в int число
    public int InputArrayCountMethod()
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
    public int[] InputArrayElementsMethod(int number)
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
    public int CalculateMethod(int[] newArray)
    {
        int sumOfArrayElements = newArray.Sum();
        return sumOfArrayElements;
    }

    // Метод для вывода решения
    public void PrintResultMethod(int[] newArray, int sumOfArrayElements)
    {
        Console.WriteLine($"Элементы вашего массива: {string.Join(" ", newArray)}");
        Console.WriteLine($"Сумма всех элементов в массиве равна = {sumOfArrayElements} ");
    }
}