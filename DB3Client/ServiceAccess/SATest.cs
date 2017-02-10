using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DB3Client.ServiceAccess
{
    class SATest
    {
        public async static Task<string> GetTest()
        {
            string test = null;
           HttpResponseMessage response;

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:9000/");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic");

                try
                {
                    response = await client.GetAsync("api/test");
                }
                catch (HttpRequestException ex)
                {
                    throw new Exception(ex.InnerException.Message);
                }

                if (response.IsSuccessStatusCode)
                {
                    test = await response.Content.ReadAsAsync<string>();
                }
                else
                {
                    string error = await response.Content.ReadAsAsync<string>();
                    if (error != null)
                        throw new Exception(error);
                }
            }

            return test;
        }
    }
}
