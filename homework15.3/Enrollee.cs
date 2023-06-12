namespace homework15._3;

public class Enrollee
{
    private string _name;
    private int _schoolNumber;
    private int _receiptDate;

    public Enrollee(string name, int schoolNumber, int receiptDate)
    {
        _name = name;
        _schoolNumber = schoolNumber;
        _receiptDate = receiptDate;
    }

    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int SchoolNumber
    {
        get => _schoolNumber;
        set => _schoolNumber = value;
    }

    public int ReceiptDate
    {
        get => _receiptDate;
        set => _receiptDate = value;
    }

    public override string ToString()
    {
        return $"Абитуриент: {Name}, школа {SchoolNumber}, {ReceiptDate}г.";
    }
}