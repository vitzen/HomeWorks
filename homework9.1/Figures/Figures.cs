using homework9._1.Interfaces;

namespace homework9._1;

public interface IFigures : IPhysical, IDescriptive
{
    public enum ColorState
    {
        Red,
        Green,
        Blue,
        White,
        Black,
    }


    public double Area { get; }
    public double Perimetr { get; }
}