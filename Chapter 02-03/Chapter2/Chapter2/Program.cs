using Azure.Storage.Blobs;
using System.Net;

namespace Chapter2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Chapter 2.1 - Azure Storage Accounts
            //Examples for Chapter 2.1


            Console.WriteLine("Uploading file");

            string azureAccountConnectionstring = "YOUR CONNECTIONSTRING";
            string containerName = "upload";
            BlobContainerClient container =
                new BlobContainerClient(azureAccountConnectionstring, containerName);

            container.CreateIfNotExists();

            string blobName = "sample.txt";
            string filePath = $"myfiles/{blobName}";

            BlobClient blob = container.GetBlobClient(filePath);
            blob.Upload(File.OpenRead("C:\\Users\\Açexamdre Malavasi\\Desktop\\sample.txt"));

            Console.WriteLine("Upload done succesfully");

            #endregion

            //Example for Chapter 2.3.3 - HTTP/3

            var client = new HttpClient()
            {
                DefaultRequestVersion = HttpVersion.Version30,
                DefaultVersionPolicy = HttpVersionPolicy.RequestVersionExact
            };


           

        }
    }
}


