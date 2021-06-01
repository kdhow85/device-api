using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Device.API.Models;

namespace Device.API.Services.Interfaces
{
    public interface IDeviceService
    {
        IEnumerable<ScramDevice> GetDevices();
        ScramDevice GetDeviceBySlug(string slug);
        void SaveDevice(ScramDevice device);
        void DeleteDevice(ScramDevice device);
        string GetClientName(int id);
    }
}
