using Microsoft.Graph;
using System;
using Microsoft.Identity.Client;

namespace MicrosoftGraphSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Authenticate
            AuthenticationConfig config = AuthenticationConfig.ReadFromJsonFile("appsettings.json");

            config.CheckParameters();

            var graphServiceClient = GraphClientFactory.GetGraphServiceClient(config.ClientId, config.Authority, config.Scopes, config.ClientSecret);

            var photoDemetrio = graphServiceClient.Users["demcost@microsoft.com"].Photos["240x240"].Content.Request().GetAsync();

            //var photoRubiana = graphServiceClient.Users["rubianar@microsoft.com"].Photos["240x240"].Content.Request().GetAsync();

        }
    }
}
