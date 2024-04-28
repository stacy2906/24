// 3. Обобщенный класс калькулятора
class Calculator<T>
{
    public T Add(T a, T b)
    {
        dynamic operand1 = a;
        dynamic operand2 = b;
        return operand1 + operand2;
    }

    public T Subtract(T a, T b)
    {
        dynamic operand1 = a;
        dynamic operand2 = b;
        return operand1 - operand2;
    }

    public T Multiply(T a, T b)
    {
        dynamic operand1 = a;
        dynamic operand2 = b;
        return operand1 * operand2;
    }

    public T Divide(T a, T b)
    {
        dynamic operand1 = a;
        dynamic operand2 = b;
        return operand1 / operand2;
    }
}
