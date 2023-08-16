using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Microsoft.Azure.Storage;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace CLOUDPART3
{
    public class Function1
    {
        [FunctionName("Function1")]
        public void Run([BlobTrigger("samples-workitems/{name}", Connection = "")]Stream myBlob, string name, ILogger log)
        {
            log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
        }
        {
            CloudStorageAccount Storage = CloudStorageAccount.Parse(connection);

        // Retrieve storage account from connection string


        // Create the queue client
        CloudQueueClient client = Storage.CreateCloudQueueClient();
        CloudQueue queue = client.GetQueueReference("myqueue-items");
        Queue.CreateIfNotExists();

          

            // Create a message and add it to the queue
            CloudQueueMessage messageA = new CloudQueueMessage("15687459:Medi - Clinic:09 - 07 - 2022:YPB - 3 - 5455DHF");
        queue.AddMessage(messageA);
            CloudQueueMessage messageB = new CloudQueueMessage("15698432:Westville Life Hospital:11 - 10 - 2022:JSB - 7 - 8936ZHF");
        Queue.AddMessage(messageB);
            CloudQueueMessage messageC = new CloudQueueMessage("16579423:Dischem:01 - 12 - 2022:NEP - 15 - 3320LHF");
        queue.AddMessage(messageC);
            CloudQueueMessage messageD = new CloudQueueMessage("11245786:Clicks:08 - 08 - 2022:ABC - 1 - 2345DHF");
        queue.AddMessage(messageD);
            CloudQueueMessage messageE = new CloudQueueMessage("11154876:Medi - Clinic:05 - 03 - 2022:ALS - 8 - 1111DLF");
        queue.AddMessage(messageE);




            //queue.DeleteIfExists();
            CloudQueueMessage getMessage = queue.GetMessage();
        Console.WriteLine(getMessage.AsString);
            Console.ReadLine();
        }
}
}
