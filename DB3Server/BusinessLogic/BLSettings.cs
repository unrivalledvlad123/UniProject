using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Classes;

namespace DB3Server.BusinessLogic
{
    public class BLSettings
    {

        internal static CommonSettings GetAllSettings()
        {
            CommonSettings settings = new CommonSettings();
            settings.VatSettingsByGroup = new List<KeyValuePair<int, decimal>>();
            settings.Discounts = new List<CommonDiscounts>();

            DatabaseEntities entities = new DatabaseEntities();
            List<ItemTypesDD> dbEntries = entities.ItemTypesDDS.ToList();

            foreach (var row in dbEntries)
            {
                KeyValuePair<int, decimal> pair = new KeyValuePair<int, decimal>(row.Type, row.DDSPercent);
                settings.VatSettingsByGroup.Add(pair);
            }
            List<PartnerDiscount> dbSet = entities.PartnerDiscounts.ToList();
            foreach (var row in dbSet)
            {
                CommonDiscounts element = new CommonDiscounts();
                element.RowId = row.RowID;
                element.Discount = row.Discount;
                element.PartnerType = row.PartnerType;
                element.RangeFrom = row.RangeFrom.Value;
                element.RangeTo = row.RangeTo.Value;
                element.TypeName = row.TypeName;
                settings.Discounts.Add(element);
            }

            return settings;
        }

        internal static bool UpdateSettings(KeyValuePair<int, decimal> pair)
        {
            try
            {
                DatabaseEntities entities = new DatabaseEntities();
                ItemTypesDD result = entities.ItemTypesDDS.FirstOrDefault(p => p.Type == pair.Key);
                if (result == null) return false;
                result.DDSPercent = pair.Value;
                entities.ItemTypesDDS.Attach(result);
                var entry = entities.Entry(result);
                entry.Property(e => e.DDSPercent).IsModified = true;
                entities.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        internal static List<CommonDiscounts> GetDiscountSettings()
        {
            List<CommonDiscounts> result = new List<CommonDiscounts>();
            DatabaseEntities entities = new DatabaseEntities();
            List<PartnerDiscount> dbSet = entities.PartnerDiscounts.ToList();
            foreach (var row in dbSet)
            {
                CommonDiscounts element = new CommonDiscounts();
                element.RowId = row.RowID;
                element.Discount = row.Discount;
                element.PartnerType = row.PartnerType;
                element.RangeFrom = row.RangeFrom.Value;
                element.RangeTo = row.RangeTo.Value;
                element.TypeName = row.TypeName;
                result.Add(element);
            }
            return result;
        }

        internal static bool UpdateDiscount(CommonDiscounts discount)
        {
            try
            {
                DatabaseEntities entities = new DatabaseEntities();
                PartnerDiscount dbSet = entities.PartnerDiscounts.FirstOrDefault(p => p.RowID == discount.RowId);
                dbSet.Discount = discount.Discount;
                dbSet.RangeFrom = discount.RangeFrom;
                dbSet.RangeTo = discount.RangeTo;
                dbSet.TypeName = discount.TypeName;
                entities.PartnerDiscounts.Attach(dbSet);
                var entry = entities.Entry(dbSet);
                entry.Property(e => e.Discount).IsModified = true;
                entry.Property(e => e.RangeFrom).IsModified = true;
                entry.Property(e => e.RangeTo).IsModified = true;
                entry.Property(e => e.TypeName).IsModified = true;
                entities.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
