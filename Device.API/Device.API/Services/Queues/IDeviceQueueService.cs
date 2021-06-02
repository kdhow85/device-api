using System.Threading.Tasks;

namespace Device.API.Services.Queues
{
    public interface IDeviceQueueService
    {
        Task SendMessageAsync<T>(T ServiceBusMessage, string queueName);
    }
}