using NUnit.Framework;

[TestFixture]
public class FactoryMethodTests
{
    [Test]
    public void CarFactory_ShouldCreateCar()
    {
        VehicleFactory factory = new CarFactory();
        IVehicle vehicle = factory.CreateVehicle();

        Assert.IsInstanceOf<Car>(vehicle); // Use IsInstanceOf<Car>

    }

    [Test]
    public void BikeFactory_ShouldCreateBike()
    {
        VehicleFactory factory = new BikeFactory();
        IVehicle vehicle = factory.CreateVehicle();

        Assert.IsInstanceOf<Bike>(vehicle);
    }

    [Test]
    public void Car_ShouldDrive()
    {
        IVehicle car = new Car();
        Assert.DoesNotThrow(() => car.Drive());
    }

    [Test]
    public void Bike_ShouldDrive()
    {
        IVehicle bike = new Bike();
        Assert.DoesNotThrow(() => bike.Drive());
    }
}
