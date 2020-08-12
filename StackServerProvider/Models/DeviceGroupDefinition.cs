using System.Collections.Generic;
namespace StackServerProvider.Models
{
    public class DeviceGroupDefinition
    {
        public string DeviceGroupName { get; set; }
        public string DeviceGroupId { get; set; }
        public List<string> GroupItems { get; set; }
    }
}