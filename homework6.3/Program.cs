//Домашнее заданий 6.3
//Добавить к класс Car логику работы с топливом.

using System;

namespace homework6._3
{
    class Program
    {
        public static void Main()
        {
            Car peugeot = new Car(Car.CarColorState.Black, "Peugeot 307", 2021, 100, 100, 30, 10);
            Car volvo = new Car(Car.CarColorState.Blue, "Volvo s60", 2022, 120, 135, 40, 12);
            Car toyota = new Car(Car.CarColorState.Metallic, "Toyota RAV4", 2023, 123, 100, 45, 15);

            Console.WriteLine($"Выводим всю изначальную информацию об имеющихся автомобилях в салоне:\n" +
                              $" {peugeot}\n" +
                              $" {volvo}\n" +
                              $" {toyota}\n");

            peugeot.GetMilage();
            volvo.GetMilage();
            toyota.GetMilage();
            Console.WriteLine($"Изначальный пробег (с завода)/ автомобиля Peugeot: {peugeot.GetMilage()}\n" +
                              $"Изначальный пробег (с завода)/ автомобиля Volvo: {volvo.GetMilage()}\n" +
                              $"Изначальный пробег (с завода)/ автомобиля Toyta: {toyota.GetMilage()}\n");
            
            peugeot.CarAgeYear();
            volvo.CarAgeYear();
            toyota.CarAgeYear();
            Console.WriteLine($"Возраст автомобиля Peugeot: {peugeot.CarAgeYear()}\n" +
                              $"Возраст автомобиля Volvo: {volvo.CarAgeYear()}\n" +
                              $"Возраст автомобиля Toyta: {toyota.CarAgeYear()}\n");

            //Автомобили совершили тестовый пробег
            peugeot.GoSomeMile(327);
            volvo.GoSomeMile(289);
            toyota.GoSomeMile(32);

            peugeot.GetMilage();
            volvo.GetMilage();
            toyota.GetMilage();
            Console.WriteLine($"Пробег после test drive/ автомобиля Peugeot: {peugeot.GetMilage()}\n" +
                              $"Пробег после test drive/ автомобиля Volvo: {volvo.GetMilage()}\n" +
                              $"Пробег после test drive/ автомобиля Toyta: {toyota.GetMilage()}\n");

            

       


        // Delay
        // Console.Readkey();
    }
}

}