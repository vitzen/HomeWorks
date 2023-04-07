using System.Drawing;

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

    private string _manufactureName; //Название/марка автомобиля
    private int _manufactureYear; //Год выпуска
    private int _enginePower; //Мощность двигателя
    private double _carMileage; //Пробег
    private CarColorState _color; //Цвет автомобиля

    

    /// <summary>
    /// Получить пробег
    /// </summary>
    /// <returns></returns>
    public double GetMilage()
    {
        return _carMileage;
    }

    /// <summary>
    /// Получить пробег через 100км
    /// </summary>
    public void Go_100_Mile()
    {
        _carMileage += 100;
    }

    /// <summary>
    /// Получить возраст автомобиля на данный момент времени
    /// </summary>
    /// <returns></returns>
    public int CarAgeYear()
    {
        return (DateTime.Now.Year - _manufactureYear);
    }

    public override string ToString()
    {
        return
            $"CarColorState: {_color}, ManufactureName: {_manufactureName}, ManufactureYear: {_manufactureYear}, EnginePower: {_enginePower}, CarMileage: {_carMileage}, CarAge: {_carAge}";
    }
}