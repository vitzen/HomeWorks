namespace homework6._1;

public class MyMethodsClass
{
    /// Метод, осуществляющий парсинг символа от пользователя
    public void Parsing(string inputFromUser)
    {
        string unknownInput = inputFromUser;
        bool input = Int32.TryParse(unknownInput, out int nElement);
        if (input)
        {
            Print(Fibonachi(nElement));
            ;
        }
        else
        {
            Console.WriteLine("Введите корректное число");
        }
    }


    /// Алгоритм поиска n-т-ого элемента в ряду Фибоначчи
    public int Fibonachi(int n)
    {
        if (n == 0 || n == 1) return n;
        return Fibonachi(n - 1) + Fibonachi(n - 2);
    }


    /// Метод для вывода на консоль
    public void Print(int fibonachResult)
    {
        Console.WriteLine($"n-ое число Фибоначчи = {fibonachResult}");
    }
}