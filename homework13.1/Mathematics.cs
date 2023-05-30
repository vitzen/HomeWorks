using HW13._1_Library;
using HW13._1_Library.Figures;

namespace homework13._1;

public class Mathematics
{
    [AuthorAttribute("Vitalii Zenkov", "29.05.2023")]
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

    [AuthorAttribute("Vitalii Zenkov", "29.05.2023")]
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