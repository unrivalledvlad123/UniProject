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
                allItems.Add(item1);
            }
            return allItems;
        }
    }
}
