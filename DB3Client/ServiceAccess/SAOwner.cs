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
    class SAOwner
    {
        public static async Task<CompanyOwner> getOwner(Guid ownerId)
        {
            CompanyOwner owner = new CompanyOwner();
            HttpResponseMessage response;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:9000/");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic");

                try
                {
                    response = await client.GetAsync("api/owner/" + ownerId);
                }
                catch (HttpRequestException ex)
                {
                    throw new Exception(ex.InnerException.Message);
                }

                if (response.IsSuccessStatusCode)
                {
                    owner = await response.Content.ReadAsAsync<CompanyOwner>();
                }
                
            }
            return owner;
        }

    }
}
