using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Device.API.Models
{
    public class ScramDevice
    {
        public int id { get; set; }
        public string DeviceId { get; set; }
        public string Slug { get; set; }
        public string DeviceName { get; set; }
        public string Status { get; set; }
        public string ClientName { get; set; }
        public int ClientId { get; set; }
    }
}
