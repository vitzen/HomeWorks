using Library.Interfaces;

namespace Library.Figures;

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