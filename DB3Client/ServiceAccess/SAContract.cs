using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Common.Classes;

namespace DB3Client.ServiceAccess
{
    class SAContract
    {
        public static async Task<Guid> PostCreateContract(CommonContract contract)
        {
            HttpResponseMessage response;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:9000/");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic");

                try
                {
                    response = await client.PostAsJsonAsync("api/contract/create", contract);
                }
                catch (HttpRequestException ex)
                {
                    throw new Exception(ex.InnerException.Message);
                }

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<Guid>();
                }
                return await response.Content.ReadAsAsync<Guid>();
            }
        }

        public static async Task<bool> PostUpdateContract(CommonContract contract)
        {
            HttpResponseMessage response;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:9000/");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic");

                try
                {
                    response = await client.PostAsJsonAsync("api/contract/update", contract);
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

        public static async Task<List<CommonContract>> GetAllContracts(String search)
        {
            List<CommonContract> contracts = new List<CommonContract>();
            HttpResponseMessage response;

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:9000/");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic");

                try
                {
                    response = await client.GetAsync("api/contract/list" + (String.IsNullOrEmpty(search) ? "" : ("/" + search)));
                }
                catch (HttpRequestException ex)
                {
                    throw new Exception(ex.InnerException.Message);
                }

                if (response.IsSuccessStatusCode)
                {
                   contracts = await response.Content.ReadAsAsync<List<CommonContract>>();
                }
            }
            return contracts;
        }

       
    }
}
