namespace hometask2._1;

static class ExtensionClass
{
    public static void ExtensionMethod(this string value)
    {
        Console.WriteLine($"1-ый способ вызова метода, как расширяющего --> {value}");
    }
}