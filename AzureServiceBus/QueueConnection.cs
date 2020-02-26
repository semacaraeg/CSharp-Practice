using System;

namespace AzureServiceBus
{
    public class QueueConnection
    {
        // Connection String for the namespace can be obtained from the Azure portal under the 
        // 'Shared Access policies' section.
        public string ServiceBusConnectionString = "Endpoint=sb://sarahservicebus.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=mSzpVDuDSN0tHF3qZsY3KS1h54ZMNpc1B3FS/ShIfX0=";
        public string QueueName = "sarahqueue";
    }
}
