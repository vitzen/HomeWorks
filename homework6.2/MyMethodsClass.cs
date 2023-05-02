namespace homework6._2;

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
            Console.WriteLine("Введите количество чисел");
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

    // Метод парсинга вводимых значений элемнтов массива
    public static int[] InputArrayElementsMethod(int elementsNumber)
    {
        int[] myArray = new int[elementsNumber];
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
    public (int, int) CalculateMethod(int[] newArray)
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
    public void PrintResultMethod(double even, double odd)
    {
        Console.WriteLine($"Четные числа вашего массива: {even}");
        Console.WriteLine($"Нечетные числа вашего массива: {odd}");
    }
}