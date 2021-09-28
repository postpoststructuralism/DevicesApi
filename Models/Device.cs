using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevicesApi.Models
{
    public class Device
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Temperature { get; set; }
        public int DeviceStatusId { get; set; }
        public int DeviceTypeId { get; set; }

        public virtual DeviceStatusType DeviceStatus { get; set; }
        public virtual DeviceType DeviceType { get; set; }

        //public virtual IEnumerable<Device> RelatedDevices { get; set; }
        public virtual IEnumerable<DeviceRelation> RelatedDevices { get; set; }
    }
}
