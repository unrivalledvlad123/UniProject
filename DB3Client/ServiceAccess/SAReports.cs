using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Common;
using Common.Classes.DTOs;
using Common.Classes.ReportClasses;

namespace DB3Client.ServiceAccess
{
    public class SAReports
    {
        public static async Task<List<ReportBuySell>> PostGenerateReport(ReportDTO dto)
        {
            HttpResponseMessage response;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(DataHolder.ServerAddress);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic");

                try
                {
                    response = await client.PostAsJsonAsync("api/reports/generate", dto);
                }
                catch (HttpRequestException ex)
                {
                    throw new Exception(ex.InnerException.Message);
                }

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<List<ReportBuySell>>();
                }
                return null;
            }
        }
    }
}
