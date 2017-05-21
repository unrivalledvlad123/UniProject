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
    public class ItemController : ApiController
    {

        [System.Web.Http.Route("api/item/list/{search?}")]
        public List<CommonItem> GetAllItems(String search = "")
        {
            return BLItem.GetAllItems(search);
        }
        [System.Web.Http.Route("api/item/get/{search}")]
        public CommonItem GetItemsById(String search)
        {
            return BLItem.GetItemsById(search);
        }

    }
}
