using DevicesApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevicesApi.ViewModels
{
    public class DeviceBaseViewModel
    {   public DeviceBaseViewModel(Device device)
        {
            Id = device.Id;
            Name = device.Name;
            Temperature = device.Temperature;

            DeviceStatusId = device.DeviceStatusId;
            DeviceStatusName = device.DeviceStatus.Name;

            DeviceTypeId = device.DeviceTypeId;
            DeviceTypeName = device.DeviceType.Name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Temperature { get; set; }

        public int DeviceStatusId { get; set; }
        public string DeviceStatusName { get; set; }

        public int DeviceTypeId { get; set; }
        public string DeviceTypeName { get; set; }
    }
}
