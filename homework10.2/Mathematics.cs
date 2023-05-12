// Математический класс с алгоритмическими методами


using NewClassLibrary.Rooms;

namespace homework10._2;

public static class Mathematics
{
    /// <summary>
    /// Подсчитываем общую площадь всех комнат
    /// </summary>
    /// <param name="rooms"></param>
    /// <returns></returns>
    public static double CalculateRoomArea(RoomClass[] rooms)
    {
        double summofAreas = 0;
        foreach (var room in rooms)
        {
            summofAreas += room.Area;
        }

        return summofAreas;
    }


    /// <summary>
    /// Подсчитываем общий периметр всех комнат
    /// </summary>
    /// <param name="rooms"></param>
    /// <returns></returns>
    public static double CalculateRoomPerimetr(RoomClass[] rooms)
    {
        double summOfPerimetrs = 0;

        foreach (var room in rooms)
        {
            summOfPerimetrs += room.Perimetr;
        }

        return summOfPerimetrs;
    }
}