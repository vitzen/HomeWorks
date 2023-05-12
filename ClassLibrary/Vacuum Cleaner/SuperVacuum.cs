///class SuperVacuum нужен для того чтобы можно было создавать массив из генериков разного типа (string, int и тд)
/// Мы наследуем все остальные классы vacuum от него
using System.Collections.Generic;
using ClassLibrary.Rooms;

namespace ClassLibrary.Vacuum_Cleaner;

public class SuperVacuum
{
    private double _maxVolume; //поле максимальный объем
    private string _model;

    // public double MaxVolume
    // {
    //     get => _maxVolume;
    //     set => _maxVolume = value;
    // }

    public virtual void StartCleaning()
    {
        Console.WriteLine("Началась уборка");
    }

    public virtual string StartCleaning(RoomClass targetRoom)
    {
        return $"Началась уборка в комнате: {targetRoom}";
    }
    
    /// <summary>
    /// Метод для подсчета максимального количества пыли в зависимости от комнаты
    /// </summary>
    /// <param name="targetRoom"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public string CalculateMaxDustVolumeOfRoom(RoomClass targetRoom)
    {
        var maxDustVolumeOfRoom = (targetRoom.Perimetr * 18) / targetRoom.Area;
        if (maxDustVolumeOfRoom > _maxVolume)
        {
            throw new Exception("Ей, остановись, твой пылесос не сможет сожрать столько пыли");
        }

        return $"Все отлично, предельно допустимый объем резервуара для пыли не превышен.\t" +
               $"Максимальный объем резервуара пылесоса {_maxVolume}\t" +
               $"Пыли собрано в объеме {maxDustVolumeOfRoom}";
    }
    
    public override string ToString()
    {
        return $"{_model}";
    }
}