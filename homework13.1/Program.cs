//ЗАДАЧА:
//Добавить 1 собственный атрибут на класс, 1 собственный атрибут на метод .
//Использовать их для фигур.

using System;
using System.Reflection.Emit;
using System.Text;
using HW13._1_Library;
using HW13._1_Library.Figures;


namespace homework13._1
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

            //Console.WriteLine($"Сумма площадей всех фигур составляет: {Mathematics.CalculateArea(figures).GetType().ToString()}");
            Console.WriteLine($"Сумма площадей всех фигур составляет: {Mathematics.CalculateArea(figures)}");
            Console.WriteLine($"Сумма периметров всех фигур составляет: {Mathematics.CalculatePerimetr(figures)}\n");
            
            // var getTypeoffAllFigures = figures.GetType();
            //
            // foreach (var att in getTypeoffAllFigures.GetCustomAttributes(true))
            // {
            //     if (att is AuthorAttribute authorAttribute)
            //     {
            //         Console.WriteLine($"Атрибут у фигуры {figures} --> {authorAttribute}");
            //     }
            // }

            // Выводим атрибуты у фигуры Circle
            var getTypeoffigures = figures1.GetType();

            foreach (var att in getTypeoffigures.GetCustomAttributes(true))
            {
                if (att is AuthorAttribute authorAttribute)
                {
                    Console.WriteLine($"Атрибут у фигуры {figures1.GetTitle} --> {authorAttribute}");
                }
            }
        }
    }
}