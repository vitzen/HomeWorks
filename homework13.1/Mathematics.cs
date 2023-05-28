using HW13._1_Library.Figures;

namespace homework13._1;

public class Mathematics
{
    /// <summary>
    /// Метод для подсчета площади
    /// </summary>
    /// <param name="figures"></param>
    /// <returns></returns>
    public static double CalculateArea(IFigures[] figures)
    {
        double result = 0;

        foreach (var figure in figures)
        {
            result += figure.Area;
        }

        return result;
    }

    /// <summary>
    /// Метод для подсчета периметра
    /// </summary>
    /// <param name="figures"></param>
    /// <returns></returns>
    public static double CalculatePerimetr(IFigures[] figures)
    {
        double result = 0;

        foreach (var figure in figures)
        {
            result += figure.Perimetr;
        }

        return result;
    }
}