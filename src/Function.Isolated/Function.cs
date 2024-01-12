using System;
using Azure.Messaging.ServiceBus;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Function_Isolated
{
    public class Function
    {
        private readonly ILogger<Function> _logger;

        public Function(ILogger<Function> logger)
        {
            _logger = logger;
        }

        [Function(nameof(Function))]
        public void Run([ServiceBusTrigger("%ServiceBusIsolatedQueue%", Connection = "ServiceBusNamespace")] ServiceBusReceivedMessage message)
        {
            _logger.LogInformation("Message ID: {id}", message.MessageId);
            _logger.LogInformation("Message Body: {body}", message.Body);
            _logger.LogInformation("Message Content-Type: {contentType}", message.ContentType);
        }
    }
}
