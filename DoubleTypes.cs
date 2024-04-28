// 2. Использование нескольких универсальных параметров
class DoubleTypes<T1, T2>
{
    private T1 var1;
    private T2 var2;

    public DoubleTypes(T1 v1, T2 v2)
    {
        var1 = v1;
        var2 = v2;
    }

    public void Print()
    {
        Console.WriteLine($"var1: {var1}, var2: {var2}");
    }
}
