using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebPages;
using Common.Classes;

namespace DB3Server.BusinessLogic
{
    class BLItem
    {
        internal static List<CommonItem> GetAllItems(String search)
        {
            DatabaseEntities entities = new DatabaseEntities();
            List<Item> allDbItems = new List<Item>();
            if (search.IsEmpty())
            {
                allDbItems = entities.Items.ToList();
            }
            else
            {
                allDbItems = entities.Items.Where(p => p.Name.Contains(search)|| p.ItemCode.Contains(search)).ToList();
           
            }

            List<CommonItem> allItems = new List<CommonItem>();
            foreach (var dbItem in allDbItems)
            {
                
                CommonItem item1 = new CommonItem();
                item1.ItemId = dbItem.ItemId;
                item1.Name = dbItem.Name;
                item1.Description = dbItem.Description;
                item1.Type = (int) dbItem.Type;
                item1.ItemCode = dbItem.ItemCode;
                item1.MeasurmentUnit = (int) dbItem.MeasurmentUnit;
                var whItem = dbItem.WarehouseItem;
                if (whItem != null)
                {
                    item1.SellingPriceCent = (int)whItem.SellingPriceCent;
                    item1.Quantity = (int)whItem.Quantity;
                }
               
                allItems.Add(item1);
            }
            return allItems;
        }
        internal static CommonItem GetItemsById(String search)
        {
            DatabaseEntities entities = new DatabaseEntities();

            Item dbItem = entities.Items.Find(new Guid(search));
            if (dbItem != null)
            {

                CommonItem item1 = new CommonItem();
                item1.ItemId = dbItem.ItemId;
                item1.Name = dbItem.Name;
                item1.Description = dbItem.Description;
                item1.Type = (int)dbItem.Type;
                item1.ItemCode = dbItem.ItemCode;
                item1.MeasurmentUnit = (int)dbItem.MeasurmentUnit;
                var whItem = dbItem.WarehouseItem;
                if (whItem != null)
                {
                    item1.SellingPriceCent = (int)whItem.SellingPriceCent;
                    item1.Quantity = (int)whItem.Quantity;
                }

                return item1;

            }
            return null;
        }

        internal static List<KeyValuePair<Guid, List<CommonItem>>> GetAllItemsMapped()
        {
            List<KeyValuePair<Guid,List<CommonItem>>> result = new List<KeyValuePair<Guid, List<CommonItem>>>();
            DatabaseEntities entities = new DatabaseEntities();
            List<Partner> allPartners = entities.Partners.ToList();
            foreach (var partner in allPartners)
            {
                KeyValuePair<Guid, List<CommonItem>> pair = new KeyValuePair<Guid, List<CommonItem>>(partner.PartnerId, new List<CommonItem>());
                result.Add(pair);
            }
            List<PartnerItemMapping> mapping = entities.PartnerItemMappings.ToList();
            foreach (var row in mapping)
            {
                Item item = entities.Items.FirstOrDefault(p => p.ItemId == row.ItemId);
                CommonItem comItem = new CommonItem
                {
                    Description = item.Description,
                    ItemCode = item.ItemCode,
                    ItemId = item.ItemId,
                    MeasurmentUnit = item.MeasurmentUnit.Value,
                    Name = item.Name,
                    Type = item.Type.Value,
                    SellingPriceCent = item.WarehouseItem.SellingPriceCent.Value,
                    Quantity = item.WarehouseItem.Quantity.Value
                };
                var keyValuePair = result.Find(p => p.Key == row.PartnerId);
                keyValuePair.Value.Add(comItem);
            }



            return result;
        }
    }
}
