using AttributesPoc.DemoApp.Vehicles;

namespace AttributesPoc.DemoApp
{
    public static class ReportHelper
    {
        public static void Write(Vehicle vehicle)
        {
            if (!AttributesHelper.CanUseInReport(vehicle))
                throw new ArgumentException($"{vehicle.GetType().Name} can not be used for report.");

            Console.WriteLine($"{vehicle.Id} {vehicle.LicensePlate}");
        }
    }
}
