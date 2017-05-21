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
    public class SalesController : ApiController
    {
        [System.Web.Http.Route("api/sales/create-direct")]
        public CommonSale PostCreateDirectSale([FromBody]CommonSale sale)
        {
            return BLSales.CreateSale(sale);
        }
        [System.Web.Http.Route("api/sales/create-whole")]
        public CommonSale PostCreateWholeSale([FromBody]CommonSale sale)
        {
            return BLSales.CreateSale(sale,true);
        }
        [System.Web.Http.Route("api/sales/list/{search?}")]
        public List<CommonSale> GetAllSales(String search = "")
        {
            return BLSales.GetAllSales(search);
        }

    }
    
}
