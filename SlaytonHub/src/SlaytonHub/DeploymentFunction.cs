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
using GithubWebhook;
using GithubWebhook.Common;
using Newtonsoft.Json.Linq;

[assembly: LambdaSerializer((typeof(Amazon.Lambda.Serialization.Json.JsonSerializer)))]

namespace SlaytonHub
{
    public class DeploymentFunction
    {
        private const string bucketName = "slaytonhub.content";
        private const string objectKey  = "wwwroot";
        private const string gitHubWebHook   = "https://us-east-1.webhooks.aws/trigger?t=eyJlbmNyeXB0ZWREYXRhIjoiWGF1ZVY5SFVOR2JZUi9CTWFHS01ZTjhjTjhIWGlHaVRvMmt1eTE0bWtGbjFySGlVTjNUTnkveEVZR3VaOXRPa21hNEZHWk1JcHQ2anM3d25TMWZtb2FjdVlJRzl6V25JL3pnWFBHMzJBOUV1UTlrNndsVnU1MVZIVjN1K3JoMVlIbkN1WTM5Nmo2czRNNFo1K1FXZm0rSDZJT2NGMDhsdW9EOUdkaU1rd1BwdjRnPT0iLCJpdlBhcmFtZXRlclNwZWMiOiJnSjI0RUdJUDcrTWl5QW84IiwibWF0ZXJpYWxTZXRTZXJpYWwiOjF9&v=1";
        // Specify your bucket region (an example region is shown).
        private static readonly RegionEndpoint bucketRegion = RegionEndpoint.USEast1; 
        private static IAmazonS3 s3Client;
        
        public async Task<string> FunctionHandlerAsync(ILambdaContext context)
        {
            return string.Empty;
        }

        
    }
}