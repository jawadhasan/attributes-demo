using System.ComponentModel.DataAnnotations;
using AttributesPoc.DemoApp.Attributes;

namespace AttributesPoc.DemoApp
{
    [Obsolete]
    public class Device
    {
        [Key]
        public Guid Id { get; set; }

        public DeviceType DeviceType { get; set; }

        public override string ToString()
        {
            return $"{Id}  {AttributesHelper.GetFriendlyText(DeviceType)}";
        }
    }

    public enum DeviceType
    {
        [FriendlyText("Virtual Device")]
        VirtualDevice = 0,

        [FriendlyText("Physical Device")]
        PhysicalDevice = 1
    }
}
