using Volo.Abp.EventBus;

namespace RabbitMq.IntegrationEvents
{
    [EventName("RabbitMqTest.IntegrationEvents.SendMessage")]
    public class SendMessageEto
    {
        public string Message { get; set; }

    }
}
