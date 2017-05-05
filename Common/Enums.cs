using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
     public class Enums
    {
        public enum UserRoles
        {
            Administrator = 0,
            Manager = 1,
            Casher = 2
        }

        public enum SaleType
        {
            Retail = 0,
            Wholesale = 1
        }

        public enum ReportType
        {
            Purchases = 0,
            Sales = 1,
            Both = 2
        }

        public enum ReportTypeBg
        {
            Покупки = 0,
            Продажби = 1,
            Всичко = 2
        }

        public enum ItemTypes
        {
            Fuels = 0,
            Sweets = 1,
            NonFood = 2,
            Stationery = 3,
            CanFood = 4,
            General = 5
        }

        public enum ItemTypesBG 
        {
            Горива = 0,
            Захарни  = 1,
            Нехранителни = 2,
            Канцеларски = 3,
            Консерви = 4,
            Общи = 5
        }

    }
}
