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
            return BLSales.CreateSale(sale,2);
        }
        [System.Web.Http.Route("api/sales/create-whole")]
        public CommonSale PostCreateWholeSale([FromBody]CommonSale sale)
        {
            return BLSales.CreateSale(sale,2,true);
        }
        [System.Web.Http.Route("api/sales/list/{search?}")]
        public List<CommonSale> GetAllSales(String search = "")
        {
            return BLSales.GetAllSales(search);
        }

        [System.Web.Http.Route("api/sales/invoice/{saleId}")]
        public CommonInvoice GetInvoice(Guid saleId)
        {
            return BLSales.GetInvoice(saleId);
        }


    }

}
