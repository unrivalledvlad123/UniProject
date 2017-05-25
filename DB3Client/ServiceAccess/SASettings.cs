using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Common;
using Common.Classes;

namespace DB3Client.ServiceAccess
{
    public class SASettings
    {
        public static async Task<CommonSettings> getUserSettings()
        {
            CommonSettings result = new CommonSettings();
            HttpResponseMessage response;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(DataHolder.ServerAddress);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic");

                try
                {
                    response = await client.GetAsync("api/settings/getall");
                }
                catch (HttpRequestException ex)
                {
                    throw new Exception(ex.InnerException.Message);
                }

                if (response.IsSuccessStatusCode)
                {
                    result = await response.Content.ReadAsAsync<CommonSettings>();
                }

            }
            return result;
        }

        public static async Task<bool> PostUpdateSettings(KeyValuePair<int,decimal> pair )
        {
            HttpResponseMessage response;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(DataHolder.ServerAddress);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic");

                try
                {
                    response = await client.PostAsJsonAsync("api/settings/update", pair);
                }
                catch (HttpRequestException ex)
                {
                    throw new Exception(ex.InnerException.Message);
                }

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                return await response.Content.ReadAsAsync<bool>();
            }
        }

    }
}
