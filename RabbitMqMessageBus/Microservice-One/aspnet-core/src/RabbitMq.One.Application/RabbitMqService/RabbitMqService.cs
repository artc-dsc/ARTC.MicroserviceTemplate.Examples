using RabbitMq.IntegrationEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.EventBus.Distributed;

namespace RabbitMq.One.RabbitMqService
{
    public class RabbitMqService : OneAppService, IRabbitMqService
    {
        private readonly IDistributedEventBus _distributedEventBus;

        public RabbitMqService(
            IDistributedEventBus distributedEventBus
            )
        {
            _distributedEventBus = distributedEventBus;
        }
        public async void SendMessageToClient(string message)
        {
            await _distributedEventBus.PublishAsync(
                new SendMessageEto
                {
                    Message = message
                }
            );
        }
     }
}
