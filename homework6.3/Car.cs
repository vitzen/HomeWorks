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
    private int _defaultFuelValue; //Количество топлива


    public Car(CarColorState color, string manufactureName, int manufactureYear, int enginePower, double carMileage,
        int defaultFuelValue)
    {
        _color = color;
        _manufactureName = manufactureName;
        _manufactureYear = manufactureYear;
        _enginePower = enginePower;
        _carMileage = carMileage;
        _defaultFuelValue = defaultFuelValue;
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

    //Получить объем топлива
    public int GetFuelValue()
    {
        return _defaultFuelValue;
    }

    //Заправить топлива
    public int Refuel(int addSomeFuel)
    {
        _defaultFuelValue += addSomeFuel;
        return _defaultFuelValue;
    }

    //Потратить топливо
    public int Usefuel(int useSomeFuel)
    {
        _defaultFuelValue -= useSomeFuel;
        return _defaultFuelValue;
    }

    public override string ToString()
    {
        return
            $"Color: {_color}, ManufactureName: {_manufactureName}, ManufactureYear: {_manufactureYear}, EnginePower: {_enginePower}, CarMileage: {_carMileage}, FuelTankCapacity: {_defaultFuelValue}";
    }
}