// See https://aka.ms/new-console-template for more information

using AttributesPoc.DemoApp;
using AttributesPoc.DemoApp.Attributes;
using AttributesPoc.DemoApp.Servers;
using AttributesPoc.DemoApp.Vehicles;

//demo-1
var attribs = typeof(Device)
    .GetProperty("Id")
    ?.GetCustomAttributes(false)
    .Select(a => a.GetType());

//Console.WriteLine(attribs?.First().Name);



//demo-2
var device = new Device();
//Console.WriteLine(device);



//demo-3
Console.WriteLine("******Demo-3 (Attribute on Type - condition)******");
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
Console.WriteLine("******Demo-4 (Attribute on Type)******");
var server = new Server("Domain Controller");
var info = typeof(Server); //or server.GetType()
object[] attrib = info.GetCustomAttributes(typeof(CompanyAttribute), false);
foreach (Object attribute in attrib)
{
    CompanyAttribute b = (CompanyAttribute)attribute;
    Console.WriteLine($"{b.Name}, {b.Location}");
}


//demo-5
Console.WriteLine("******Demo-5 (InfoText attribute on class/properties)******");
var helpTextSever = AttributesHelper.GetInfoText(server);
Console.WriteLine(helpTextSever);

var helpTextServerPrperties = AttributesHelper.GetInfoTextProperties(server);
foreach (var propHelpInfo in helpTextServerPrperties)
{
    Console.WriteLine(propHelpInfo);
}


//demo-6: Reflection to get instance properites valeus on run-time
Console.WriteLine("******Reflection-Demo******");
var valuesList = AttributesHelper.GetPropertyValueList(car);
Console.WriteLine(valuesList);




