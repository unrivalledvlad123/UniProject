using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
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
                                    element.Name = dbItem.Name;
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
                                element.Name = item.Item.Name;
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
                                    element.Name = dbItem.Name;
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
                                element.Name = item.Item.Name;
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
                                    element.Name = dbItem.Name;
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
                                    element.Name = dbItem.Name;
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
                                element.Name = item.Item.Name;
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
                                element.Name = item.Item.Name;
                                result.Add(element);
                            }
                        }
                    }
                    
                    break;
            }
            return result;
        }

        internal static Dictionary<string,int> GenerateDiagram(DiagramDTO dto)
        {
            Dictionary<string,int> results = new Dictionary<string, int>();
            DatabaseEntities entities = new DatabaseEntities();
            if (dto.ReportType == 0)
            {
                List<Purchase> dbSet = new List<Purchase>(entities.Purchases.Where(p => p.Date >= dto.FromDate && p.Date <= dto.ToDate));
                foreach (Purchase purchase in dbSet)
                {
                    if (!dto.IsType) // for all
                    {
                        foreach (var item in purchase.PurchasedItems)
                        {
                            Item dbItem = entities.Items.FirstOrDefault(p => p.ItemId == item.ItemId);
                            if (dbItem != null && results.ContainsKey(dbItem.Type.Value.ToString()))
                            {
                                results[dbItem.Type.ToString()] = (int) (results[dbItem.Type.ToString()] + item.Quantity * item.Price);
                            }
                            else
                            {
                                if (dbItem != null) results.Add(dbItem.Type.ToString(), (int) (item.Quantity * item.Price));
                            }
                        }
                    }
                    else // specific type
                    {
                        foreach (var item in purchase.PurchasedItems)
                        {
                            Item dbItem = entities.Items.FirstOrDefault(p => p.ItemId == item.ItemId);
                            if (dbItem != null && dbItem.Type == dto.ItemType)
                            {
                                if (results.ContainsKey(dbItem.Name))
                                {
                                    results[dbItem.Name] = (int) (results[dbItem.Name] + item.Quantity * item.Price);
                                }
                                else
                                {
                                    results.Add(dbItem.Name, (int) (item.Quantity * item.Price));
                                }
                            }
                        }
                    }
                }
            }
            else if (dto.ReportType == 1)
            {
                List<Sale> dbSet = new List<Sale>(entities.Sales.Where(p => p.Date >= dto.FromDate && p.Date <= dto.ToDate));
                foreach (Sale purchase in dbSet)
                {
                    if (!dto.IsType) // for all
                    {
                        foreach (var item in purchase.SoldItems)
                        {
                            Item dbItem = entities.Items.FirstOrDefault(p => p.ItemId == item.ItemId);
                            if (dbItem != null && results.ContainsKey(dbItem.Type.Value.ToString()))
                            {
                                results[dbItem.Type.ToString()] = (int) (results[dbItem.Type.ToString()] + item.Quantity * item.Price);
                            }
                            else
                            {
                                if (dbItem != null) results.Add(dbItem.Type.ToString(), (int) (item.Quantity * item.Price));
                            }
                        }
                    }
                    else // specific type
                    {
                        foreach (var item in purchase.SoldItems)
                        {
                            Item dbItem = entities.Items.FirstOrDefault(p => p.ItemId == item.ItemId);
                            if (dbItem != null && dbItem.Type == dto.ItemType)
                            {
                                if (results.ContainsKey(dbItem.Name))
                                {
                                    results[dbItem.Name] = (int) (results[dbItem.Name] + item.Quantity * item.Price);
                                }
                                else
                                {
                                    results.Add(dbItem.Name, (int) (item.Quantity * item.Price));
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                return null;
            }

            return results;
        }

        internal static List<ReportMovement> GenerateDiagramMovement(DiagramDTO dto)
        {
            DatabaseEntities entities = new DatabaseEntities();
            List<ReportMovement> results = new List<ReportMovement>();
            if (!dto.IsType)
            {
                foreach (var type in entities.ItemTypesDDS)
                {
                    ReportMovement temp = new ReportMovement();
                    temp.Name = type.Type.ToString();
                    temp.QuantityesList = new Dictionary<DateTime, int>();
                    for (var dt = dto.FromDate.Date; dt <= dto.ToDate.Date; dt = dt.AddDays(1))
                    {
                        temp.QuantityesList.Add(dt, 0);
                    }
                    results.Add(temp);
                }
            }
            else
            {
                List<Item> allItems = entities.Items.Where(p => p.Type.Value == dto.ItemType).ToList();
                foreach (var item in allItems)
                {
                    ReportMovement temp = new ReportMovement();
                    temp.Name = item.Name;
                    temp.QuantityesList = new Dictionary<DateTime, int>();
                    for (var dt = dto.FromDate.Date; dt <= dto.ToDate.Date; dt = dt.AddDays(1))
                    {
                        temp.QuantityesList.Add(dt, 0);
                    }
                    results.Add(temp);
                }
            }

            if (dto.ReportType == 0)
            {
                List<Purchase> dbSet = new List<Purchase>(entities.Purchases.Where(p => p.Date >= dto.FromDate && p.Date <= dto.ToDate));
                foreach (Purchase purchase in dbSet)
                {
                    if (!dto.IsType) // for all
                    {
                        foreach (var item in purchase.PurchasedItems)
                        {
                            Item dbItem = entities.Items.FirstOrDefault(p => p.ItemId == item.ItemId);
                            ReportMovement element = results.FirstOrDefault(p => p.Name == dbItem.Type.Value.ToString());
                            if (element != null && dbItem != null && element.QuantityesList.ContainsKey(purchase.Date.Date))
                            {
                                element.QuantityesList[purchase.Date.Date] = element.QuantityesList[purchase.Date.Date] + item.Quantity;
                            }
                            else
                            {
                                element.QuantityesList[purchase.Date.Date] = element.QuantityesList[purchase.Date.Date] + item.Quantity;
                            }
                        }
                    }
                    else // specific type
                    {
                        foreach (var item in purchase.PurchasedItems)
                        {
                            Item dbItem = entities.Items.FirstOrDefault(p => p.ItemId == item.ItemId);
                            ReportMovement element = results.FirstOrDefault(p => p.Name == dbItem.Name);
                            if (dbItem != null &&element!=null && dbItem.Type == dto.ItemType)
                            {
                                if (element.QuantityesList.ContainsKey(purchase.Date.Date))
                                {
                                    element.QuantityesList[purchase.Date.Date] = element.QuantityesList[purchase.Date.Date] + item.Quantity;
                                }
                                else
                                {
                                    element.QuantityesList[purchase.Date.Date] = element.QuantityesList[purchase.Date.Date] + item.Quantity;
                                }
                            }
                        }
                    }
                }
            }
            else if (dto.ReportType == 1)
            {
                List<Sale> dbSet = new List<Sale>(entities.Sales.Where(p => p.Date >= dto.FromDate && p.Date <= dto.ToDate));
                foreach (Sale sale in dbSet)
                {
                    if (!dto.IsType) // for all
                    {
                        foreach (var item in sale.SoldItems)
                        {
                            Item dbItem = entities.Items.FirstOrDefault(p => p.ItemId == item.ItemId);
                            ReportMovement element = results.FirstOrDefault(p => p.Name == dbItem.Type.Value.ToString());
                            if (element != null && dbItem != null && element.QuantityesList.ContainsKey(sale.Date.Date))
                            {
                                element.QuantityesList[sale.Date.Date] = element.QuantityesList[sale.Date.Date] + item.Quantity;
                            }
                            else
                            {
                                element.QuantityesList[sale.Date.Date] = element.QuantityesList[sale.Date.Date] + item.Quantity;
                            }
                        }
                    }
                    else // specific type
                    {
                        foreach (var item in sale.SoldItems)
                        {
                            Item dbItem = entities.Items.FirstOrDefault(p => p.ItemId == item.ItemId);
                            ReportMovement element = results.FirstOrDefault(p => p.Name == dbItem.Name);
                            if (dbItem != null && element != null && dbItem.Type == dto.ItemType)
                            {
                                if (element.QuantityesList.ContainsKey(sale.Date.Date))
                                {
                                    element.QuantityesList[sale.Date.Date] = element.QuantityesList[sale.Date.Date] + item.Quantity;
                                }
                                else
                                {
                                    element.QuantityesList[sale.Date.Date] = element.QuantityesList[sale.Date.Date] + item.Quantity;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                return null;
            }

            return results;
        }



    }
}
