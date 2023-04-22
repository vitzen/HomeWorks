using System;


namespace homework6._3;

public class Car //Класс автомобиль
{
    public enum CarColorState
    {
        White,
        Metallic,
        Black,
        Blue,
        Yellow,
        Green,
        Red
    }

    private CarColorState _color; //Цвет автомобиля
    private string _manufactureName; //Название/марка автомобиля
    private int _manufactureYear; //Год выпуска
    private int _enginePower; //Мощность двигателя
    private double _carMileage; //Пробег
    private double _gas_Consumption; //расход бензина на 100км

    public Car(CarColorState color, string manufactureName, int manufactureYear, int enginePower, double carMileage)
    {
        _color = color;
        _manufactureName = manufactureName;
        _manufactureYear = manufactureYear;
        _enginePower = enginePower;
        _carMileage = carMileage;
    }


    /// Метод для получения пробега
    public double GetMilage()
    {
        return _carMileage;
    }


    /// Получить пробег через 100 миль
    public double Go_100_Mile()
    {
        _carMileage += 100;
        return _carMileage;
    }


    /// Получить возраст автомобиля на данный момент времени
    public int CarAgeYear()
    {
        return (DateTime.Now.Year - _manufactureYear);
    }

    public override string ToString()
    {
        return
            $"CarColorState: {_color}, ManufactureName: {_manufactureName}, ManufactureYear: {_manufactureYear}, EnginePower: {_enginePower}, CarMileage: {_carMileage}";
    }
}