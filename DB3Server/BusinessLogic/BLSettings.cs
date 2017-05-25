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

            DatabaseEntities entities = new DatabaseEntities();
            List<ItemTypesDD> dbEntries = entities.ItemTypesDDS.ToList();

            foreach (var row in dbEntries)
            {
                KeyValuePair<int, decimal> pair = new KeyValuePair<int, decimal>(row.Type, row.DDSPercent);
                settings.VatSettingsByGroup.Add(pair);
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
    }
}
