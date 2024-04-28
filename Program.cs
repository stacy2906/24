class Program
{
    static void Main()
    {
        // Создание объектов с различными типами для универсального параметра
        Transport<int> plane1 = new Transport<int>(1000, 500000, "Boeing");
        Transport<double> plane2 = new Transport<double>(1500.5, 800000.75, "Airbus");
        Transport<string> plane3 = new Transport<string>("2000 HP", 700000, "Embraer");
    }
}
