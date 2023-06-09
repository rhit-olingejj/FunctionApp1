using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace FunctionApp1
{
    public class Function1
    {
        [FunctionName("Function1")]
        public void Run([BlobTrigger("example/{name}", Connection = "DefaultEndpointsProtocol=https;AccountName=testfunctions1;AccountKey=XwvE5rQQV36SKXAP0jU8sNgYJUVVRQWdeMSGE/4CGyFZodpzECXsSrDEAust2Cqx2lstVNHB4QNj+AStxqROvA==;EndpointSuffix=core.windows.net")]Stream myBlob, string name, ILogger log)
        {
            log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
        }
    }
}
