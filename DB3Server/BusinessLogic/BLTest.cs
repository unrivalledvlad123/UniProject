using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB3Server.BusinessLogic
{
   public class BLTest
    {
        public static string Test()
        {
         DatabaseEntities Database = new DatabaseEntities();  
            //Good vafla = new Good();
            //vafla.Name = "vafla borovec";
            //vafla.Description = "s 6okolad";
            //vafla.Quantity = 0;

           // Database.Goods.Add(vafla);
            Database.SaveChanges();
            var test = Database.Items.FirstOrDefault(p => p.Name == "vafla borovec");
            
            return "not found";
        }

        
    }
}
