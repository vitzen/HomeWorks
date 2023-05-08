using homework9._1.Interfaces;

namespace homework9._1;

public class Figures : IPhysical
{
    public enum ColorState
    {
        Red,
        Green,
        Blue,
        White,
        Black,
    }


    public double Area { get; set; }
    public double Perimetr { get; set; }
}