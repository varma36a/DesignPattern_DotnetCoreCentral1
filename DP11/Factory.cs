// Product Interface
public interface IVehicle
{
    void Drive();
}

// Concrete Product 1
public class Car : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Driving a car!");
    }
}

// Concrete Product 2
public class Bike : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Riding a bike!");
    }
}

// Creator (Factory) Abstract Class
public abstract class VehicleFactory
{
    public abstract IVehicle CreateVehicle();
}

// Concrete Factory 1
public class CarFactory : VehicleFactory
{
    public override IVehicle CreateVehicle()
    {
        return new Car();
    }
}

// Concrete Factory 2
public class BikeFactory : VehicleFactory
{
    public override IVehicle CreateVehicle()
    {
        return new Bike();
    }
}
