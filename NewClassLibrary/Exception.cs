namespace NewClassLibrary;

public class OutOfDustVolumeException : Exception
{
    public override string ToString()
    {
        return $"Объема резервуара не достаточно чтобы убрать эту комнату!!!";
    }
}