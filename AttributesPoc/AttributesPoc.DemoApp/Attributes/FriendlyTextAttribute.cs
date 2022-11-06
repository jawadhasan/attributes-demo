namespace AttributesPoc.DemoApp.Attributes
{
    [AttributeUsage(AttributeTargets.Field)]
    public sealed class FriendlyTextAttribute : Attribute
    {
        public string FriendlyText { get; }

        //ctor
        public FriendlyTextAttribute(string friendlyText)
        {
            FriendlyText = friendlyText;
        }
    }
}
