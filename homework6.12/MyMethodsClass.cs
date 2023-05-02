namespace homework6._12;

public class MyMethodsClass
{
    /// Метод для решения арифметических задач
    public static void CalculateMethod()
    {
        int[,] myArray = new int [10, 10]; //Заполняем массив числами от 0 до 9
        int number;
        for (int i = 1; i < 10; i++)
        {
            for (int j = 1; j < 10; j++)
            {
                myArray[i, j] = i * j;
                number = i * j;
                PrintResultMethod(myArray, number);
            }

            Console.WriteLine();
        }
    }

    /// Метод для вывода решения
    public static void PrintResultMethod(int[,] newArray, int num)
    {
        //Console.Write($"{newArray}\t");
        Console.Write($"{string.Join(" ", num)}\t");
    }
}