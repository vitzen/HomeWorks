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
            Figures figures1 = new Circle(5, 6);
            Figures figures2 = new Square(5);
            Figures figures3 = new Triangle(5, 3, 6, 4);
        }
    }
}