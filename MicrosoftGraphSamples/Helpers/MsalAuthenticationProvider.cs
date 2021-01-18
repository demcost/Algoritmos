

using Microsoft.Graph;
using Microsoft.Identity.Client;
using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace MicrosoftGraphSamples.Helpers
{
    public class MsalAuthenticationProvider : IAuthenticationProvider
    {
        private IConfidentialClientApplication _clientApplication;
        private string[] _scopes;

        public MsalAuthenticationProvider(IConfidentialClientApplication clientApplication, string[] scopes)
        {
            _clientApplication = clientApplication;
            _scopes = scopes;
        }

        /// <summary>
        /// Update HttpRequestMessage with credentials
        /// </summary>
        public async Task AuthenticateRequestAsync(HttpRequestMessage request)
        {
            var authentication = await GetAuthenticationAsync();
            request.Headers.Authorization = AuthenticationHeaderValue.Parse(authentication.CreateAuthorizationHeader());
        }

        /// <summary>
        /// Acquire Token for user
        /// </summary>
        public async Task<AuthenticationResult> GetAuthenticationAsync()
        {
            AuthenticationResult authResult = null;
            var accounts = await _clientApplication.GetAccountsAsync();

            try
            {
                var firstaccount = accounts.FirstOrDefault();

                authResult = await _clientApplication.AcquireTokenSilent(_scopes, firstaccount).ExecuteAsync();
            }
            catch (MsalUiRequiredException)
            {
                try
                {
                    authResult = await _clientApplication.AcquireTokenForClient(_scopes).ExecuteAsync();
                }
                catch (MsalException)
                {
                    throw;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }

            return authResult;
        }

    }
}
