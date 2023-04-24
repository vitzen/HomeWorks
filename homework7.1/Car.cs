using System;
using System.Reflection.Emit;


namespace homework7._1;

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
    private int _carMileage; //Пробег
    private int _defaultFuelValue; //Количество топлива
    private int _gasolineСonsumption; //Расход бензина с учетом формулы (N-количество литров/100 км)


    public Car(CarColorState color, string manufactureName, int manufactureYear, int enginePower, int carMileage,
        int defaultFuelValue) //Пользовательский конструктор полей
    {
        _color = color;
        _manufactureName = manufactureName;
        _manufactureYear = manufactureYear;
        _enginePower = enginePower;
        _carMileage = carMileage;
        _defaultFuelValue = defaultFuelValue;
    }

    public Car(int gasolineСonsumption) //Пользовательский конструктор для поля расхода бензина (N-л/100км)
    {
        _gasolineСonsumption = gasolineСonsumption;
    }


    /// Получить пробег по умолчанию (на новом автомобиле)
    public int GetMilage()
    {
        return _carMileage;
    }


    /// Получить пробег через N миль
    public int GoSomeMile(int mile)
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

    //Свойство -  расход бензина (N-л/100км)
    public int GasolineСonsumption
    {
        get
        {
            if (_gasolineСonsumption < 10)
            {
                Console.Write(
                    $"Расход бензина невысокий < 10л/100км и составляет для нашего автомобиля {_manufactureName}: ");
            }
            else
            {
                Console.Write(
                    $"Расход бензина высокий > 10л/100км и составляет для нашего автомобиля {_manufactureName}: ");
            }

            return _gasolineСonsumption;
        }
        set { _gasolineСonsumption = value; }
    }

    public override string ToString()
    {
        return
            $"Color: {_color}\n" +
            $"ManufactureName: {_manufactureName}\n" +
            $"ManufactureYear: {_manufactureYear}\n" +
            $"EnginePower: {_enginePower}\n" +
            $"CarMileage: {_carMileage}\n" +
            $"DefaultFuelValue: {_defaultFuelValue}\n" +
            $"GasolineСonsumption: {_gasolineСonsumption}\n" +
            $"GasolineСonsumption: {_gasolineСonsumption}";
    }
}