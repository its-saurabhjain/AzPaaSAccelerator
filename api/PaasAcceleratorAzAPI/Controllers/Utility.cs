using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PaasAcceleratorAzAPI.Controllers
{
    public static class Utility
    {
        internal static readonly HttpClient client = new HttpClient();
        internal static async Task<string> GetAADTokenRequest()
        {
            string appId = "4cadb99f-0865-4826-b447-f17b54282f31";
            string password = "fdee6d30-h8e6-d4d3-154f-3e96bd217a5c";
            string tenant = "f6558bc6-f9fe-49ec-947a-f104c43a40bd";
            string mgmtRes = "https://management.azure.com/";
            string resultContent;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://login.microsoftonline.com");
                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("client_id", appId),
                    new KeyValuePair<string, string>("client_secret", password),
                    new KeyValuePair<string, string>("grant_type", "client_credentials"),
                    new KeyValuePair<string, string>("resource", mgmtRes),

                });
                var result = await client.PostAsync(string.Format("/{0}/oauth2/token", tenant), content);
                resultContent = await result.Content.ReadAsStringAsync();

            }
            return resultContent;
        }
        internal static string getBearerToken(string access_token)
        {
            dynamic data = JObject.Parse(access_token);
            return data.access_token;
        }

        //Get list of subscriptions
        internal static async Task<IEnumerable<string>> getSubscriptionList()
        {
            //
            string bearerToken = getBearerToken(await GetAADTokenRequest());

            string sub = "https://management.azure.com/subscriptions?api-version=2016-06-01";
            List<string> subscriptions = new List<string>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://management.azure.com");
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + bearerToken);
                var result = await client.GetAsync(sub);
                var resultContent = await result.Content.ReadAsStringAsync();
                subscriptions.Add(resultContent.ToString());
            }
            return subscriptions;
        }
    }
}
