using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Device.API.Dto
{
    public class DeviceDTO
    {
        public int id { get; set; }
        public int deviceId { get; set; }
        public string DeviceName { get; set; }
        public string ClientName { get; set; }
        public string Status { get; set; }
    }
}
