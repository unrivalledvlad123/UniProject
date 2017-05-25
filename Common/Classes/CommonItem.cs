using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Classes
{

    public class CommonItem
    {
        public Guid ItemId { get; set; }
        public string Name { get; set; }
        public  int Type { get; set; }
        public int MeasurmentUnit { get; set; }
        public string Description { get; set; }
        public string ItemCode { get; set; }
        public int SellingPriceCent { get; set; }
        public int Quantity { get; set; }
        public decimal ParcePrice { get; set; }

        public override string ToString()
        {
          
                return this.ItemCode + " (" + this.Name + ")";
          

        }
    }
}
