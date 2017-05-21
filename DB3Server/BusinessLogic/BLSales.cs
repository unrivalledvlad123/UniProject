using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebPages;
using Common.Classes;
using static System.Guid;

namespace DB3Server.BusinessLogic
{
    class BLSales
    {
        internal static CommonSale CreateSale(CommonSale sale, bool isWhole = false)
        {
            try
            {
                DatabaseEntities entities = new DatabaseEntities();

                Sale s = new Sale();
                s.BuyerId = sale.BuyerId;
                s.Date = DateTime.Now;
                s.InvoiceId = null;
                s.SellerId = sale.SellerId;
                s.SoldItems = new List<SoldItem>();
                Guid tempGuid = NewGuid();
                s.SaleId = tempGuid;
                foreach (var item in sale.SoldItems)
                {
                    var i = new SoldItem
                    {
                        ItemId = item.ItemId,
                        Price = item.Price,
                        Quantity = item.Quantity,
                        SaleId = s.SaleId,
                        SoldItemId = Guid.NewGuid()
                        

                    };
                   
                    s.SoldItems.Add(i);
//                    entities.SoldItems.Add(i);

                }

                if (isWhole)
                {
                    var max = entities.Invoices.Max(h => (long?) h.InvoiceId);
                   long id =  (max == null? 0 : (long) max) + 1;
                   var invoice = new Invoice();
                    invoice.PartnerId = s.BuyerId;
                    invoice.OwnerId = s.SellerId;
                    invoice.SaleId = s.SaleId;
                    invoice.InvoiceId = id;
                    s.Invoice = invoice;
                }

                entities.Sales.Add(s);
                entities.SaveChanges();

                sale.Date = s.Date;
                sale.BuyerId = s.BuyerId;
                sale.SaleId = s.SaleId;
                sale.SellerId = s.SellerId;
                sale.Type = s.Type;
                sale.InvoiceId = s.InvoiceId.ToString();
                sale.SoldItems = new List<CommonSoldItem>();
                foreach (var h in s.SoldItems)
                {
                    var item = new CommonSoldItem();
                    item.ItemId = h.ItemId;
                    item.Price = h.Price;
                    item.Quantity = h.Quantity;
                    item.SaleId = h.SaleId;
                    sale.SoldItems.Add(item);
                }



                return sale;
            }
            catch (Exception e)
            {
                return null;
            }

        }
        internal static List<CommonSale> GetAllSales(String search)
        {
            DatabaseEntities entities = new DatabaseEntities();
            List<Sale> allDbSales = new List<Sale>();
            if (search.IsEmpty())
            {
                allDbSales = entities.Sales.ToList();
            }
            else
            {
                allDbSales = entities.Sales
                    .Include(p => p.Partner)
                    .Where(p => p.Partner.CompanyName.Contains(search))
                    .ToList();
            }

            List<CommonSale> allSales = new List<CommonSale>();
            foreach (var dbSale in allDbSales)
            {
                CommonSale sale = new CommonSale();
                sale.BuyerId = dbSale.BuyerId;
                sale.Date = dbSale.Date;
                sale.InvoiceId = dbSale.InvoiceId.ToString();
                sale.SaleId = dbSale.SaleId;
                sale.SellerId = dbSale.SellerId;
                sale.Type = dbSale.Type;
                allSales.Add(sale);

                sale.SoldItems = new List<CommonSoldItem>();
                foreach (var h in dbSale.SoldItems)
                {
                    var item = new CommonSoldItem();
                    item.ItemId = h.ItemId;
                    item.Price = h.Price;
                    item.Quantity = h.Quantity;
                    item.SaleId = h.SaleId;
                    sale.SoldItems.Add(item);
                
                }
                sale.BuyerCompanyName = dbSale.Partner.CompanyName;
            }
            return allSales;
        }
    }
}
