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
                bool checker = true;
                DatabaseEntities entities = new DatabaseEntities();
                foreach (var item in sale.SoldItems)
                {
                    WarehouseItem whItem = entities.WarehouseItems.FirstOrDefault(p => p.ItemId == item.ItemId);
                    if (whItem?.Quantity < item.Quantity)
                    {
                        checker = false;  
                    }
                }

                if (checker)
                {
                    foreach (var item in sale.SoldItems)
                    {
                        WarehouseItem whItem = entities.WarehouseItems.FirstOrDefault(p => p.ItemId == item.ItemId);
                        if (whItem != null)
                        {
                            whItem.Quantity = whItem.Quantity.Value - item.Quantity;
                            entities.WarehouseItems.Attach(whItem);
                            var entry = entities.Entry(whItem);
                            entry.Property(e => e.Quantity).IsModified = true;
                        }
                    }

                    Sale s = new Sale();
                    s.BuyerId = sale.BuyerId;
                    s.Date = DateTime.Now;
                    s.InvoiceId = null;
                    s.SellerId = sale.SellerId;
                    s.SoldItems = new List<SoldItem>();
                    Guid tempGuid = NewGuid();
                    s.SaleId = tempGuid;
                    ////
                    //// FIX payment completed after payment completed interface is ready. for now all are true;
                    ////
                    s.PaymentCompleted = true;
                    ////
                    ////
                    /////
                    foreach (var item in sale.SoldItems)
                    {
                        var i = new SoldItem
                        {
                            ItemId = item.ItemId,
                            Price = item.Price*100,
                            Quantity = item.Quantity,
                            SaleId = s.SaleId,
                            SoldItemId = NewGuid()
                        };

                        s.SoldItems.Add(i);
                    }

                    if (isWhole)
                    {
                        var invoice = new Invoice();
                        invoice.PartnerId = s.BuyerId;
                        invoice.OwnerId = s.SellerId;
                        invoice.SaleId = s.SaleId;
                        invoice.InvoiceId = NewGuid();

                        invoice.InvoiceNumber = entities.Invoices.DefaultIfEmpty().Max(p => p == null ? 0 : p.InvoiceNumber) + 1;
                        Partner partner = entities.Partners.FirstOrDefault(p => p.PartnerId == s.BuyerId);

                        if (partner != null)
                        {
                            invoice.BuyerAddress = partner.Address;
                            invoice.BuyerBulstat = partner.Bulstat;
                            invoice.BuyerCompanyName = partner.CompanyName;
                            invoice.BuyerVATNumber = partner.VATNumber;
                            MOL mol = entities.MOLs.FirstOrDefault(p => p.OwnerId == partner.PartnerId);
                            invoice.BuyerMol = mol != null ? $"{mol.FirstName} {mol.LastName}" : "";
                            decimal counter = 0;
                            foreach (var item in s.SoldItems)
                            {
                                WarehouseItem whItem = entities.WarehouseItems.FirstOrDefault(p => p.ItemId == item.ItemId);
                                counter += ((decimal) whItem.SellingPriceCent.Value / 100) * item.Quantity;
                            }
                            partner.Sum += counter;
                            List<PartnerDiscount> discount = entities.PartnerDiscounts.ToList();
                            foreach (PartnerDiscount t in discount)
                            {
                                if (partner.Sum >= t.RangeFrom && partner.Sum <= t.RangeTo)
                                {
                                    if (partner.PartnerType == t.PartnerType)
                                    {
                                        invoice.DiscountPercent = t.Discount;
                                    }
                                    else
                                    {
                                        partner.PartnerType = t.PartnerType;
                                        invoice.DiscountPercent = t.Discount;
                                    }
                                }
                            }
                            entities.Partners.Attach(partner);
                            var entry = entities.Entry(partner);
                            entry.Property(e => e.Sum).IsModified = true;
                            entry.Property(e => e.PartnerType).IsModified = true;
                            entities.SaveChanges();
                        }
                        Owner owner = entities.Owners.First();
                        invoice.OwnerAddress = owner.Address;
                        invoice.OwnerBank = owner.Bank;
                        invoice.OwnerBulstat = owner.Bulstat;
                        invoice.OwnerIBAN = owner.IBAN;
                        invoice.OwnerCompanyName = owner.CompanyName;
                        invoice.OwnerSwiftCode = owner.SWIFTCode;
                        invoice.OwnerVATNumber = owner.VATNumber;
                        MOL mol2 = entities.MOLs.FirstOrDefault(p => p.OwnerId == owner.OwnerId && p.IsPrimary);
                        if (mol2 != null)
                        {
                            invoice.OwnerMol = $"{mol2.FirstName} {mol2.LastName}";
                        }

                        s.Invoice = invoice;
                    }

                    entities.Sales.Add(s);
                    entities.SaveChanges();

                    sale.Date = s.Date;
                    sale.BuyerId = s.BuyerId;
                    sale.SaleId = s.SaleId;
                    sale.SellerId = s.SellerId;
                    sale.Type = s.Type;
                    if (isWhole)
                    {
                        sale.InvoiceId = s.Invoice.InvoiceNumber.ToString();
                    }
                    
                    sale.SoldItems = new List<CommonSoldItem>();
                    //// FIx payment completed 
                    sale.PaymentCompleted = true;

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
                return null;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        internal static List<CommonSale> GetAllSales(string search)
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
                sale.InvoiceId = dbSale.Invoice?.InvoiceNumber.ToString();
                sale.SaleId = dbSale.SaleId;
                sale.SellerId = dbSale.SellerId;
                sale.Type = dbSale.Type;
                sale.PaymentCompleted = dbSale.PaymentCompleted;
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

        internal static CommonInvoice GetInvoice(Guid saleId)
        {
            CommonInvoice result = new CommonInvoice();
            DatabaseEntities entities = new DatabaseEntities();
            Invoice invoice = entities.Invoices.FirstOrDefault(p => p.SaleId == saleId);
            if (invoice != null)
            {
                result.OwnerId = invoice.OwnerId;
                result.PartnerId = invoice.PartnerId;
                result.SaleId = invoice.SaleId;
                result.InvoiceId = invoice.InvoiceId;
                result.InvoiceNumber = invoice.InvoiceNumber;
                result.BuyerCompanyName = invoice.BuyerCompanyName;
                result.BuyerAddress = invoice.BuyerAddress;
                result.BuyerVATNumber = invoice.BuyerVATNumber;
                result.BuyerBulstat = invoice.BuyerBulstat;
                result.OwnerCompanyName = invoice.OwnerCompanyName;
                result.OwnerAddress = invoice.OwnerAddress;
                result.OwnerVATNumber = invoice.OwnerVATNumber;
                result.OwnerBulstat = invoice.OwnerBulstat;
                result.OwnerBank = invoice.OwnerBank;
                result.OwnerIBAN = invoice.OwnerIBAN;
                result.OwnerSwiftCode = invoice.OwnerSwiftCode;
                result.BuyerMol = invoice.BuyerMol;
                result.OwnerMol = invoice.OwnerMol;
                result.DiscountPercent = invoice.DiscountPercent.Value;
            }
            result.SoldItems = new List<CommonSoldItem>();
            return result;
        }

        internal static CommonWarehouseReceipt GetReceipt(Guid saleId)
        {
            CommonWarehouseReceipt result = new CommonWarehouseReceipt();
            DatabaseEntities entities = new DatabaseEntities();
            WarehouseReceipt receipt = entities.WarehouseReceipts.FirstOrDefault(p => p.SaleId == saleId);
            if (receipt != null)
            {
                result.OwnerId = receipt.OwnerId;
                result.PartnerId = receipt.PartnerId;
                result.SaleId = receipt.SaleId;
                result.WarehouseReceiptId = receipt.WarehouseReceiptId;
                result.WarehouseReceiptNumber = receipt.WarehouseReceiptNumber;
                result.BuyerCompanyName = receipt.BuyerCompanyName;
                result.BuyerAddress = receipt.BuyerAddress;
                result.BuyerVATNumber = receipt.BuyerVATNumber;
                result.BuyerBulstat = receipt.BuyerBulstat;
                result.OwnerCompanyName = receipt.OwnerCompanyName;
                result.OwnerAddress = receipt.OwnerAddress;
                result.OwnerVATNumber = receipt.OwnerVATNumber;
                result.OwnerBulstat = receipt.OwnerBulstat;
                result.BuyerMol = receipt.BuyerMol;
                result.OwnerMol = receipt.OwnerMol;
                result.DiscountPercent = receipt.DiscountPercent.Value;
            }
            result.SoldItems = new List<CommonSoldItem>();
            return result;
        }
    }
}
