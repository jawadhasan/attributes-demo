// See https://aka.ms/new-console-template for more information

using System.Reflection;
using AttributesPoc.DemoApp;
using AttributesPoc.DemoApp.Attributes;
using AttributesPoc.DemoApp.Servers;
using AttributesPoc.DemoApp.Vehicles;

//demo-2
var device = new Device();
//Console.WriteLine(device);



//demo-3
var car = new Car("1", "car-1", "Tesla");
var truck = new Truck("2", "truck-1", 4);
//var flyingCar = new FlyingCar("3", "fly-1", 2000);

var vehicles = new List<Vehicle> {
    car,truck,//flyingCar
};

foreach (var vehicle in vehicles)
{
    ReportHelper.Write(vehicle);
}


//demo-4
var server = new Server("Domain Controller");
var info = typeof(Server); //or server.GetType()
object[] attrib = info.GetCustomAttributes(typeof(CompanyAttribute), false);
foreach (Object attribute in attrib)
{
    CompanyAttribute b = (CompanyAttribute)attribute;
    Console.WriteLine($"{b.Name}, {b.Location}");
}



//demo-1
var attribs = typeof(Device)
    .GetProperty("Id")
    ?.GetCustomAttributes(false)
    .Select(a => a.GetType());

//Console.WriteLine(attribs?.First().Name);
