public class Car
{
    public string Brand;
    public int Speed;

    // Конструктор
    public Car() { }
    public Car(string brand, int speed)
    {
        Brand = brand;
        Speed = speed;
    }

    public void Drive()
    {
        Console.WriteLine($"Car {Brand} has speed {Speed.ToString()} km/h");
    }
}

class Program
{
    static void Main()
    {
        Car car1 = new Car();
        car1.Brand = "qwerty";
        car1.Speed = 52;
        car1.Drive();

        Car car2 = new Car("sigaev", 53);
        car2.Drive();
    }
}