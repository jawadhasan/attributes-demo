namespace AttributesPoc.DemoApp.Attributes
{


    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public sealed class ActualVehicleAttribute : Attribute
    {

        //Types (e.g. vehicles) can only be used to be reported
        //if they have been marked with this attribute
        //and CanUseInReport is true.
        public bool CanUseInReport { get; set; }
    }
}
