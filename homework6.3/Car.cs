using System;
using System.Reflection.Emit;


namespace homework6._3;

public class Car //Класс автомобиль
{
    public enum CarColorState
    {
        Metallic,
        Black,
        Blue,
    }

    private CarColorState _color; //Цвет автомобиля
    private string _manufactureName; //Название/марка автомобиля
    private int _manufactureYear; //Год выпуска
    private int _enginePower; //Мощность двигателя
    private double _carMileage; //Пробег
    private int _fuelTankCapacity; //Емкость топливного бака в литрах
    private double _gas_Consumption; //расход бензина на 100км

    public Car(CarColorState color, string manufactureName, int manufactureYear, int enginePower, double carMileage, int fuelTankCapacity, double gasConsumption)
    {
        _color = color;
        _manufactureName = manufactureName;
        _manufactureYear = manufactureYear;
        _enginePower = enginePower;
        _carMileage = carMileage;
        _fuelTankCapacity = fuelTankCapacity;
        _gas_Consumption = gasConsumption;
    }


    /// Получить пробег по умолчанию (на новом автомобиле)
    public double GetMilage()
    {
        return _carMileage;
    }


    /// Получить пробег через N миль
    public double GoSomeMile(int mile)
    {
        _carMileage += mile;
        return _carMileage;
    }


    /// Получить возраст автомобиля на данный момент времени
    public int CarAgeYear()
    {
        return (DateTime.Now.Year - _manufactureYear);
    }

    // Логика работы с топливом


    public override string ToString()
    {
        return
            $"CarColorState: {_color}, ManufactureName: {_manufactureName}, ManufactureYear: {_manufactureYear}, EnginePower: {_enginePower}, CarMileage: {_carMileage}";
    }
}