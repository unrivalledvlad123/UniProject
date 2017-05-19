using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public enum ItemTypesBg 
        {
            Горива = 0,
            Захарни  = 1,
            Нехранителни = 2,
            Канцеларски = 3,
            Консерви = 4,
            Общи = 5
        }

        public enum UnitTypes
        {
            kg = 0,
            g = 1,
            litre = 2,
            ml = 3,
            ton = 4,
            pc = 5
        }

        public enum UnitTypesBg 
        {
            кг = 0,
            г = 1,
            литър = 2,
            мл = 3,
            тон = 4,
            бр = 5
        }
        public enum DiagramTypeBg
        {
            Покупки = 0,
            Продажби = 1
        }

        public enum DiagramType
        {
            Purchases = 0,
            Sales = 1
        }

        public enum DiagramFor
        {
            Sum = 0,
            Quantityes = 1,
        }

        public enum DiagramForBg
        {
            Сума = 0,
            Количество = 1
        }

    }
}
