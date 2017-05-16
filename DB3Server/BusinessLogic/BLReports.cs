using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Common.Classes.DTOs;
using Common.Classes.ReportClasses;

namespace DB3Server.BusinessLogic
{
    public class BLReports
    {
        internal static List<ReportBuySell> GenerateReport(ReportDTO request)
        {
            DatabaseEntities entities = new DatabaseEntities();
            List<ReportBuySell> result = new List<ReportBuySell>();
            switch (request.ReportType)
            {
                case 0:
                    if (request.IsItem)
                    {
                        List<Purchase> dbSet = new List<Purchase>(entities.Purchases.Where(p => p.Date >= request.FromDate && p.Date <= request.ToDate));
                        foreach (Purchase purchase in dbSet)
                        {
                            List<PurchasedItem> items = purchase.PurchasedItems.ToList();
                            foreach (var item in items)
                            {
                                Item dbItem = entities.Items.FirstOrDefault(p => p.ItemCode == request.ItemCode);
                                if (dbItem != null)
                                {
                                    ReportBuySell element = new ReportBuySell();
                                    element.Date = purchase.Date;
                                    element.PriceEach = item.Price;
                                    element.Unit = dbItem.MeasurmentUnit ?? 0;
                                    element.Quantity = item.Quantity;
                                    element.Total = item.Quantity * item.Price;
                                    result.Add(element);
                                }
                            }
                        }
                    }
                    else
                    {
                        List<Purchase> dbSet = new List<Purchase>(entities.Purchases.Where(p => p.Date >= request.FromDate && p.Date <= request.ToDate));
                        foreach (Purchase purchase in dbSet)
                        {
                            List<PurchasedItem> items = purchase.PurchasedItems.Where(p => p.Item.Type == request.ItemType).ToList();
                            foreach (var item in items)
                            {
                                ReportBuySell element = new ReportBuySell();
                                element.Date = purchase.Date;
                                element.PriceEach = item.Price;
                                element.Unit = item.Item.MeasurmentUnit ?? 0;
                                element.Quantity = item.Quantity;
                                element.Total = item.Quantity * item.Price;
                                result.Add(element);
                            }
                        }
                    }

                    break;
                case 1:
                    if (request.IsItem)
                    {
                        List<Sale> dbSet = new List<Sale>(entities.Sales.Where(p => p.Date >= request.FromDate && p.Date <= request.ToDate));
                        foreach (Sale sale in dbSet)
                        {
                            List<SoldItem> items = sale.SoldItems.ToList();
                            foreach (var item in items)
                            {
                                Item dbItem = entities.Items.FirstOrDefault(p => p.ItemCode == request.ItemCode);
                                if (dbItem != null)
                                {
                                    ReportBuySell element = new ReportBuySell();
                                    element.Date = sale.Date;
                                    element.PriceEach = item.Price;
                                    element.Unit = dbItem.MeasurmentUnit ?? 0;
                                    element.Quantity = item.Quantity;
                                    element.Total = item.Quantity * item.Price;
                                    result.Add(element);
                                }
                            }
                        }
                    }
                    else
                    {
                        List<Sale> dbSet = new List<Sale>(entities.Sales.Where(p => p.Date >= request.FromDate && p.Date <= request.ToDate));
                        foreach (Sale sale in dbSet)
                        {
                            List<SoldItem> items = sale.SoldItems.Where(p => p.Item.Type == request.ItemType).ToList();
                            foreach (var item in items)
                            {
                                ReportBuySell element = new ReportBuySell();
                                element.Date = sale.Date;
                                element.PriceEach = item.Price;
                                element.Unit = item.Item.MeasurmentUnit ?? 0;
                                element.Quantity = item.Quantity;
                                element.Total = item.Quantity * item.Price;
                                result.Add(element);
                            }
                        }
                    }
                    
                    break;
                case 2:
                    if (request.IsItem)
                    {
                        List<Purchase> dbSet = new List<Purchase>(entities.Purchases.Where(p => p.Date >= request.FromDate && p.Date <= request.ToDate));
                        foreach (Purchase purchase in dbSet)
                        {
                            List<PurchasedItem> items = purchase.PurchasedItems.ToList();
                            foreach (var item in items)
                            {
                                Item dbItem = entities.Items.FirstOrDefault(p => p.ItemCode == request.ItemCode);
                                if (dbItem != null)
                                {
                                    ReportBuySell element = new ReportBuySell();
                                    element.Date = purchase.Date;
                                    element.PriceEach = item.Price;
                                    element.Unit = dbItem.MeasurmentUnit ?? 0;
                                    element.Quantity = item.Quantity;
                                    element.Total = item.Quantity * item.Price;
                                    result.Add(element);
                                }
                            }
                        }
                        List<Sale> dbSet1 = new List<Sale>(entities.Sales.Where(p => p.Date >= request.FromDate && p.Date <= request.ToDate));
                        foreach (Sale sale in dbSet1)
                        {
                            List<SoldItem> items = sale.SoldItems.ToList();
                            foreach (var item in items)
                            {
                                Item dbItem = entities.Items.FirstOrDefault(p => p.ItemCode == request.ItemCode);
                                if (dbItem != null)
                                {
                                    ReportBuySell element = new ReportBuySell();
                                    element.Date = sale.Date;
                                    element.PriceEach = item.Price;
                                    element.Unit = dbItem.MeasurmentUnit ?? 0;
                                    element.Quantity = item.Quantity;
                                    element.Total = item.Quantity * item.Price;
                                    result.Add(element);
                                }
                            }
                        }
                    }
                    else
                    {
                        List<Purchase> dbSet = new List<Purchase>(entities.Purchases.Where(p => p.Date >= request.FromDate && p.Date <= request.ToDate));
                        foreach (Purchase purchase in dbSet)
                        {
                            List<PurchasedItem> items = purchase.PurchasedItems.Where(p => p.Item.Type == request.ItemType).ToList();
                            foreach (var item in items)
                            {
                                ReportBuySell element = new ReportBuySell();
                                element.Date = purchase.Date;
                                element.PriceEach = item.Price;
                                element.Unit = item.Item.MeasurmentUnit ?? 0;
                                element.Quantity = item.Quantity;
                                element.Total = item.Quantity * item.Price;
                                result.Add(element);
                            }
                        }
                        List<Sale> dbSet1 = new List<Sale>(entities.Sales.Where(p => p.Date >= request.FromDate && p.Date <= request.ToDate));
                        foreach (Sale sale in dbSet1)
                        {
                            List<SoldItem> items = sale.SoldItems.Where(p => p.Item.Type == request.ItemType).ToList();
                            foreach (var item in items)
                            {
                                ReportBuySell element = new ReportBuySell();
                                element.Date = sale.Date;
                                element.PriceEach = item.Price;
                                element.Unit = item.Item.MeasurmentUnit ?? 0;
                                element.Quantity = item.Quantity;
                                element.Total = item.Quantity * item.Price;
                                result.Add(element);
                            }
                        }
                    }
                    
                    break;
            }
            return result;
        }

















    }
}
