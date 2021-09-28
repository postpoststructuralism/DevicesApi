using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevicesApi.Models
{
    public class DeviceRelation
    {
        public int RootDeviceId { get; set; }
        public int RelatedDeviceId { get; set; }

        public virtual Device RootDevice { get; set; }
        public virtual Device RelatedDevice { get; set; }
    }
}
