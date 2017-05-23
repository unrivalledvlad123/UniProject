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
    class SAOwner
    {
        public static async Task<CompanyOwner> getOwner(Guid ownerId)
        {
            CompanyOwner owner = new CompanyOwner();
            HttpResponseMessage response;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(DataHolder.ServerAddress);
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

        public static async Task<bool> PostUpdateOwner(CompanyOwner owner)
        {
            HttpResponseMessage response;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(DataHolder.ServerAddress);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic");

                try
                {
                    response = await client.PostAsJsonAsync("api/owner/update", owner);
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

        public static async Task<List<CommonMol>> getAllMols(Guid ownerId)
        {
            List<CommonMol> mols = new List<CommonMol>();
            HttpResponseMessage response;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(DataHolder.ServerAddress);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic");

                try
                {
                    response = await client.GetAsync("api/owner/mols/" + ownerId);
                }
                catch (HttpRequestException ex)
                {
                    throw new Exception(ex.InnerException.Message);
                }

                if (response.IsSuccessStatusCode)
                {
                    mols = await response.Content.ReadAsAsync<List<CommonMol>>();
                }

            }
            return mols;
        }

        public static async Task<bool> PostCreateMol(CommonMol mol)
        {
            HttpResponseMessage response;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(DataHolder.ServerAddress);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic");

                try
                {
                    response = await client.PostAsJsonAsync("api/owner/createmol", mol);
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

        public static async Task<bool> PostUpdateMol(CommonMol mol)
        {
            HttpResponseMessage response;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(DataHolder.ServerAddress);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic");

                try
                {
                    response = await client.PostAsJsonAsync("api/owner/updatemol", mol);
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

        public static async Task<bool> PostDeleteMol(Guid molId)
        {
            HttpResponseMessage response;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(DataHolder.ServerAddress);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic");

                try
                {
                    response = await client.PostAsJsonAsync("api/owner/deletemol", molId);
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

        public static async Task<CommonMol> SetPrimery(CommonMol oldMol, CommonMol newMol)
        {
            CommonMol mol = new CommonMol();
            List<Guid>  ids = new List<Guid>();
            ids.Add(oldMol.MolId);
            ids.Add(newMol.MolId);
            HttpResponseMessage response;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(DataHolder.ServerAddress);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic");

                try
                {
                    response = await client.PostAsJsonAsync("api/owner/changeprimery", ids);
                }
                catch (HttpRequestException ex)
                {
                    throw new Exception(ex.InnerException.Message);
                }

                if (response.IsSuccessStatusCode)
                {
                    mol = await response.Content.ReadAsAsync<CommonMol>();
                }

            }
            return mol;
        }

    }
}
