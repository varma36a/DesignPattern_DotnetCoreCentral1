using NUnit.Framework;

[TestFixture]
public class AbstractFactoryTests
{
    [Test]
    public void ElectricVehicleFactory_ShouldCreateElectricCarAndBike()
    {
        IVehicleFactory factory = new ElectricVehicleFactory();

        ICar car = factory.CreateCar();
        IBike bike = factory.CreateBike();

        Assert.IsInstanceOf<ElectricCar>(car);
        Assert.IsInstanceOf<ElectricBike>(bike);
    }

    [Test]
    public void GasolineVehicleFactory_ShouldCreateGasolineCarAndBike()
    {
        IVehicleFactory factory = new GasolineVehicleFactory();

        ICar car = factory.CreateCar();
        IBike bike = factory.CreateBike();

        Assert.IsInstanceOf<GasolineCar>(car);
        Assert.IsInstanceOf<GasolineBike>(bike);
    }

    [Test]
    public void ElectricCar_ShouldDrive()
    {
        ICar car = new ElectricCar();
        Assert.DoesNotThrow(() => car.Drive());
    }

    [Test]
    public void GasolineCar_ShouldDrive()
    {
        ICar car = new GasolineCar();
        Assert.DoesNotThrow(() => car.Drive());
    }

    [Test]
    public void ElectricBike_ShouldRide()
    {
        IBike bike = new ElectricBike();
        Assert.DoesNotThrow(() => bike.Ride());
    }

    [Test]
    public void GasolineBike_ShouldRide()
    {
        IBike bike = new GasolineBike();
        Assert.DoesNotThrow(() => bike.Ride());
    }
}
