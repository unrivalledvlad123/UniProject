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
    public class SAUsers
    {

        public static async Task<bool> PostCreateUser(CommonUser user)
        {
            bool success = false;
            HttpResponseMessage response;

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:9000/");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic");

                try
                {
                    response = await client.PostAsJsonAsync("api/users/create", user);
                }
                catch (HttpRequestException ex)
                {
                    throw new Exception(ex.InnerException.Message);
                }

                if (response.IsSuccessStatusCode)
                {
                    success = await response.Content.ReadAsAsync<bool>();
                }
            }

            return success;
        }

        public static async Task<bool> PostEditUser(CommonUser user)
        {
            bool success = false;
            HttpResponseMessage response;

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:9000/");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic");

                try
                {
                    response = await client.PostAsJsonAsync("api/users/edit", user);
                }
                catch (HttpRequestException ex)
                {
                    throw new Exception(ex.InnerException.Message);
                }

                if (response.IsSuccessStatusCode)
                {
                    success = await response.Content.ReadAsAsync<bool>();
                }
            }

            return success;
        }

        public static async Task<bool> PostDeleteUser(Guid userId)
        {
            bool success = false;
            HttpResponseMessage response;

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:9000/");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic");

                try
                {
                    response = await client.PostAsJsonAsync("api/users/delete", userId);
                }
                catch (HttpRequestException ex)
                {
                    throw new Exception(ex.InnerException.Message);
                }

                if (response.IsSuccessStatusCode)
                {
                    success = await response.Content.ReadAsAsync<bool>();
                }
            }

            return success;
        }
        public static async Task<CommonUser> Login(string username, string password)
        {
           CommonUser user = new CommonUser();
           HttpResponseMessage response;

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:9000/");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic");

                try
                {
                    response = await client.GetAsync("api/users/login/" + username + "/" + password);
                }
                catch (HttpRequestException ex)
                {
                    throw new Exception(ex.InnerException.Message);
                }

                if (response.IsSuccessStatusCode)
                {
                    user = await response.Content.ReadAsAsync<CommonUser>();
                }
            }

            return user;
        }

        public static async Task<List<CommonUser>> GetAllUsers(Guid ownerId)
        {
            List<CommonUser> users = new List<CommonUser>();
            HttpResponseMessage response;

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:9000/");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic");

                try
                {
                    response = await client.GetAsync("api/users/allusers/" + ownerId);
                }
                catch (HttpRequestException ex)
                {
                    throw new Exception(ex.InnerException.Message);
                }

                if (response.IsSuccessStatusCode)
                {
                    users = await response.Content.ReadAsAsync<List<CommonUser>>();
                }
            }
            return users;
        }



    }

}
