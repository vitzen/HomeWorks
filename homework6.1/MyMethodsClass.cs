using System.ComponentModel.Design.Serialization;

namespace homework6._1;

public class MyMethodsClass
{
    /// Метод, осуществляющий парсинг символа от пользователя
    public int GetIntFromInput()
    {
        bool inputFromUser = false;
        int nElement = 0;

        do
        {
            Console.WriteLine("Введите n-ый элемент для вычисления его в ряду Фибоначчи");
            string inputSymbol = Console.ReadLine();
            bool input = Int32.TryParse(inputSymbol, out int outputElement);
            if (input == false)
            {
                Console.WriteLine("Введенное вами число с клавиатуры неверно, попробуйте заново");
            }
            else
            {
                nElement = outputElement;
                inputFromUser = true;
                break;
            }
        } while (inputFromUser == false);

        return nElement;
    }


    /// Алгоритм поиска n-т-ого элемента в ряду Фибоначчи
    public static int Fibonachi(int n)
    {
        int result;
        if (n == 0 || n == 1)
        {
            return n;
        }

        result = Fibonachi(n - 1) + Fibonachi(n - 2);
        return result;
    }


    /// Метод для вывода на консоль
    public static void Print(int fibonachResult)
    {
        Console.WriteLine($"n-ое число Фибоначчи = {fibonachResult}");
    }
}