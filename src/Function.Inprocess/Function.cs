using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace Function_Inprocess
{
    public class Function
    {
        [FunctionName("Function")]
        public void Run([ServiceBusTrigger("%ServiceBusInprocessQueue%", Connection = "ServiceBusNamespace")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
        }
    }
}
