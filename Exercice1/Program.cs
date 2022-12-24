

class Car
{
    public Car() { }

    public int doors = 0;
    public void moreDoors() => doors++;

    static void Main(string[] args)
    {
        int adittion(int a, int b, int c) => a + b + c;
        Console.WriteLine($"The adittion result is {adittion(1, 2, 3)}");

        var myCar = new Car();
        myCar.moreDoors();
        Console.WriteLine($"The car has {myCar.doors}");
    }
}