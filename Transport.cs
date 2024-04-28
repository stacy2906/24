using System;
// 1. Использование одного универсального параметра
class Transport<T>
{
    public T Power { get; set; }
    public double Cost { get; set; }
    public string Brand { get; set; }

    public Transport(T power, double cost, string brand)
    {
        Power = power;
        Cost = cost;
        Brand = brand;
    }
}
