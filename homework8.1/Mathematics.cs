// Математический класс с алгоритмическими методами
using homework8._1.Rooms;

namespace homework8._1;

public static class Mathematics
{
    //Подсчитываем общую площадь всех комнат
    public static double CalculateRoomArea(RoomClass[] rooms)
    {
        double summofAreas = 0;
        foreach (var room in rooms)
        {
            summofAreas += room.Area;
        }

        return summofAreas;
    }

    //Подсчитываем общий периметр всех комнат
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