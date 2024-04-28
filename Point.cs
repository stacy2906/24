// 4. Обобщенный класс точки
class Point<T>
{
    private T x;
    private T y;

    public Point(T x, T y)
    {
        this.x = x;
        this.y = y;
    }

    public T X
    {
        get { return x; }
        set { x = value; }
    }

    public T Y
    {
        get { return y; }
        set { y = value; }
    }

    public void Print()
    {
        Console.WriteLine($"Point: ({x}, {y})");
    }
}
