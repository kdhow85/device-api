using Device.API.Models;
using Device.API.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Device.API.Services.MockServices
{
    public class MockDeviceService : IDeviceService
    {
        List<ScramDevice> devices;
        List<Client> clients;

        public MockDeviceService()
        {
            if (devices == null)
            {
                intializeDevices();
            }

            if (clients == null)
            {
                InitializeClients();
            }
        }

        private void InitializeClients()
        {
            clients = new List<Client>()
            {
                new Client { Id = 1, Name = "John Reynolds"},
                new Client { Id = 2, Name = "Robert Johnston"},
                new Client { Id = 3, Name = "Vilma Randall"},
                new Client { Id = 4, Name = "Vincent Williams"},
                new Client { Id = 5, Name = "Sarah Barnes"}
            };
        }

        private void intializeDevices()
        {
            devices = new List<ScramDevice>()
            {
                new ScramDevice 
                { 
                    id = 1, 
                    DeviceId = "SCB2001", 
                    Slug = "scb2001", 
                    DeviceName = "SCRAM CAM Bracelet",
                    Status = "Unassigned",
                    ClientId = 1
                },
                new ScramDevice
                {
                    id = 2, 
                    DeviceId = "SCB2002",
                    Slug = "scb2002",
                    DeviceName = "SCRAM CAM Bracelet",
                    Status = "Unassigned",
                    ClientId = 2
                },
                new ScramDevice
                {
                    id = 3, 
                    DeviceId = "SCB2003",
                    Slug = "scb2003",
                    DeviceName = "SCRAM CAM Bracelet",
                    Status = "Unassigned",
                    ClientId = 3
                },
                new ScramDevice
                {
                    id = 4, 
                    DeviceId = "SCB2004",
                    Slug = "scb2004",
                    DeviceName = "SCRAM CAM Bracelet",
                    Status = "Unassigned",
                    ClientId = 4
                },
                new ScramDevice
                {
                    id = 5, 
                    DeviceId = "SCB2005",
                    Slug = "scb2005",
                    DeviceName = "SCRAM CAM Bracelet",
                    Status = "Unassigned",
                    ClientId = 5
                },

            };
        }

        public IEnumerable<ScramDevice> GetDevices()
        {
            return from d in devices
                   orderby d.DeviceId
                   select d;
        }

        public ScramDevice GetDeviceBySlug(string slug)
        {
            return devices.FirstOrDefault(d => d.Slug == slug);
        }

        public void DeleteDevice(ScramDevice device)
        {
            int location = 0;
            foreach (var d in devices)
            {
                if (d.id == device.id)
                {
                    devices.RemoveAt(location);
                    break;
                }
                location++;
            }
        }

        public void SaveDevice(ScramDevice device)
        {
            devices.Add(device);
        }

        public string GetClientName(int id)
        {
            Client c = clients.FirstOrDefault(c => c.Id == id);
            string clientName = c.Name;
            return clientName;
        }
    }
}
