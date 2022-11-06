using AttributesPoc.DemoApp.Attributes;

namespace AttributesPoc.DemoApp.Vehicles
{
    public class Vehicle
    {
        public string Id { get; set; }
        public string LicensePlate { get; set; }
        public Vehicle(string id, string licensePlate)
        {
                Id = id;
                LicensePlate = licensePlate;
        }
    }


    [ActualVehicle(CanUseInReport = true)]
    public class Car : Vehicle
    {
        public string Make { get; set; }
        public Car(string id, string licensePlate, string make)
            :base(id, licensePlate)
        {
            Make = make;
        }
    }


    [ActualVehicle(CanUseInReport = true)]
    public class Truck : Vehicle
    {
        public int StorageArea { get; set; }
        public Truck(string id, string licensePlate, int storageArea)
            :base(id,licensePlate)
        {
            StorageArea = storageArea;
        }
    }

    public class FlyingCar : Vehicle
    {
        public int Altitude { get; set; }

        public FlyingCar(string id, string licensePlate, int altitude)
            :base(id,licensePlate)
        {
            Altitude = altitude;
        }
    }
}
