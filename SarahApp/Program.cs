using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.ServiceBus;

namespace SarahSenderApp
{
    class Program
    {
        const string ServiceBussConnectionString = "Endpoint=sb://sarahservicebus.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=mSzpVDuDSN0tHF3qZsY3KS1h54ZMNpc1B3FS/ShIfX0=";
        const string QueueName = "sarahqueue";
        static IQueueClient queueClient;
        public static async Task Main(string[] args)
        {
            const int numberOfMessages = 10;
            queueClient = new QueueClient(ServiceBussConnectionString, QueueName);
            Console.WriteLine("====================================================");
            Console.WriteLine("Hello World!");
        }
    }
}
