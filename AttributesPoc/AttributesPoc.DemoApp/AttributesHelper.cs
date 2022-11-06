using System.Diagnostics;
using System.Reflection;
using AttributesPoc.DemoApp.Attributes;
using AttributesPoc.DemoApp.Vehicles;

namespace AttributesPoc.DemoApp
{
    public static class AttributesHelper
    {
        //made this generic, so it can work with other enums as well, not just to DeviceType only.
        public static string GetFriendlyText<T>(T value) where T : Enum
        {
            Type type = value.GetType(); //GetType is your entrypoint for reflection libraries

            FieldInfo? memberInfo = type.GetField(value?.ToString()); //returns FieldInfo which describe the named field.
            
            //GetCustomAttribute returns the attributes that have been applied to a type/code element
            //inherit: false, means that we do not want attributes which were applied to base-calsses.  
            object[]? attribs = memberInfo?.GetCustomAttributes(typeof(FriendlyTextAttribute), false); //we are only interested in attributes of type FriendlyTextAttribute

            if (attribs == null || attribs.Length == 0)
            {
                return value.ToString();
            }

            var attrib = (FriendlyTextAttribute) attribs[0];
            return attrib.FriendlyText;

        }


        public static bool CanUseInReport(Vehicle vehicle)
        {
            Type type = vehicle.GetType(); 

            object[]? attribs = type.GetCustomAttributes(typeof(ActualVehicleAttribute), false); 


            if (attribs == null || attribs.Length == 0)
                return false;

            Debug.Assert(attribs.Length == 1);
            var attrib = (ActualVehicleAttribute) attribs[0];
            return attrib.CanUseInReport;

        }

    }
}
