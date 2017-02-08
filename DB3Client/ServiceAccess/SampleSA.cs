using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace DB3Client.ServiceAccess
{
    public class SampleSA
    {
        /// <summary>
        /// Gets the channels.
        /// </summary>
        /// <returns></returns>
        public async static Task<List<int>> GetChannels()
        {
            List<int> channels = new List<int>();
            HttpResponseMessage response;

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("randomUrl");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic");

                try
                {
                    response = await client.GetAsync("api/channels");
                }
                catch (HttpRequestException ex)
                {
                    throw new Exception(ex.InnerException.Message);
                }

                if (response.IsSuccessStatusCode)
                {
                    channels = await response.Content.ReadAsAsync<List<int>>();
                }
                else
                {
                    string error = await response.Content.ReadAsAsync<string>();
                    if (error != null)
                        throw new Exception(error);
                    else
                        throw new Exception(response.ReasonPhrase);
                }
            }

            return channels;
        }
    }
}
