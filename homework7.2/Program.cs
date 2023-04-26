//Домашнее задание 7.2
//Готовим заготовку класса для геометрической фигуры

using System;
using System.Reflection.Emit;


namespace homework7._2
{
    class Program
    {
        public static void Main()
        {
            Circle figures1 = new Circle(5, 6, Figures.ColorState.Black);
            Square figures2 = new Square(5, Figures.ColorState.Blue);
            Triangle figures3 = new Triangle(5, 3, 6, 4, Figures.ColorState.Red);

            Console.WriteLine($"Выводим список созданных пользователем фигур: \n" +
                              $"{figures1}\n" +
                              $"{figures2}\n" +
                              $"{figures3}");
        }
    }
}