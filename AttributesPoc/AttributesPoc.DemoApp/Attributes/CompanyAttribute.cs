namespace AttributesPoc.DemoApp.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public sealed class CompanyAttribute : Attribute
    {
        public string Name { get; }
        public string Location { get; set; }

        //ctor
        public CompanyAttribute(string name, string location)
        {
            Name = name;
            Location = location;
        }
    }
}
