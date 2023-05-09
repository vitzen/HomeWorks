// Домашнее задание 9.1:
// Переделать на дллку работу с фигурами
// Переделать класс фигура в наследование 2х интерфейсов : один с физическими свойствами(Area, Perimeter), другой- с описательными(GetTitle())

using System;
using System.Reflection.Emit;
using System.Text;
using Library.Figures;


namespace homework9._1
{
    class Program
    {
        public static void Main()
        {
            Circle figures1 = new Circle(5, 10, IFigures.ColorState.Black);
            Square figures2 = new Square(5, IFigures.ColorState.Blue);
            Triangle figures3 = new Triangle(5, 3, 6, 4, IFigures.ColorState.Red);

            Console.WriteLine($"Выводим список созданных пользователем фигур: \n" +
                              $"{figures1}\n" +
                              $"{figures2}\n" +
                              $"{figures3}");

            IFigures[] figures =
            {
                new Circle(4, 5, IFigures.ColorState.Blue),
                new Square(6, IFigures.ColorState.Green),
                new Triangle(5, 7, 3, 6, IFigures.ColorState.White)
            };

            Console.WriteLine($"Сумма площадей всех фигур составляет: {Mathematics.CalculateArea(figures)}");
            Console.WriteLine($"Сумма периметров всех фигур составляет: {Mathematics.CalculatePerimetr(figures)}");
        }
    }
}