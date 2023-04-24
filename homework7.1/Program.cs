//Домашнее задание 7.1
//расширяем класс Машина
//добавляем ему констркуторов, свойств, методов (набор - по желанию)

using System;
using System.Reflection.Emit;


namespace homework7._1
{
    class Program
    {
        public static void Main()
        {
            Car peugeot = new Car(Car.CarColorState.Black, "Peugeot 307", 2021, 100, 100, 0);
            Car volvo = new Car(Car.CarColorState.Blue, "Volvo s60", 2022, 120, 135, 0);
            Car toyota = new Car(Car.CarColorState.Metallic, "Toyota RAV4", 2023, 123, 100, 0);

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

            //Автомобили совершили тестовый пробег в км.
            peugeot.GoSomeMile(327);
            volvo.GoSomeMile(289);
            toyota.GoSomeMile(32);

            peugeot.GetMilage();
            volvo.GetMilage();
            toyota.GetMilage();
            Console.WriteLine($"Пробег (км) после test drive/ автомобиля Peugeot: {peugeot.GetMilage()}\n" +
                              $"Пробег (км) после test drive/ автомобиля Volvo: {volvo.GetMilage()}\n" +
                              $"Пробег (км) после test drive/ автомобиля Toyta: {toyota.GetMilage()}\n");

            peugeot.GetFuelValue();
            volvo.GetFuelValue();
            toyota.GetFuelValue();
            Console.WriteLine($"Обьем топлива по умолчанию/ автомобиля Peugeot: {peugeot.GetFuelValue()}\n" +
                              $"Обьем топлива по умолчанию/ автомобиля Volvo: {volvo.GetFuelValue()}\n" +
                              $"Обьем топлива по умолчанию/ автомобиля Toyta: {toyota.GetFuelValue()}\n");
            peugeot.Refuel(35);
            volvo.Refuel(40);
            toyota.Refuel(32);
            Console.WriteLine($"Обьем топлива после заправки/ автомобиля Peugeot: {peugeot.GetFuelValue()}\n" +
                              $"Обьем топлива после заправки/ автомобиля Volvo: {volvo.GetFuelValue()}\n" +
                              $"Обьем топлива после заправки/ автомобиля Toyta: {toyota.GetFuelValue()}\n");

            peugeot.Usefuel(30);
            volvo.Usefuel(30);
            toyota.Usefuel(10);


            peugeot.GetFuelValue();
            volvo.GetFuelValue();
            toyota.GetFuelValue();
            Console.WriteLine(
                $"Обьем топлива после перегона авто в автосалон г.Москва/ автомобиля Peugeot: {peugeot.GetFuelValue()}\n" +
                $"Обьем топлива после перегона авто в автосалон г.Москва/ автомобиля Volvo: {volvo.GetFuelValue()}\n" +
                $"Обьем топлива после перегона авто в автосалон г.Москва/ автомобиля Toyta: {toyota.GetFuelValue()}\n");

            
            peugeot.GasolineСonsumption = 12;
           

            // Delay
            // Console.Readkey();
        }
    }
}