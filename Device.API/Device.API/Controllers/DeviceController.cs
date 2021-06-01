using Device.API.Models;
using Device.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Device.API.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [Route("devices")]
    public class DeviceController : ControllerBase
    {
        private IDeviceService _context;

        public DeviceController(IDeviceService context)
        {
            this._context = context;
        }

        [HttpGet]
        public JsonResult GetDevices()
        {
            var devices = _context.GetDevices();

            // Add client names
            foreach (var d in devices)
            {
                d.ClientName = _context.GetClientName(d.ClientId);
            }

            return new JsonResult(devices);
        }

        [HttpGet("{slug}")]
        public JsonResult GetDeviceBySlug(string slug)
        {
            var device = _context.GetDeviceBySlug(slug);
            device.ClientName = _context.GetClientName(device.ClientId);

            return new JsonResult(device);
        }
    }
}
