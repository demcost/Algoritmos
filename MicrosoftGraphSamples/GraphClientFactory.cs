using Microsoft.Graph;
using Microsoft.Identity.Client;
using MicrosoftGraphSamples.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MicrosoftGraphSamples
{
	public static class GraphClientFactory
	{		
		public static GraphServiceClient GetGraphServiceClient(string clientId, string authority, IEnumerable<string> scopes, string clientSecret)
		{		
			var authenticationProvider = CreateAuthorizationProvider(clientId, authority, scopes, clientSecret);
			return new GraphServiceClient(authenticationProvider);
		}
		
		private static IAuthenticationProvider CreateAuthorizationProvider(string clientId, string authority, IEnumerable<string> scopes, string clientSecret)
		{
            IConfidentialClientApplication clientApplication;
            clientApplication = ConfidentialClientApplicationBuilder.Create(clientId)
                                                      .WithClientSecret(clientSecret)
                                                      .WithAuthority(new Uri(authority))
                                                      .Build();


  			return new MsalAuthenticationProvider(clientApplication, scopes.ToArray());		
		}
	}
}
