namespace AttributesPoc.DemoApp.Attributes
{
    public sealed class InfoAttribute : Attribute
    {
        public string InfoText { get; }

        public InfoAttribute(string infoText)
        {
            InfoText = infoText;    
        }
    }
}
