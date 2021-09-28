using DevicesApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevicesApi.ViewModels
{
    public class DeviceViewModel : DeviceBaseViewModel
    {
        public DeviceViewModel(Device device) : base(device)
        {
            RelatedDevices = new List<DeviceBaseViewModel>();
            foreach (var relatedDevice in device.RelatedDevices)
            {
                RelatedDevices.Add(new DeviceBaseViewModel(relatedDevice.RelatedDevice));
            }
        }

        public List<DeviceBaseViewModel> RelatedDevices { get; set; }
    }
}
