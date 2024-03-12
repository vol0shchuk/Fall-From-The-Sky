
public abstract class Transport
{
    public abstract void Move();

    public void SoundHorn()
    {
        Console.WriteLine("Beep beep!");
    }
}

public class Car : Transport
{
    public override void Move()
    {
        Console.WriteLine("Car is driving...");
    }
}

public class Plane : Transport
{
    public override void Move()
    {
        Console.WriteLine("Plane is flying...");
    }
}

public class Ship : Transport
{
    public override void Move()
    {
        Console.WriteLine("Ship is sailing...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Car car = new Car();
            car.SoundHorn();
            car.Move();

            Plane plane = new Plane();
            plane.SoundHorn();
            plane.Move();

            Ship ship = new Ship();
            ship.SoundHorn();
            ship.Move();
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
