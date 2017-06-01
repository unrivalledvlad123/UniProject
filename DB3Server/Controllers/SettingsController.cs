using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Common.Classes;
using DB3Server.BusinessLogic;

namespace DB3Server.Controllers
{
    public class SettingsController : ApiController

    {
        [System.Web.Http.Route("api/settings/getall")]
        public CommonSettings GetAllSettings()
        {
            return BLSettings.GetAllSettings();
        }

        [System.Web.Http.Route("api/settings/update")]
        public bool PostUpdateSettings([FromBody] KeyValuePair<int,decimal> pair)
        {
            return BLSettings.UpdateSettings(pair);
        }
     
        [System.Web.Http.Route("api/settings/getdiscounts")]
        public List<CommonDiscounts> GetDiscountSettings()
        {
            return BLSettings.GetDiscountSettings();
        }

        [System.Web.Http.Route("api/settings/updatediscount")]
        public bool PostUpdateDiscount([FromBody]CommonDiscounts disc)
        {
            return BLSettings.UpdateDiscount(disc);
        }
    }
}
