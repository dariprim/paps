namespace Lab1
{
    public abstract class VehicleFactory
    {
        public abstract Vehicle CreateVehicle();
        public abstract Driver CreateDriver();
    }

    public class TaxiFactory : VehicleFactory
    {
        public override Vehicle CreateVehicle() => new Taxi();
        public override Driver CreateDriver() => TaxiDriver.Instance;
    }

    public class BusFactory : VehicleFactory
    {
        public override Vehicle CreateVehicle() => new Bus();
        public override Driver CreateDriver() => BusDriver.Instance;
    }
}