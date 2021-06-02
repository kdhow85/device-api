using Microsoft.Extensions.Configuration;
using Microsoft.Azure.ServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text;

namespace Device.API.Services.Queues
{
    public class DeviceQueueService : IDeviceQueueService
    {
        private readonly IConfiguration _config;

        public DeviceQueueService(IConfiguration config)
        {
            this._config = config;
        }

        public async Task SendMessageAsync<T>(T ServiceBusMessage, string queueName)
        {
            var queueClient = new QueueClient(_config.GetConnectionString("AzureServiceBus"), queueName);
            string messageBody = JsonSerializer.Serialize(ServiceBusMessage);
            var message = new Message(Encoding.UTF8.GetBytes(messageBody));

            await queueClient.SendAsync(message);
        }
    }
}
