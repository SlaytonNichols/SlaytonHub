using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Amazon;
using Amazon.Lambda.Core;
using Amazon.S3;
using Amazon.S3.Model;

[assembly: LambdaSerializer((typeof(Amazon.Lambda.Serialization.Json.JsonSerializer)))]

namespace SlaytonHub
{
    public class DeploymentFunction
    {
        private const string bucketName = "slaytonhub.content";
        private const string objectKey  = "wwwroot";
        private const string filePath   = "";
        // Specify your bucket region (an example region is shown).
        private static readonly RegionEndpoint bucketRegion = RegionEndpoint.USEast1; 
        private static IAmazonS3 s3Client;
        
        public async Task<string> FunctionHandlerAsync(ILambdaContext context)
        {
            s3Client = new AmazonS3Client(bucketRegion);
            var url = GeneratePreSignedURL();
            return UploadObject(url);
        }

        private static string UploadObject(string url)
        {
            HttpWebRequest httpRequest = WebRequest.Create(url) as HttpWebRequest;
            httpRequest.Method = "PUT";
            using (Stream dataStream = httpRequest.GetRequestStream())
            {
                var buffer = new byte[8000];
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    int bytesRead = 0;
                    while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        dataStream.Write(buffer, 0, bytesRead);
                    }
                }
            }
            HttpWebResponse response = httpRequest.GetResponse() as HttpWebResponse;
        }

        private static string GeneratePreSignedURL()
        {
            var request = new GetPreSignedUrlRequest
            {
                BucketName = bucketName,
                Key        = objectKey,
                Verb       = HttpVerb.PUT,
                Expires    = DateTime.Now.AddMinutes(5)
            };

            string url = s3Client.GetPreSignedURL(request);
            return url;
        }
    }
}