namespace homework6._1;

public class MyMethodsClass
{
    /// Метод, осуществляющий парсинг символа от пользователя
    public int Parsing(string inputFromUser)
    {
        string unknownInput = inputFromUser;
        bool a = false;
        bool input = Int32.TryParse(unknownInput, out int nElement);
        int succefulParsingNumber = 0;


        do
        {
            if (input)
            {
                Console.WriteLine("Введите корректное число а не символ");
            }
            else
            {
                succefulParsingNumber = nElement;
                a = true;
            }
        } while (a == false);


        return succefulParsingNumber;
    }


    /// Алгоритм поиска n-т-ого элемента в ряду Фибоначчи
    public static int Fibonachi(int n)
    {
        int result;
        if (n == 0 || n == 1) return n;
        result = Fibonachi(n - 1) + Fibonachi(n - 2);
        return result;
    }


    /// Метод для вывода на консоль
    public static void Print(int fibonachResult)
    {
        Console.WriteLine($"n-ое число Фибоначчи = {fibonachResult}");
    }
}