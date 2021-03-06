﻿using System;
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
    class SASale
    {
        public static async Task<CommonSale> PostCreateDirectSale(CommonSale sales)
        {
            HttpResponseMessage response;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(DataHolder.ServerAddress);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic");

                try
                {
                    response = await client.PostAsJsonAsync("api/sales/create-direct", sales);
                }
                catch (HttpRequestException ex)
                {
                    throw new Exception(ex.InnerException.Message);
                }

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<CommonSale>();
                }
                return null;
            }
        }
        public static async Task<CommonSale> PostCreateWholeSale(CommonSale sales)
        {
            HttpResponseMessage response;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(DataHolder.ServerAddress);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic");

                try
                {
                    response = await client.PostAsJsonAsync("api/sales/create-whole", sales);
                }
                catch (HttpRequestException ex)
                {
                    throw new Exception(ex.InnerException.Message);
                }

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<CommonSale>();
                }
                return null;
            }
        }

        public static async Task<List<CommonSale>> GetAllSales(String search)
        {
            List<CommonSale> allSales = new List<CommonSale>();
            HttpResponseMessage response;

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(DataHolder.ServerAddress);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic");

                try
                {
                    response = await client.GetAsync("api/sales/list" + (String.IsNullOrEmpty(search) ? "" : ("/" + search)));
                }
                catch (HttpRequestException ex)
                {
                    throw new Exception(ex.InnerException.Message);
                }

                if (response.IsSuccessStatusCode)
                {
                    allSales = await response.Content.ReadAsAsync<List<CommonSale>>();
                }
            }
            return allSales;
        }

        public static async Task<CommonInvoice> GetInvoice(Guid SaleId)
        {
            CommonInvoice invoice = new CommonInvoice();
            HttpResponseMessage response;

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(DataHolder.ServerAddress);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic");

                try
                {
                    response = await client.GetAsync("api/sales/invoice/" + SaleId);
                }
                catch (HttpRequestException ex)
                {
                    throw new Exception(ex.InnerException.Message);
                }

                if (response.IsSuccessStatusCode)
                {
                    invoice = await response.Content.ReadAsAsync<CommonInvoice>();
                }
            }
            return invoice;
        }

        public static async Task<CommonWarehouseReceipt> GetReceipt(Guid SaleId)
        {
            CommonWarehouseReceipt receipt = new CommonWarehouseReceipt();
            HttpResponseMessage response;

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(DataHolder.ServerAddress);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic");

                try
                {
                    response = await client.GetAsync("api/sales/receipt/" + SaleId);
                }
                catch (HttpRequestException ex)
                {
                    throw new Exception(ex.InnerException.Message);
                }

                if (response.IsSuccessStatusCode)
                {
                    receipt = await response.Content.ReadAsAsync<CommonWarehouseReceipt>();
                }
            }
            return receipt;
        }
    }
}
