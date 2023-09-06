using RabbitMq.IntegrationEvents;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EventBus.Distributed;

namespace ARTC.OrcaHub.EventHandlers
{
    public class MessageReceivedEventHandler : IDistributedEventHandler<SendMessageEto>,
      ITransientDependency
    {
        public async Task HandleEventAsync(SendMessageEto eventData)
        {
            //var tenant = eventData;
            var test = eventData;
        }
    }
}
