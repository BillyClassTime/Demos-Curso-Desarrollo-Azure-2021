using System;
using System.Threading.Tasks;
using Microsoft.Identity.Client;
using Microsoft.Graph;
using Microsoft.Graph.Auth;

namespace az204_authdemo
{
    class Program
    {
        private const string _clientId = "8828cf8e-f6c8-4c40-b96d-6541f3725aaa";
        private const string _tenantId = "76e33ecd-ff5e-4586-aba4-91ad060f2679";

        public static async Task Main(string[] args)
        {
            var app = PublicClientApplicationBuilder
            .Create(_clientId)
            .WithAuthority(AzureCloudInstance.AzurePublic, _tenantId)
            .WithRedirectUri("http://localhost")
            .Build();

            string[] scopes = { "user.read" };

            /*AuthenticationResult result = await app.AcquireTokenInteractive(scopes).ExecuteAsync();

            Console.WriteLine($"Token:\t{result.AccessToken}");*/

            var provider = new InteractiveAuthenticationProvider(app, scopes);

            var client = new GraphServiceClient(provider);

            User me = await client.Me.Request().GetAsync();
            Console.WriteLine($"Display Name:\t{me.DisplayName}");

        }
    }
}
