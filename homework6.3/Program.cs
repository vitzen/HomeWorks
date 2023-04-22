//Домашнее заданий 6.3
//Добавить к класс Car логику работы с топливом.

using System;

namespace homework6._3
{
    class Program
    {
        public static void Main()
        {
            Car peugeot = new Car(Car.CarColorState.Black, "Peugeot 307", 2021, 100, 100);
            Car volvo = new Car(Car.CarColorState.Blue, "Volvo s60", 2022, 120, 135);
            Car toyota = new Car(Car.CarColorState.Metallic, "Toyota RAV4", 2023, 123, 100);

            peugeot.GetMilage();
            volvo.GetMilage();
            toyota.GetMilage();
            Console.WriteLine($"Пробег автомобиля Peugeot: {peugeot.GetMilage()}\n" +
                              $"Пробег автомобиля Volvo: {volvo.GetMilage()}\n" +
                              $"Пробег автомобиля Toyta: {toyota.GetMilage()}");


            // Delay
            // Console.Readkey();
        }
    }
}