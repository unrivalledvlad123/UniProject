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
    class SAItem
    {
        public static async Task<List<CommonItem>> GetAllItems(String search)
        {
            List<CommonItem> items = new List<CommonItem>();
            HttpResponseMessage response;

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(DataHolder.ServerAddress);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic");

                try
                {
                    response = await client.GetAsync("api/item/list" + (String.IsNullOrEmpty(search) ? "" : ("/" + search)));
                }
                catch (HttpRequestException ex)
                {
                    throw new Exception(ex.InnerException.Message);
                }

                if (response.IsSuccessStatusCode)
                {
                    items = await response.Content.ReadAsAsync<List<CommonItem>>();
                }
            }
            return items;
        }
        public static async Task<CommonItem> GetItemsById(String search)
        {
           
            HttpResponseMessage response;

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(DataHolder.ServerAddress);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic");

                try
                {
                    response = await client.GetAsync("api/item/get/" + search);
                }
                catch (HttpRequestException ex)
                {
                    throw new Exception(ex.InnerException.Message);
                }

                if (response.IsSuccessStatusCode)
                {
                     return await response.Content.ReadAsAsync<CommonItem>();
                }
            }
            return null;
        }
    }
}
