// Abstract Product A
public interface ICar
{
    void Drive();
}

// Abstract Product B
public interface IBike
{
    void Ride();
}

// Concrete Product A1 (Electric Car)
public class ElectricCar : ICar
{
    public void Drive()
    {
        Console.WriteLine("Driving an electric car!");
    }
}

// Concrete Product A2 (Gasoline Car)
public class GasolineCar : ICar
{
    public void Drive()
    {
        Console.WriteLine("Driving a gasoline car!");
    }
}

// Concrete Product B1 (Electric Bike)
public class ElectricBike : IBike
{
    public void Ride()
    {
        Console.WriteLine("Riding an electric bike!");
    }
}

// Concrete Product B2 (Gasoline Bike)
public class GasolineBike : IBike
{
    public void Ride()
    {
        Console.WriteLine("Riding a gasoline bike!");
    }
}

// Abstract Factory Interface
public interface IVehicleFactory
{
    ICar CreateCar();
    IBike CreateBike();
}

// Concrete Factory 1 (Electric Vehicle Factory)
public class ElectricVehicleFactory : IVehicleFactory
{
    public ICar CreateCar()
    {
        return new ElectricCar();
    }

    public IBike CreateBike()
    {
        return new ElectricBike();
    }
}

// Concrete Factory 2 (Gasoline Vehicle Factory)
public class GasolineVehicleFactory : IVehicleFactory
{
    public ICar CreateCar()
    {
        return new GasolineCar();
    }

    public IBike CreateBike()
    {
        return new GasolineBike();
    }
}
